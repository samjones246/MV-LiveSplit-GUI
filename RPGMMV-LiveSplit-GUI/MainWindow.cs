﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;

namespace RPGMMV_LiveSplit_GUI
{
    public partial class MainWindow : Form
    {
        static readonly HttpClient httpClient = new HttpClient();
        private FolderBrowserDialog folderBrowser;

        private string plugin = null;
        private const string PLUGIN_URL = "https://raw.githubusercontent.com/samjones246/rpgmmv-livesplit/master/js/plugins/LiveSplit.js";

        private Autosplitter autosplitter;
        private Dictionary<string, bool> splitPrefs;
        private List<PluginEntry> pluginsList;

        private bool changed = false;
        private bool open = false;
        
        public MainWindow()
        {
            InitializeComponent();
            RetrievePlugin();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = Properties.Settings.Default.LastGamePath;
            folderBrowser.ShowNewFolderButton = false;
            folderBrowser.Description = "Select the directory where the target game exe is located";
        }

        private bool OpenGame()
        {
            // Get the game path from the user
            DialogResult result = folderBrowser.ShowDialog();
            if (result != DialogResult.OK)
            {
                return false;
            }

            string listPath = folderBrowser.SelectedPath + @"\www\js\plugins.js";
            string pluginsDirPath = folderBrowser.SelectedPath + @"\www\js\plugins";
            string pluginPath = pluginsDirPath + @"\LiveSplit.js";
            string autosplitterPath = folderBrowser.SelectedPath + @"\Autosplitter.json";
            string prefsPath = folderBrowser.SelectedPath + @"\AutosplitterSettings.json";
            // Check that the game path is valid
            if (!Directory.Exists(pluginsDirPath) || !File.Exists(listPath))
            {
                throw new Exception("Not a valid game folder");
            }

            open = true;
            // Get plugin status
            LoadPluginsList(listPath);
            UpdatePluginStatus();

            // Open or create Autosplitter
            LoadAutosplitter(autosplitterPath, prefsPath);

            // Enable buttons
            btnAddSplitPoint.Enabled = true;
            btnSave.Enabled = true;

            // Save path and return
            Properties.Settings.Default.LastGamePath = folderBrowser.SelectedPath;
            Properties.Settings.Default.Save();
            changed = false;
            return true;
        }

        private void UpdatePluginStatus()
        {
            string pluginPath = folderBrowser.SelectedPath + @"\www\js\plugins\LiveSplit.js";
            bool installed = File.Exists(pluginPath)
                && pluginsList.Exists(entry => entry.name == "LiveSplit");
            bool updated = installed && (plugin == null || File.ReadAllText(pluginPath) == plugin);
            if (installed)
            {
                if (updated)
                {
                    lblStatus.Text = "Plugin: Installed";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "Plugin: Outdated";
                    lblStatus.ForeColor = Color.Orange;
                }
            }
            else
            {
                lblStatus.Text = "Plugin: Missing";
                lblStatus.ForeColor = Color.Red;
            }
            btnInstall.Enabled = plugin != null && (!installed || !updated);
        }

        private void LoadPluginsList(string path)
        {
            string pluginsContent = File.ReadAllText(path, Encoding.UTF8);
            int arrayStart = pluginsContent.IndexOf('[');
            int arrayEnd = pluginsContent.IndexOf(';');
            pluginsContent = pluginsContent.Substring(arrayStart, arrayEnd - arrayStart);
            pluginsList = JsonSerializer.Deserialize<List<PluginEntry>>(pluginsContent);
        }

