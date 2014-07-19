﻿namespace Configuration.DkimSigner
{
    partial class UpgradeWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpgradeWindow));
            this.picStopService = new System.Windows.Forms.PictureBox();
            this.lbUpgradeStatus = new System.Windows.Forms.Label();
            this.lbStopService = new System.Windows.Forms.Label();
            this.lbCopyFiles = new System.Windows.Forms.Label();
            this.picCopyFiles = new System.Windows.Forms.PictureBox();
            this.lbStartService = new System.Windows.Forms.Label();
            this.picStartService = new System.Windows.Forms.PictureBox();
            this.lbDone = new System.Windows.Forms.Label();
            this.picDone = new System.Windows.Forms.PictureBox();
            this.statusImageList = new System.Windows.Forms.ImageList(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.lbInstallAgent = new System.Windows.Forms.Label();
            this.picInstallAgent = new System.Windows.Forms.PictureBox();
            this.timUpgrade = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picStopService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStartService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstallAgent)).BeginInit();
            this.SuspendLayout();
            // 
            // picStopService
            // 
            this.picStopService.Location = new System.Drawing.Point(15, 39);
            this.picStopService.Name = "picStopService";
            this.picStopService.Size = new System.Drawing.Size(24, 24);
            this.picStopService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picStopService.TabIndex = 0;
            this.picStopService.TabStop = false;
            // 
            // lbUpgradeStatus
            // 
            this.lbUpgradeStatus.AutoSize = true;
            this.lbUpgradeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpgradeStatus.Location = new System.Drawing.Point(12, 13);
            this.lbUpgradeStatus.Name = "lbUpgradeStatus";
            this.lbUpgradeStatus.Size = new System.Drawing.Size(99, 13);
            this.lbUpgradeStatus.TabIndex = 0;
            this.lbUpgradeStatus.Text = "Upgrade Status:";
            // 
            // lbStopService
            // 
            this.lbStopService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStopService.AutoEllipsis = true;
            this.lbStopService.Location = new System.Drawing.Point(45, 39);
            this.lbStopService.Name = "lbStopService";
            this.lbStopService.Size = new System.Drawing.Size(392, 24);
            this.lbStopService.TabIndex = 1;
            this.lbStopService.Text = "Stopping Exchange Transport service";
            this.lbStopService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCopyFiles
            // 
            this.lbCopyFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCopyFiles.AutoEllipsis = true;
            this.lbCopyFiles.Location = new System.Drawing.Point(45, 69);
            this.lbCopyFiles.Name = "lbCopyFiles";
            this.lbCopyFiles.Size = new System.Drawing.Size(392, 24);
            this.lbCopyFiles.TabIndex = 2;
            this.lbCopyFiles.Text = "Copying new files";
            this.lbCopyFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picCopyFiles
            // 
            this.picCopyFiles.Location = new System.Drawing.Point(15, 69);
            this.picCopyFiles.Name = "picCopyFiles";
            this.picCopyFiles.Size = new System.Drawing.Size(24, 24);
            this.picCopyFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCopyFiles.TabIndex = 4;
            this.picCopyFiles.TabStop = false;
            // 
            // lbStartService
            // 
            this.lbStartService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStartService.AutoEllipsis = true;
            this.lbStartService.Location = new System.Drawing.Point(45, 129);
            this.lbStartService.Name = "lbStartService";
            this.lbStartService.Size = new System.Drawing.Size(392, 24);
            this.lbStartService.TabIndex = 4;
            this.lbStartService.Text = "Starting Exchange Transport service";
            this.lbStartService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picStartService
            // 
            this.picStartService.Location = new System.Drawing.Point(15, 129);
            this.picStartService.Name = "picStartService";
            this.picStartService.Size = new System.Drawing.Size(24, 24);
            this.picStartService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picStartService.TabIndex = 6;
            this.picStartService.TabStop = false;
            // 
            // lbDone
            // 
            this.lbDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDone.AutoEllipsis = true;
            this.lbDone.Location = new System.Drawing.Point(45, 159);
            this.lbDone.Name = "lbDone";
            this.lbDone.Size = new System.Drawing.Size(392, 24);
            this.lbDone.TabIndex = 5;
            this.lbDone.Text = "Done";
            this.lbDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picDone
            // 
            this.picDone.Location = new System.Drawing.Point(15, 159);
            this.picDone.Name = "picDone";
            this.picDone.Size = new System.Drawing.Size(24, 24);
            this.picDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDone.TabIndex = 8;
            this.picDone.TabStop = false;
            // 
            // statusImageList
            // 
            this.statusImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("statusImageList.ImageStream")));
            this.statusImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.statusImageList.Images.SetKeyName(0, "check.png");
            this.statusImageList.Images.SetKeyName(1, "error.png");
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(362, 232);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbInstallAgent
            // 
            this.lbInstallAgent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInstallAgent.AutoEllipsis = true;
            this.lbInstallAgent.Location = new System.Drawing.Point(45, 99);
            this.lbInstallAgent.Name = "lbInstallAgent";
            this.lbInstallAgent.Size = new System.Drawing.Size(392, 24);
            this.lbInstallAgent.TabIndex = 3;
            this.lbInstallAgent.Text = "Checking and registering the agent";
            this.lbInstallAgent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picInstallAgent
            // 
            this.picInstallAgent.Location = new System.Drawing.Point(15, 99);
            this.picInstallAgent.Name = "picInstallAgent";
            this.picInstallAgent.Size = new System.Drawing.Size(24, 24);
            this.picInstallAgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picInstallAgent.TabIndex = 11;
            this.picInstallAgent.TabStop = false;
            // 
            // timUpgrade
            // 
            this.timUpgrade.Enabled = true;
            this.timUpgrade.Tick += new System.EventHandler(this.timUpgrade_Tick);
            // 
            // UpgradeWindow
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 267);
            this.Controls.Add(this.lbInstallAgent);
            this.Controls.Add(this.picInstallAgent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbDone);
            this.Controls.Add(this.picDone);
            this.Controls.Add(this.lbStartService);
            this.Controls.Add(this.picStartService);
            this.Controls.Add(this.lbCopyFiles);
            this.Controls.Add(this.picCopyFiles);
            this.Controls.Add(this.lbStopService);
            this.Controls.Add(this.lbUpgradeStatus);
            this.Controls.Add(this.picStopService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpgradeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exchange DkimSigner - Upgrade";
            ((System.ComponentModel.ISupportInitialize)(this.picStopService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStartService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstallAgent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picStopService;
        private System.Windows.Forms.Label lbUpgradeStatus;
        private System.Windows.Forms.Label lbStopService;
        private System.Windows.Forms.Label lbCopyFiles;
        private System.Windows.Forms.PictureBox picCopyFiles;
        private System.Windows.Forms.Label lbStartService;
        private System.Windows.Forms.PictureBox picStartService;
        private System.Windows.Forms.Label lbDone;
        private System.Windows.Forms.PictureBox picDone;
        private System.Windows.Forms.ImageList statusImageList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbInstallAgent;
        private System.Windows.Forms.PictureBox picInstallAgent;
        private System.Windows.Forms.Timer timUpgrade;
    }
}