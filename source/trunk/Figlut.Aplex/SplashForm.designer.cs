namespace Figlut.Aplex
{
    partial class SplashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.pnlTitle = new Figlut.Desktop.Controls.GradientPanel();
            this.progressMain = new System.Windows.Forms.ProgressBar();
            this.lblApplicationTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFormContent.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(559, 21);
            this.lblFormTitle.Text = "Figlut APLEX ";
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 283);
            this.statusMain.Size = new System.Drawing.Size(559, 21);
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Controls.Add(this.pnlTitle);
            this.pnlFormContent.Size = new System.Drawing.Size(529, 262);
            // 
            // pnlFormLeft
            // 
            this.pnlFormLeft.Size = new System.Drawing.Size(15, 262);
            // 
            // pnlFormRight
            // 
            this.pnlFormRight.Location = new System.Drawing.Point(544, 21);
            this.pnlFormRight.Size = new System.Drawing.Size(15, 262);
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 10;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.DimGray;
            this.pnlTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitle.BackgroundImage")));
            this.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTitle.Controls.Add(this.progressMain);
            this.pnlTitle.Controls.Add(this.lblApplicationTitle);
            this.pnlTitle.Controls.Add(this.lblVersion);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitle.GradientEndColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTitle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlTitle.GradientStartColor = System.Drawing.Color.DarkGray;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(529, 262);
            this.pnlTitle.TabIndex = 148;
            // 
            // progressMain
            // 
            this.progressMain.BackColor = System.Drawing.Color.White;
            this.progressMain.ForeColor = System.Drawing.Color.Gainsboro;
            this.progressMain.Location = new System.Drawing.Point(36, 231);
            this.progressMain.Name = "progressMain";
            this.progressMain.Size = new System.Drawing.Size(463, 15);
            this.progressMain.Step = 1;
            this.progressMain.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressMain.TabIndex = 39;
            // 
            // lblApplicationTitle
            // 
            this.lblApplicationTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationTitle.Font = new System.Drawing.Font("Buxton Sketch", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTitle.Location = new System.Drawing.Point(156, 140);
            this.lblApplicationTitle.Name = "lblApplicationTitle";
            this.lblApplicationTitle.Size = new System.Drawing.Size(213, 43);
            this.lblApplicationTitle.TabIndex = 37;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblVersion.Location = new System.Drawing.Point(209, 197);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(107, 20);
            this.lblVersion.TabIndex = 38;
            this.lblVersion.Text = "Version 0.0.0.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(559, 304);
            this.ControlBox = false;
            this.FormTitle = "Figlut APLEX";
            this.Name = "SplashForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figlut APLEX";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.pnlFormContent.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrMain;
        private Figlut.Desktop.Controls.GradientPanel pnlTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressMain;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblApplicationTitle;
    }
}