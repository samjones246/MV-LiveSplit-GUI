
namespace RPGMMV_LiveSplit_GUI
{
    partial class MainWindow
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
            this.btnInstall = new System.Windows.Forms.Button();
            this.lstSplitPoints = new System.Windows.Forms.CheckedListBox();
            this.btnAddSplitPoint = new System.Windows.Forms.Button();
            this.btnEditSplitPoint = new System.Windows.Forms.Button();
            this.btnDeleteSplitPoint = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInstall
            // 
            this.btnInstall.Enabled = false;
            this.btnInstall.Location = new System.Drawing.Point(154, 10);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(136, 30);
            this.btnInstall.TabIndex = 0;
            this.btnInstall.Text = "Install Plugin";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // lstSplitPoints
            // 
            this.lstSplitPoints.FormattingEnabled = true;
            this.lstSplitPoints.Location = new System.Drawing.Point(12, 48);
            this.lstSplitPoints.Name = "lstSplitPoints";
            this.lstSplitPoints.Size = new System.Drawing.Size(278, 378);
            this.lstSplitPoints.TabIndex = 3;
            // 
            // btnAddSplitPoint
            // 
            this.btnAddSplitPoint.Enabled = false;
            this.btnAddSplitPoint.Location = new System.Drawing.Point(296, 48);
            this.btnAddSplitPoint.Name = "btnAddSplitPoint";
            this.btnAddSplitPoint.Size = new System.Drawing.Size(136, 30);
            this.btnAddSplitPoint.TabIndex = 4;
            this.btnAddSplitPoint.Text = "Add";
            this.btnAddSplitPoint.UseVisualStyleBackColor = true;
            this.btnAddSplitPoint.Click += new System.EventHandler(this.btnAddSplitPoint_Click);
            // 
            // btnEditSplitPoint
            // 
            this.btnEditSplitPoint.Enabled = false;
            this.btnEditSplitPoint.Location = new System.Drawing.Point(296, 84);
            this.btnEditSplitPoint.Name = "btnEditSplitPoint";
            this.btnEditSplitPoint.Size = new System.Drawing.Size(136, 30);
            this.btnEditSplitPoint.TabIndex = 5;
            this.btnEditSplitPoint.Text = "Edit";
            this.btnEditSplitPoint.UseVisualStyleBackColor = true;
            this.btnEditSplitPoint.Click += new System.EventHandler(this.btnEditSplitPoint_Click);
            // 
            // btnDeleteSplitPoint
            // 
            this.btnDeleteSplitPoint.Enabled = false;
            this.btnDeleteSplitPoint.Location = new System.Drawing.Point(296, 120);
            this.btnDeleteSplitPoint.Name = "btnDeleteSplitPoint";
            this.btnDeleteSplitPoint.Size = new System.Drawing.Size(136, 30);
            this.btnDeleteSplitPoint.TabIndex = 6;
            this.btnDeleteSplitPoint.Text = "Delete";
            this.btnDeleteSplitPoint.UseVisualStyleBackColor = true;
            this.btnDeleteSplitPoint.Click += new System.EventHandler(this.btnDeleteSplitPoint_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 17);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "No game";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(296, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenGame
            // 
            this.btnOpenGame.Location = new System.Drawing.Point(296, 360);
            this.btnOpenGame.Name = "btnOpenGame";
            this.btnOpenGame.Size = new System.Drawing.Size(136, 30);
            this.btnOpenGame.TabIndex = 9;
            this.btnOpenGame.Text = "Open Game...";
            this.btnOpenGame.UseVisualStyleBackColor = true;
            this.btnOpenGame.Click += new System.EventHandler(this.btnOpenGame_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 438);
            this.Controls.Add(this.btnOpenGame);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDeleteSplitPoint);
            this.Controls.Add(this.btnEditSplitPoint);
            this.Controls.Add(this.btnAddSplitPoint);
            this.Controls.Add(this.lstSplitPoints);
            this.Controls.Add(this.btnInstall);
            this.Name = "MainWindow";
            this.Text = "MV LiveSplit";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.CheckedListBox lstSplitPoints;
        private System.Windows.Forms.Button btnAddSplitPoint;
        private System.Windows.Forms.Button btnEditSplitPoint;
        private System.Windows.Forms.Button btnDeleteSplitPoint;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenGame;
    }
}

