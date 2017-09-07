namespace Figlut.Aplex.Mobile.Demo
{
    partial class LogDeviceConfigActionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mnuMain;

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
            this.mnuMain = new System.Windows.Forms.MainMenu();
            this.mnuBack = new System.Windows.Forms.MenuItem();
            this.mnuLog = new System.Windows.Forms.MenuItem();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // statusMain
            // 
            this.statusMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.statusMain.Location = new System.Drawing.Point(0, 246);
            this.statusMain.Size = new System.Drawing.Size(240, 22);
            this.statusMain.Text = "Enter info and log action to server.";
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.Add(this.mnuBack);
            this.mnuMain.MenuItems.Add(this.mnuLog);
            // 
            // mnuBack
            // 
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuLog
            // 
            this.mnuLog.Text = "Log";
            this.mnuLog.Click += new System.EventHandler(this.mnuLog_Click);
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(3, 108);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(234, 21);
            this.txtFunction.TabIndex = 6;
            // 
            // lblFunction
            // 
            this.lblFunction.Location = new System.Drawing.Point(3, 85);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(234, 20);
            this.lblFunction.Text = "Function:";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(3, 155);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(234, 21);
            this.txtTag.TabIndex = 9;
            // 
            // lblTag
            // 
            this.lblTag.Location = new System.Drawing.Point(3, 132);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(234, 20);
            this.lblTag.Text = "Tag:";
            // 
            // LogDeviceConfigActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.txtFunction);
            this.Controls.Add(this.lblFunction);
            this.Menu = this.mnuMain;
            this.Name = "LogDeviceConfigActionForm";
            this.Text = "Log Device Action";
            this.Controls.SetChildIndex(this.picLogo, 0);
            this.Controls.SetChildIndex(this.statusMain, 0);
            this.Controls.SetChildIndex(this.lblFunction, 0);
            this.Controls.SetChildIndex(this.txtFunction, 0);
            this.Controls.SetChildIndex(this.lblTag, 0);
            this.Controls.SetChildIndex(this.txtTag, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.MenuItem mnuBack;
        private System.Windows.Forms.MenuItem mnuLog;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label lblTag;
    }
}