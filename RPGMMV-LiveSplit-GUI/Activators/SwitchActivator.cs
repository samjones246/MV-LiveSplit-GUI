using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGMMV_LiveSplit_GUI
{
    public partial class SwitchActivator : ActivatorSubPanel
    {
        public SwitchActivator()
        {
            InitializeComponent();
        }

        public override Activator GetData()
        {
            Activator data = new Activator();
            data.Type = "switch";
            data.Id = (int)nudId.Value;
            data.Any = rbnAny.Checked;
            data.Value = (string)cbxValue.SelectedItem == "ON" ? 0 : 1;
            return data;
        }

        public override void SetData(Activator data)
        {
            nudId.Value = (decimal)data.Id;
            rbnAny.Checked = (bool)data.Any;
            cbxValue.SelectedItem = data.Value == 1 ? "ON" : "OFF";
        }

        private void rbnValue_CheckedChanged(object sender, EventArgs e)
        {
            cbxValue.Enabled = rbnValue.Checked;
        }
    }
}
