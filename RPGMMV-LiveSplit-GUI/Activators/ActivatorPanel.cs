using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGMMV_LiveSplit_GUI
{
    public partial class ActivatorPanel : UserControl
    {
        private ActivatorSubPanel subPanel;
        private EventActivator subPanel_event;
        private TransitionActivator subPanel_transition;
        private SwitchActivator subPanel_switch;
        private VariableActivator subPanel_variable;

        public ActivatorPanel()
        {
            InitializeComponent();
            subPanel_event = new EventActivator();
            subPanel_event.Location = new Point(0, cbxType.Height + 3);
            subPanel_transition = new TransitionActivator();
            subPanel_transition.Location = new Point(0, cbxType.Height + 3);
            subPanel_switch = new SwitchActivator();
            subPanel_switch.Location = new Point(0, cbxType.Height + 3);
            subPanel_variable = new VariableActivator();
            subPanel_variable.Location = new Point(0, cbxType.Height + 3);

            cbxType.SelectedIndexChanged += cbxType_SelectedIndexChanged;
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetType(((string)cbxType.SelectedItem).ToLower());
        }

        private void ActivatorPanel_Load(object sender, EventArgs e)
        {
        }

        public Activator GetData()
        {
            return subPanel.GetData();
        }

        public void SetData(Activator data)
        {
            SetType(data.Type);
            subPanel.SetData(data);
        }

        private void SetType(string type)
        {
            cbxType.SelectedItem = type.Substring(0, 1).ToUpper() + type.Substring(1);
            Controls.Remove(subPanel);
            switch (type)
            {
                case "transition":
                    subPanel = subPanel_transition;
                    break;
                case "event":
                    subPanel = subPanel_event;
                    break;
                case "switch":
                    subPanel = subPanel_switch;
                    break;
                case "variable":
                    subPanel = subPanel_variable;
                    break;
            }
            Controls.Add(subPanel);
        }
    }

    public abstract class ActivatorSubPanel : UserControl
    {
        public abstract Activator GetData();

        public abstract void SetData(Activator data);
    }
}
