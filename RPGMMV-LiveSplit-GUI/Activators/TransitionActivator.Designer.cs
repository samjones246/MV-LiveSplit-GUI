
namespace RPGMMV_LiveSplit_GUI
{
    partial class TransitionActivator
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
            this.nudTo = new System.Windows.Forms.NumericUpDown();
            this.nudMap = new System.Windows.Forms.NumericUpDown();
            this.lblMap = new System.Windows.Forms.Label();
            this.nudFrom = new System.Windows.Forms.NumericUpDown();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.lblTo, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.lblFrom, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.nudTo, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.nudFrom, 1, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(376, 57);
            this.tableLayoutPanel.TabIndex = 6;
            // 
            // nudTo
            // 
            this.nudTo.Location = new System.Drawing.Point(285, 31);
            this.nudTo.Name = "nudTo";
            this.nudTo.Size = new System.Drawing.Size(88, 22);
            this.nudTo.TabIndex = 4;
            this.nudTo.Minimum = 0;
            this.nudTo.Maximum = 999;
            // 
            // nudMap
            // 
            this.nudMap.Location = new System.Drawing.Point(97, 3);
            this.nudMap.Name = "nudMap";
            this.nudMap.Size = new System.Drawing.Size(88, 22);
            this.nudMap.TabIndex = 3;
            this.nudMap.Minimum = 0;
            this.nudMap.Maximum = 999;
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMap.Location = new System.Drawing.Point(3, 0);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(88, 28);
            this.lblMap.TabIndex = 0;
            this.lblMap.Text = "Map ID:";
            this.lblMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudFrom
            // 
            this.nudFrom.Location = new System.Drawing.Point(97, 31);
            this.nudFrom.Name = "nudFrom";
            this.nudFrom.Size = new System.Drawing.Size(88, 22);
            this.nudFrom.TabIndex = 5;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFrom.Location = new System.Drawing.Point(3, 28);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(88, 29);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "From:";
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTo.Location = new System.Drawing.Point(191, 28);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(88, 29);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "To:";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransitionActivator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "TransitionActivator";
            this.Size = new System.Drawing.Size(382, 63);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.NumericUpDown nudTo;
        private System.Windows.Forms.NumericUpDown nudMap;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.NumericUpDown nudFrom;
    }
}
