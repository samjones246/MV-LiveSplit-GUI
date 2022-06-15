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
    public partial class SplitPointEditor : Form
    {
        public SplitPoint SplitPoint { get; set; }
        public bool Changed { get; set; }
        public bool DefaultEnabled { get; set; }
        public SplitPointEditor()
        {
            InitializeComponent();
        }
        private void SplitPointEditor_Load(object sender, EventArgs e)
        {
            if (SplitPoint == null) {
                SplitPoint = new SplitPoint();
                SplitPoint.name = "New Split";
                SplitPoint.activators = new List<Dictionary<string, object>>();
            }
            UpdateFields();
        }

        private void UpdateFields()
        {
            txtName.Text = SplitPoint.name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    public class ActivatorPanel : Panel
    {
        public Activator Model { get; set; }

        public ActivatorPanel() : base()
        {
           
        }
    }
}
