namespace AtiranUpdateFiles
{
    partial class frmchild
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timerDot = new System.Windows.Forms.Timer(this.components);
            this.backdownload = new System.ComponentModel.BackgroundWorker();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPathdown = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(351, 450);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(436, 31);
            this.progressBar1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(787, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 29;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerDot
            // 
            this.timerDot.Enabled = true;
            this.timerDot.Interval = 1;
            this.timerDot.Tick += new System.EventHandler(this.timerDot_Tick);
            // 
            // backdownload
            // 
            this.backdownload.WorkerReportsProgress = true;
            this.backdownload.WorkerSupportsCancellation = true;
            this.backdownload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backdownload_DoWork);
            this.backdownload.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backdownload_ProgressChanged);
            this.backdownload.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backdownload_RunWorkerCompleted);
            // 
            // lblSize
            // 
            this.lblSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSize.Location = new System.Drawing.Point(110, 421);
            this.lblSize.Name = "lblSize";
            this.lblSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSize.Size = new System.Drawing.Size(140, 23);
            this.lblSize.TabIndex = 23;
            this.lblSize.Text = "0";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSize.Visible = false;
            // 
            // lblPathdown
            // 
            this.lblPathdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPathdown.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathdown.Location = new System.Drawing.Point(349, 499);
            this.lblPathdown.Name = "lblPathdown";
            this.lblPathdown.Size = new System.Drawing.Size(513, 23);
            this.lblPathdown.TabIndex = 24;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStatus.Location = new System.Drawing.Point(413, 403);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStatus.Size = new System.Drawing.Size(346, 29);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = " در حال متصل شدن به سرور";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Visible = false;
            // 
            // frmchild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(169)))));
            this.BackgroundImage = global::AtiranUpdateFiles.Properties.Resources.Atiran_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1148, 709);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPathdown);
            this.Controls.Add(this.lblSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmchild";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم دانلود";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerDot;
        private System.ComponentModel.BackgroundWorker backdownload;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPathdown;
        private System.Windows.Forms.Label lblStatus;
    }
}

