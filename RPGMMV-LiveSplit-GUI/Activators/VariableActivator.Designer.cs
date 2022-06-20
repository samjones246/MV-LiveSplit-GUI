
namespace RPGMMV_LiveSplit_GUI
{
    partial class VariableActivator
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
            this.lblId = new System.Windows.Forms.Label();
            this.rbnAny = new System.Windows.Forms.RadioButton();
            this.rbnValue = new System.Windows.Forms.RadioButton();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(88, 28);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Variable ID:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(97, 3);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(88, 22);
            this.nudId.TabIndex = 3;
            this.nudId.Minimum = 1;
            this.nudId.Maximum = 999;
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(285, 31);
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(88, 22);
            this.nudValue.TabIndex = 4;
            this.nudValue.Minimum = -999999;
            this.nudValue.Maximum = 999999;
            this.nudValue.Enabled = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.nudValue, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.nudId, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.rbnValue, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.rbnAny, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblId, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(376, 57);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // VariableActivator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "VariableActivator";
            this.Size = new System.Drawing.Size(382, 63);
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.RadioButton rbnAny;
        private System.Windows.Forms.RadioButton rbnValue;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}
