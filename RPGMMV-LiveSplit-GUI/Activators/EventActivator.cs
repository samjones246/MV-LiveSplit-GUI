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
    public partial class EventActivator : ActivatorSubPanel
    {
        public EventActivator()
        {
            InitializeComponent();
            rbnMap.CheckedChanged += rdbMap_CheckedChanged;
        }

        private void rdbMap_CheckedChanged(object sender, EventArgs e)
        {
            nudMap.Enabled = rbnMap.Checked;
            nudPage.Enabled = rbnMap.Checked;
        }

        public override Activator GetData()
        {
            Activator data = new Activator();
            data.Type = "event";
            data.Common = rbnCommon.Checked;
            data.Map = (int)nudMap.Value;
            data.Event = (int)nudEvent.Value;
            data.Page = (int)nudPage.Value;
            data.Line = (int)nudLine.Value;
            return data;
        }

        public override void SetData(Activator data)
        {
            rbnCommon.Checked = data.Common.GetValueOrDefault();
            rbnMap.Checked = !rbnCommon.Checked;
            nudMap.Enabled = rbnMap.Checked;
            nudPage.Enabled = rbnMap.Checked;
            nudMap.Value = data.Map.GetValueOrDefault();
            nudEvent.Value = (decimal)data.Event;
            nudPage.Value = (decimal)data.Page;
            nudLine.Value = (decimal)data.Line;
        }
    }
}
