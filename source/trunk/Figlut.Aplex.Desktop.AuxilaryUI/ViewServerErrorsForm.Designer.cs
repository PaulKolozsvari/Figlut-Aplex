namespace Figlut.Aplex.Desktop.AuxilaryUI
{
    partial class ViewServerErrorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewServerErrorsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuMain = new Figlut.Desktop.Controls.CustomMainMenu();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlServerErrors = new Figlut.Desktop.Controls.GradientPanel();
            this.grdServerErrors = new Figlut.Desktop.Controls.CustomDataGridView();
            this.txtErrorMessage = new System.Windows.Forms.TextBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.picResizeWindow = new System.Windows.Forms.PictureBox();
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.mnuMain.SuspendLayout();
            this.pnlServerErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServerErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(575, 21);
            this.lblFormTitle.Text = "Server Errors ";
            this.lblFormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewDeviceErrorsForm_MouseMove);
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewDeviceErrorsForm_MouseDown);
            this.lblFormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewDeviceErrorsForm_MouseUp);
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 383);
            this.statusMain.Size = new System.Drawing.Size(575, 21);
            this.statusMain.Text = "Logged server errors.";
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Size = new System.Drawing.Size(545, 362);
            // 
            // pnlFormLeft
            // 
            this.pnlFormLeft.Size = new System.Drawing.Size(15, 362);
            // 
            // pnlFormRight
            // 
            this.pnlFormRight.Location = new System.Drawing.Point(560, 21);
            this.pnlFormRight.Size = new System.Drawing.Size(15, 362);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(15, 21);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(545, 24);
            this.mnuMain.TabIndex = 161;
            this.mnuMain.Text = "customMainMenu1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRefresh,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.mnuCancel});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuRefresh
            // 
            this.mnuRefresh.Name = "mnuRefresh";
            this.mnuRefresh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuRefresh.Size = new System.Drawing.Size(154, 22);
            this.mnuRefresh.Text = "&Refresh";
            this.mnuRefresh.Click += new System.EventHandler(this.ViewDeviceErrorsForm_Load);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // mnuCancel
            // 
            this.mnuCancel.Name = "mnuCancel";
            this.mnuCancel.Size = new System.Drawing.Size(154, 22);
            this.mnuCancel.Text = "&Cancel";
            this.mnuCancel.Click += new System.EventHandler(this.mnuCancel_Click);
            // 
            // pnlServerErrors
            // 
            this.pnlServerErrors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlServerErrors.BackgroundImage")));
            this.pnlServerErrors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlServerErrors.Controls.Add(this.grdServerErrors);
            this.pnlServerErrors.Controls.Add(this.txtErrorMessage);
            this.pnlServerErrors.Controls.Add(this.lblErrorMessage);
            this.pnlServerErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlServerErrors.GradientEndColor = System.Drawing.Color.DimGray;
            this.pnlServerErrors.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlServerErrors.GradientStartColor = System.Drawing.Color.DarkGray;
            this.pnlServerErrors.Location = new System.Drawing.Point(15, 45);
            this.pnlServerErrors.Name = "pnlServerErrors";
            this.pnlServerErrors.Size = new System.Drawing.Size(545, 338);
            this.pnlServerErrors.TabIndex = 163;
            // 
            // grdServerErrors
            // 
            this.grdServerErrors.AllowUserToAddRows = false;
            this.grdServerErrors.AllowUserToDeleteRows = false;
            this.grdServerErrors.AllowUserToResizeRows = false;
            this.grdServerErrors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.grdServerErrors.BackgroundEndColor = System.Drawing.Color.LightGray;
            this.grdServerErrors.BackgroundStartColor = System.Drawing.Color.WhiteSmoke;
            this.grdServerErrors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdServerErrors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdServerErrors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdServerErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdServerErrors.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdServerErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdServerErrors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdServerErrors.EnableHeadersVisualStyles = false;
            this.grdServerErrors.GridColor = System.Drawing.Color.DimGray;
            this.grdServerErrors.Location = new System.Drawing.Point(0, 33);
            this.grdServerErrors.MultiSelect = false;
            this.grdServerErrors.Name = "grdServerErrors";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdServerErrors.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdServerErrors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdServerErrors.Size = new System.Drawing.Size(545, 305);
            this.grdServerErrors.TabIndex = 266;
            // 
            // txtErrorMessage
            // 
            this.txtErrorMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtErrorMessage.Location = new System.Drawing.Point(0, 13);
            this.txtErrorMessage.Name = "txtErrorMessage";
            this.txtErrorMessage.Size = new System.Drawing.Size(545, 20);
            this.txtErrorMessage.TabIndex = 121;
            this.txtErrorMessage.TextChanged += new System.EventHandler(this.txtFieldChanged_TextChanged);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblErrorMessage.Location = new System.Drawing.Point(0, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(78, 13);
            this.lblErrorMessage.TabIndex = 122;
            this.lblErrorMessage.Text = "Error Message:";
            // 
            // picResizeWindow
            // 
            this.picResizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picResizeWindow.BackColor = System.Drawing.Color.DimGray;
            this.picResizeWindow.ErrorImage = null;
            this.picResizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("picResizeWindow.Image")));
            this.picResizeWindow.Location = new System.Drawing.Point(559, 389);
            this.picResizeWindow.Name = "picResizeWindow";
            this.picResizeWindow.Size = new System.Drawing.Size(16, 15);
            this.picResizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResizeWindow.TabIndex = 270;
            this.picResizeWindow.TabStop = false;
            this.picResizeWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picResizeWindow_MouseMove);
            // 
            // picMaximize
            // 
            this.picMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaximize.BackColor = System.Drawing.Color.DarkGray;
            this.picMaximize.Image = ((System.Drawing.Image)(resources.GetObject("picMaximize.Image")));
            this.picMaximize.Location = new System.Drawing.Point(468, 5);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(16, 16);
            this.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMaximize.TabIndex = 271;
            this.picMaximize.TabStop = false;
            this.picMaximize.Click += new System.EventHandler(this.picMaximize_Click);
            // 
            // ViewServerErrorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 404);
            this.Controls.Add(this.picMaximize);
            this.Controls.Add(this.picResizeWindow);
            this.Controls.Add(this.pnlServerErrors);
            this.Controls.Add(this.mnuMain);
            this.FormTitle = "Server Errors";
            this.KeyPreview = true;
            this.Name = "ViewServerErrorsForm";
            this.ShowInTaskbar = false;
            this.Status = "Logged server errors.";
            this.Text = "Server Errors";
            this.Load += new System.EventHandler(this.ViewDeviceErrorsForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewDeviceErrorsForm_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewDeviceErrorsForm_MouseDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ViewDeviceErrorsForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewDeviceErrorsForm_MouseMove);
            this.Controls.SetChildIndex(this.lblFormTitle, 0);
            this.Controls.SetChildIndex(this.statusMain, 0);
            this.Controls.SetChildIndex(this.pnlFormLeft, 0);
            this.Controls.SetChildIndex(this.pnlFormRight, 0);
            this.Controls.SetChildIndex(this.pnlFormContent, 0);
            this.Controls.SetChildIndex(this.mnuMain, 0);
            this.Controls.SetChildIndex(this.pnlServerErrors, 0);
            this.Controls.SetChildIndex(this.picResizeWindow, 0);
            this.Controls.SetChildIndex(this.picMaximize, 0);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlServerErrors.ResumeLayout(false);
            this.pnlServerErrors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServerErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Figlut.Desktop.Controls.CustomMainMenu mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuCancel;
        private Figlut.Desktop.Controls.GradientPanel pnlServerErrors;
        private Figlut.Desktop.Controls.CustomDataGridView grdServerErrors;
        private System.Windows.Forms.TextBox txtErrorMessage;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.PictureBox picResizeWindow;
        private System.Windows.Forms.PictureBox picMaximize;
    }
}