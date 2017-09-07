namespace Figlut.Aplex.Mobile.DeviceConfig
{
    partial class SpecialInstructionsForm
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
            this.txtSpecialInstructions = new System.Windows.Forms.TextBox();
            this.lblSpecialInstructions = new System.Windows.Forms.Label();
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
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.Add(this.mnuBack);
            // 
            // mnuBack
            // 
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // txtSpecialInstructions
            // 
            this.txtSpecialInstructions.Location = new System.Drawing.Point(3, 116);
            this.txtSpecialInstructions.Multiline = true;
            this.txtSpecialInstructions.Name = "txtSpecialInstructions";
            this.txtSpecialInstructions.ReadOnly = true;
            this.txtSpecialInstructions.Size = new System.Drawing.Size(234, 124);
            this.txtSpecialInstructions.TabIndex = 23;
            // 
            // lblSpecialInstructions
            // 
            this.lblSpecialInstructions.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblSpecialInstructions.Location = new System.Drawing.Point(3, 93);
            this.lblSpecialInstructions.Name = "lblSpecialInstructions";
            this.lblSpecialInstructions.Size = new System.Drawing.Size(113, 20);
            this.lblSpecialInstructions.Text = "Special Instructions:";
            // 
            // SpecialInstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtSpecialInstructions);
            this.Controls.Add(this.lblSpecialInstructions);
            this.Menu = this.mnuMain;
            this.Name = "SpecialInstructionsForm";
            this.Text = "Special Instructions";
            this.Load += new System.EventHandler(this.SpecialInstructionsForm_Load);
            this.Controls.SetChildIndex(this.statusMain, 0);
            this.Controls.SetChildIndex(this.picLogo, 0);
            this.Controls.SetChildIndex(this.lblSpecialInstructions, 0);
            this.Controls.SetChildIndex(this.txtSpecialInstructions, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem mnuBack;
        private System.Windows.Forms.TextBox txtSpecialInstructions;
        private System.Windows.Forms.Label lblSpecialInstructions;
    }
}