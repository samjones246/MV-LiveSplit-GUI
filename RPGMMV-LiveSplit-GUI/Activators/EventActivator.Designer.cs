
namespace RPGMMV_LiveSplit_GUI
{
    partial class EventActivator
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
            this.nudMap = new System.Windows.Forms.NumericUpDown();
            this.nudLine = new System.Windows.Forms.NumericUpDown();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.nudPage = new System.Windows.Forms.NumericUpDown();
            this.nudEvent = new System.Windows.Forms.NumericUpDown();
            this.rbnCommon = new System.Windows.Forms.RadioButton();
            this.rbnMap = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.nudMap, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.nudLine, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblLine, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lblPage, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.lblEvent, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.nudPage, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.nudEvent, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.rbnCommon, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.rbnMap, 2, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(376, 83);
            this.tableLayoutPanel.TabIndex = 7;
            // 
            // nudMap
            // 
            this.nudMap.Location = new System.Drawing.Point(285, 3);
            this.nudMap.Name = "nudMap";
            this.nudMap.Size = new System.Drawing.Size(88, 22);
            this.nudMap.TabIndex = 11;
            this.nudMap.Minimum = 1;
            this.nudMap.Maximum = 999;
            this.nudMap.Enabled = false;
            // 
            // nudLine
            // 
            this.nudLine.Location = new System.Drawing.Point(97, 57);
            this.nudLine.Name = "nudLine";
            this.nudLine.Size = new System.Drawing.Size(88, 22);
            this.nudLine.TabIndex = 10;
            this.nudLine.Minimum = -1;
            this.nudLine.Maximum = 9999;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLine.Location = new System.Drawing.Point(3, 54);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(88, 29);
            this.lblLine.TabIndex = 9;
            this.lblLine.Text = "Line:";
            this.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPage.Location = new System.Drawing.Point(191, 27);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(88, 27);
            this.lblPage.TabIndex = 7;
            this.lblPage.Text = "Page:";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEvent.Location = new System.Drawing.Point(3, 27);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(88, 27);
            this.lblEvent.TabIndex = 6;
            this.lblEvent.Text = "Event ID:";
            this.lblEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudPage
            // 
            this.nudPage.Location = new System.Drawing.Point(285, 30);
            this.nudPage.Name = "nudPage";
            this.nudPage.Size = new System.Drawing.Size(88, 22);
            this.nudPage.TabIndex = 4;
            this.nudPage.Minimum = 1;
            this.nudPage.Maximum = 999;
            this.nudPage.Enabled = false;
            // 
            // nudEvent
            // 
            this.nudEvent.Location = new System.Drawing.Point(97, 30);
            this.nudEvent.Name = "nudEvent";
            this.nudEvent.Size = new System.Drawing.Size(88, 22);
            this.nudEvent.TabIndex = 5;
            this.nudEvent.Minimum = 1;
            this.nudEvent.Maximum = 9999;
            // 
            // rbnCommon
            // 
            this.rbnCommon.AutoSize = true;
            this.rbnCommon.Location = new System.Drawing.Point(3, 3);
            this.rbnCommon.Name = "rdbCommon";
            this.rbnCommon.Size = new System.Drawing.Size(84, 21);
            this.rbnCommon.TabIndex = 12;
            this.rbnCommon.TabStop = true;
            this.rbnCommon.Text = "Common";
            this.rbnCommon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbnCommon.UseVisualStyleBackColor = true;
            this.rbnCommon.Checked = true;
            // 
            // rbnMap
            // 
            this.rbnMap.AutoSize = true;
            this.rbnMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbnMap.Location = new System.Drawing.Point(191, 3);
            this.rbnMap.Name = "rdbMap";
            this.rbnMap.Size = new System.Drawing.Size(88, 21);
            this.rbnMap.TabIndex = 13;
            this.rbnMap.TabStop = true;
            this.rbnMap.Text = "Map ID:";
            this.rbnMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbnMap.UseVisualStyleBackColor = true;
            // 
            // EventActivator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "EventActivator";
            this.Size = new System.Drawing.Size(382, 89);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.NumericUpDown nudPage;
        private System.Windows.Forms.NumericUpDown nudEvent;
        private System.Windows.Forms.NumericUpDown nudMap;
        private System.Windows.Forms.NumericUpDown nudLine;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.RadioButton rbnCommon;
        private System.Windows.Forms.RadioButton rbnMap;
    }
}
