using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace RPGMMV_LiveSplit_GUI
{
    public partial class SplitPointEditor : Form
    {
        public SplitPoint SplitPoint { get; set; }
        public bool DefaultEnabled { get; set; }
        public List<ActivatorPanel> activatorPanels;

        public SplitPointEditor()
        {
            InitializeComponent();
        }
        private void SplitPointEditor_Load(object sender, EventArgs e)
        {
            if (SplitPoint == null) {
                SplitPoint = new SplitPoint();
                SplitPoint.name = "New Split";
                SplitPoint.activators = new List<Activator>();
            }
            UpdateFields();
        }

        private void UpdateFields()
        {
            txtName.Text = SplitPoint.name;
            chkDefault.Checked = DefaultEnabled;
            chkStart.Checked = SplitPoint.Start;
            activatorPanels = new List<ActivatorPanel>();
            foreach(Activator activator in SplitPoint.activators)
            {
                CreateActivatorPanel(activator);
            }
        }

        private List<Activator> GetActivators()
        {
            List<Activator> activators = new List<Activator>();
            foreach (Control panel in activatorsPanel.Controls)
            {
                activators.Add(((ActivatorPanel)panel).GetData());
            }
            return activators;
        }

        private void CreateActivatorPanel(Activator activator = null)
        {
            if (activator == null)
            {
                activator = new Activator();
                activator.Type = "transition";
                activator.From = 1;
                activator.To = 2;
            }
            ActivatorPanel panel = new ActivatorPanel();
            int offset = 5;
            int y = (offset + panel.Height) * activatorPanels.Count + offset;
            panel.Location = new Point(offset, y);
            panel.btnDelete.Click += delegate (object sender, EventArgs e)
            {
                int i = activatorPanels.IndexOf(panel);
                DeleteActivatorPanel(i);
            };
            panel.SetData(activator);
            activatorPanels.Add(panel);
            activatorsPanel.Controls.Add(panel);
            activatorsPanel.Refresh();
        }

        private void DeleteActivatorPanel(int index)
        {
            ActivatorPanel target = activatorPanels[index];
            for (int i=index+1; i < activatorPanels.Count; i++)
            {
                ActivatorPanel panel = activatorPanels[i];
                panel.Location = new Point(panel.Location.X, panel.Location.Y - (panel.Location.X + target.Height));
            }
            activatorPanels.RemoveAt(index);
            activatorsPanel.Controls.RemoveAt(index);
            activatorsPanel.Refresh();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SplitPoint.name = txtName.Text;
            SplitPoint.activators = GetActivators();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkDefault_CheckedChanged(object sender, EventArgs e)
        {
            DefaultEnabled = chkDefault.Checked;
        }

        private void btnAddActivator_Click(object sender, EventArgs e)
        {
            CreateActivatorPanel();
        }

        private void chkStart_CheckedChanged(object sender, EventArgs e)
        {
            SplitPoint.Start = chkStart.Checked;
        }
    }
}
