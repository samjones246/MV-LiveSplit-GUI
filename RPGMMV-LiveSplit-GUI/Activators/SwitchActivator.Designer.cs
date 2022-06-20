
namespace RPGMMV_LiveSplit_GUI
{
    partial class SwitchActivator
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.rbnValue = new System.Windows.Forms.RadioButton();
            this.rbnAny = new System.Windows.Forms.RadioButton();
            this.lblId = new System.Windows.Forms.Label();
            this.cbxValue = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.nudId, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.rbnValue, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.rbnAny, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblId, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.cbxValue, 3, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(376, 57);
            this.tableLayoutPanel.TabIndex = 6;
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(97, 3);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(88, 22);
            this.nudId.TabIndex = 3;
            this.nudId.Minimum = 1;
            this.nudId.Maximum = 9999;
            // 
            // rbnValue
            // 
            this.rbnValue.AutoSize = true;
            this.rbnValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbnValue.Location = new System.Drawing.Point(191, 31);
            this.rbnValue.Name = "rbnValue";
            this.rbnValue.Size = new System.Drawing.Size(88, 23);
            this.rbnValue.TabIndex = 2;
            this.rbnValue.TabStop = true;
            this.rbnValue.Text = "Value";
            this.rbnValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbnValue.UseVisualStyleBackColor = true;
            this.rbnValue.CheckedChanged += rbnValue_CheckedChanged;
            // 
            // rbnAny
            // 
            this.rbnAny.AutoSize = true;
            this.rbnAny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbnAny.Location = new System.Drawing.Point(3, 31);
            this.rbnAny.Name = "rbnAny";
            this.rbnAny.Size = new System.Drawing.Size(88, 23);
            this.rbnAny.TabIndex = 1;
            this.rbnAny.TabStop = true;
            this.rbnAny.Text = "Any Change";
            this.rbnAny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbnAny.UseVisualStyleBackColor = true;
            this.rbnAny.Checked = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(88, 28);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Switch ID:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxValue
            // 
            this.cbxValue.FormattingEnabled = true;
            this.cbxValue.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.cbxValue.Location = new System.Drawing.Point(285, 31);
            this.cbxValue.Name = "comboBox1";
            this.cbxValue.Size = new System.Drawing.Size(88, 24);
            this.cbxValue.TabIndex = 4;
            this.cbxValue.SelectedIndex = 0;
            this.cbxValue.Enabled = false;
            // 
            // SwitchActivator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "SwitchActivator";
            this.Size = new System.Drawing.Size(382, 63);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.RadioButton rbnValue;
        private System.Windows.Forms.RadioButton rbnAny;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cbxValue;
    }
}
