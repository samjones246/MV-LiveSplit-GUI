
namespace RPGMMV_LiveSplit_GUI
{
    partial class SplitPointEditor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.activatorsPanel = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblActivators = new System.Windows.Forms.Label();
            this.btnAddActivator = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // activatorsPanel
            // 
            this.activatorsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.activatorsPanel.AutoScroll = true;
            this.activatorsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.activatorsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activatorsPanel.Location = new System.Drawing.Point(12, 72);
            this.activatorsPanel.MinimumSize = new System.Drawing.Size(420, 150);
            this.activatorsPanel.Name = "activatorsPanel";
            this.activatorsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.activatorsPanel.Size = new System.Drawing.Size(420, 150);
            this.activatorsPanel.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblActivators
            // 
            this.lblActivators.AutoSize = true;
            this.lblActivators.Location = new System.Drawing.Point(12, 44);
            this.lblActivators.Name = "lblActivators";
            this.lblActivators.Size = new System.Drawing.Size(70, 17);
            this.lblActivators.TabIndex = 3;
            this.lblActivators.Text = "Activators";
            // 
            // btnAddActivator
            // 
            this.btnAddActivator.Location = new System.Drawing.Point(88, 39);
            this.btnAddActivator.Name = "btnAddActivator";
            this.btnAddActivator.Size = new System.Drawing.Size(75, 27);
            this.btnAddActivator.TabIndex = 4;
            this.btnAddActivator.Text = "Add";
            this.btnAddActivator.UseVisualStyleBackColor = true;
            this.btnAddActivator.Click += new System.EventHandler(this.btnAddActivator_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(357, 234);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 27);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(276, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkDefault
            // 
            this.chkDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDefault.AutoSize = true;
            this.chkDefault.Location = new System.Drawing.Point(357, 7);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(75, 21);
            this.chkDefault.TabIndex = 7;
            this.chkDefault.Text = "Default";
            this.chkDefault.UseVisualStyleBackColor = true;
            this.chkDefault.CheckedChanged += new System.EventHandler(this.chkDefault_CheckedChanged);
            // 
            // SplitPointEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(442, 269);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAddActivator);
            this.Controls.Add(this.lblActivators);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.activatorsPanel);
            this.Name = "SplitPointEditor";
            this.Text = "Edit Split Point";
            this.Load += new System.EventHandler(this.SplitPointEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel activatorsPanel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblActivators;
        private System.Windows.Forms.Button btnAddActivator;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkDefault;
    }
}