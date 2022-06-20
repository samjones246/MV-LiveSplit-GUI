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
    public partial class VariableActivator : ActivatorSubPanel
    {
        public VariableActivator()
        {
            InitializeComponent();
        }

        public override Activator GetData()
        {
            Activator data = new Activator();
            data.Type = "variable";
            data.Id = (int)nudId.Value;
            data.Any = rbnAny.Checked;
            data.Value = (int?)nudValue.Value;
            return data;
        }

        public override void SetData(Activator data)
        {
            nudId.Value = (decimal)data.Id;
            rbnAny.Checked = (bool)data.Any;
            nudValue.Value = data.Value.GetValueOrDefault();
        }

        private void rbnValue_CheckedChanged(object sender, EventArgs e)
        {
            nudValue.Enabled = rbnValue.Checked;
        }
    }
}