        private void WritePluginsList(string path)
        {
            string outputText = "// Generated by RPG Maker.\n// Do not edit this file directly.\nvar $plugins =\n";
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };
            outputText += JsonSerializer.Serialize(pluginsList, options) + ";";
            StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8);
            writer.Write(outputText);
            writer.Close();
        }

        private void PopulateSplitsList()
        {
            lstSplitPoints.Items.Clear();
            foreach (SplitPoint split in autosplitter.splits)
            {
                lstSplitPoints.Items.Add(split, splitPrefs[split.name]);
            }
        }

        private void LoadAutosplitter(string path, string prefsPath)
        {
            // Load/Create autosplitter
            if (File.Exists(path))
            {
                string autosplitterText = File.ReadAllText(path);
                autosplitter = JsonSerializer.Deserialize<Autosplitter>(autosplitterText);
            }
            else
            {
                autosplitter = new Autosplitter();
                autosplitter.splits = new List<SplitPoint>();
                autosplitter.defaults = new Dictionary<string, bool>();
            }

            // Load/Create settings
            if (File.Exists(prefsPath))
            {
                string prefsText = File.ReadAllText(prefsPath);
                splitPrefs = JsonSerializer.Deserialize<Dictionary<string, bool>>(prefsText);

                // Check for missing keys in settings
                foreach (string key in autosplitter.defaults.Keys)
                {
                    if (!splitPrefs.ContainsKey(key))
                    {
                        splitPrefs.Add(key, autosplitter.defaults[key]);
                    }
                }
            }
            else
            {
                splitPrefs = autosplitter.defaults;
            }
            PopulateSplitsList();
        }

        private void WriteAutosplitter(string path, string prefsPath)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };
            // Write autosplitter
            string outputText = JsonSerializer.Serialize(autosplitter, options);
            StreamWriter writer = new StreamWriter(path);
            writer.Write(outputText);
            writer.Close();

            // Write settings
            outputText = JsonSerializer.Serialize(splitPrefs, options);
            writer = new StreamWriter(prefsPath);
            writer.Write(outputText);
            writer.Close();
            changed = false;
        }

        private void InstallPlugin(string path)
        {
            // Write LiveSplit.js
            StreamWriter writer = new StreamWriter(path);
            writer.Write(plugin);
            writer.Close();

            // Add entry to plugins.js if required
            if (!pluginsList.Exists(entry => entry.name == "LiveSplit"))
            {
                pluginsList.Add(new PluginEntry("LiveSplit", true));
                WritePluginsList(folderBrowser.SelectedPath + @"\www\js\plugins.js");
            }    
        }

        private async void RetrievePlugin()
        {
            try
            {
                plugin = await httpClient.GetStringAsync(PLUGIN_URL);
                if (open)
                {
                    UpdatePluginStatus();
                }
            }
            catch(HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine(ex.StackTrace);
        }

        private void AddSplitPoint()
        {
            SplitPointEditor editor = new SplitPointEditor();
            DialogResult result = editor.ShowDialog();
            if (result == DialogResult.OK)
            {
                autosplitter.splits.Add(editor.SplitPoint);
                autosplitter.defaults[editor.SplitPoint.name] = editor.DefaultEnabled;
                lstSplitPoints.Items.Add(editor.SplitPoint.name, editor.DefaultEnabled);
            }
        }

        private void EditSplitPoint()
        {
            SplitPointEditor editor = new SplitPointEditor();
            SplitPoint target = (SplitPoint)lstSplitPoints.SelectedItem;
            editor.SplitPoint = new SplitPoint();
            editor.SplitPoint.CopyFrom(target);
            DialogResult result = editor.ShowDialog();
            if (result == DialogResult.OK && editor.Changed)
            {
                target.CopyFrom(editor.SplitPoint);
            }
        }

        // -- Event Handlers --

        private void btnInstall_Click(object sender, EventArgs e)
        {
            try
            {
                InstallPlugin(folderBrowser.SelectedPath + @"\www\js\plugins\LiveSplit.js");
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnAddSplitPoint_Click(object sender, EventArgs e)
        {
            AddSplitPoint();
        }

        private void btnEditSplitPoint_Click(object sender, EventArgs e)
        {
            EditSplitPoint();
        }

        private void btnDeleteSplitPoint_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenGame_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            if (changed)
            {
                result = MessageBox.Show("Save changes before opening another game?", "Confirm", 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            }
            try
            {
                if (result == DialogResult.Yes)
                {
                    string path = folderBrowser.SelectedPath + @"\Autosplitter.json";
                    string prefsPath = folderBrowser.SelectedPath + @"\AutosplitterSettings.json";
                    WriteAutosplitter(path, prefsPath);
                }
                if (result != DialogResult.Cancel)
                {
                    OpenGame();
                }
            }
            catch(Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = folderBrowser.SelectedPath + @"\Autosplitter.json";
                string prefsPath = folderBrowser.SelectedPath + @"\AutosplitterSettings.json";
                WriteAutosplitter(path, prefsPath);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void lstSplitPoints_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            SplitPoint splitPoint = (SplitPoint)lstSplitPoints.Items[e.Index];
            splitPrefs[splitPoint.name] = e.NewValue == CheckState.Checked;
        }

        private void lstSplitPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditSplitPoint.Enabled = lstSplitPoints.SelectedIndex != -1;
            btnDeleteSplitPoint.Enabled = lstSplitPoints.SelectedIndex != -1;
        }
    }
}
