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
    public partial class TransitionActivator : ActivatorSubPanel
    {
        public TransitionActivator()
        {
            InitializeComponent();
        }

        public override Activator GetData()
        {
            Activator data = new Activator();
            data.Type = "transition";
            data.From = (int?)nudFrom.Value;
            data.To = (int?)nudTo.Value;
            return data;
        }

        public override void SetData(Activator data)
        {
            nudFrom.Value = (decimal)data.From;
            nudTo.Value = (decimal)data.To;
        }
    }
}
