namespace Figlut.Aplex.Desktop.AuxilaryUI
{
    partial class LogViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogViewerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customMainMenu1 = new Figlut.Desktop.Controls.CustomMainMenu();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLogViewer = new Figlut.Desktop.Controls.GradientPanel();
            this.picResizeWindow = new System.Windows.Forms.PictureBox();
            this.grdLogViewer = new Figlut.Desktop.Controls.CustomDataGridView();
            this.txtExceptionName = new System.Windows.Forms.TextBox();
            this.lblExceptionName = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlFormContent.SuspendLayout();
            this.customMainMenu1.SuspendLayout();
            this.pnlLogViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLogViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(905, 21);
            this.lblFormTitle.Text = "Log Viewer ";
            this.lblFormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogViewerForm_MouseMove);
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogViewerForm_MouseDown);
            this.lblFormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LogViewerForm_MouseUp);
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 556);
            this.statusMain.Size = new System.Drawing.Size(905, 21);
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Controls.Add(this.pnlLogViewer);
            this.pnlFormContent.Controls.Add(this.customMainMenu1);
            this.pnlFormContent.Size = new System.Drawing.Size(875, 535);
            // 
            // pnlFormLeft
            // 
            this.pnlFormLeft.Size = new System.Drawing.Size(15, 535);
            // 
            // pnlFormRight
            // 
            this.pnlFormRight.Location = new System.Drawing.Point(890, 21);
            this.pnlFormRight.Size = new System.Drawing.Size(15, 535);
            // 
            // customMainMenu1
            // 
            this.customMainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCancel});
            this.customMainMenu1.Location = new System.Drawing.Point(0, 0);
            this.customMainMenu1.Name = "customMainMenu1";
            this.customMainMenu1.Size = new System.Drawing.Size(875, 24);
            this.customMainMenu1.TabIndex = 0;
            this.customMainMenu1.Text = "customMainMenu1";
            // 
            // mnuCancel
            // 
            this.mnuCancel.Name = "mnuCancel";
            this.mnuCancel.Size = new System.Drawing.Size(55, 20);
            this.mnuCancel.Text = "&Cancel";
            this.mnuCancel.Click += new System.EventHandler(this.mnuCancel_Click);
            // 
            // pnlLogViewer
            // 
            this.pnlLogViewer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogViewer.BackgroundImage")));
            this.pnlLogViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogViewer.Controls.Add(this.picResizeWindow);
            this.pnlLogViewer.Controls.Add(this.grdLogViewer);
            this.pnlLogViewer.Controls.Add(this.txtExceptionName);
            this.pnlLogViewer.Controls.Add(this.lblExceptionName);
            this.pnlLogViewer.Controls.Add(this.txtMessage);
            this.pnlLogViewer.Controls.Add(this.lblMessage);
            this.pnlLogViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogViewer.GradientEndColor = System.Drawing.Color.DimGray;
            this.pnlLogViewer.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlLogViewer.GradientStartColor = System.Drawing.Color.DarkGray;
            this.pnlLogViewer.Location = new System.Drawing.Point(0, 24);
            this.pnlLogViewer.Name = "pnlLogViewer";
            this.pnlLogViewer.Size = new System.Drawing.Size(875, 511);
            this.pnlLogViewer.TabIndex = 1;
            // 
            // picResizeWindow
            // 
            this.picResizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picResizeWindow.BackColor = System.Drawing.Color.LightGray;
            this.picResizeWindow.ErrorImage = null;
            this.picResizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("picResizeWindow.Image")));
            this.picResizeWindow.Location = new System.Drawing.Point(859, 496);
            this.picResizeWindow.Name = "picResizeWindow";
            this.picResizeWindow.Size = new System.Drawing.Size(16, 15);
            this.picResizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResizeWindow.TabIndex = 35;
            this.picResizeWindow.TabStop = false;
            this.picResizeWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picResizeWindow_MouseMove);
            // 
            // grdLogViewer
            // 
            this.grdLogViewer.AllowUserToAddRows = false;
            this.grdLogViewer.AllowUserToDeleteRows = false;
            this.grdLogViewer.AllowUserToResizeRows = false;
            this.grdLogViewer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.grdLogViewer.BackgroundEndColor = System.Drawing.Color.LightGray;
            this.grdLogViewer.BackgroundStartColor = System.Drawing.Color.WhiteSmoke;
            this.grdLogViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdLogViewer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLogViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdLogViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdLogViewer.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdLogViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLogViewer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdLogViewer.EnableHeadersVisualStyles = false;
            this.grdLogViewer.GridColor = System.Drawing.Color.DimGray;
            this.grdLogViewer.Location = new System.Drawing.Point(0, 66);
            this.grdLogViewer.MultiSelect = false;
            this.grdLogViewer.Name = "grdLogViewer";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLogViewer.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grdLogViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLogViewer.Size = new System.Drawing.Size(875, 445);
            this.grdLogViewer.TabIndex = 266;
            this.grdLogViewer.SelectionChanged += new System.EventHandler(this.grdLogViewer_SelectionChanged);
            // 
            // txtExceptionName
            // 
            this.txtExceptionName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtExceptionName.Location = new System.Drawing.Point(0, 46);
            this.txtExceptionName.Name = "txtExceptionName";
            this.txtExceptionName.Size = new System.Drawing.Size(875, 20);
            this.txtExceptionName.TabIndex = 123;
            this.txtExceptionName.TextChanged += new System.EventHandler(this.FilterTextChanged);
            // 
            // lblExceptionName
            // 
            this.lblExceptionName.AutoSize = true;
            this.lblExceptionName.BackColor = System.Drawing.Color.Transparent;
            this.lblExceptionName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExceptionName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblExceptionName.Location = new System.Drawing.Point(0, 33);
            this.lblExceptionName.Name = "lblExceptionName";
            this.lblExceptionName.Size = new System.Drawing.Size(88, 13);
            this.lblExceptionName.TabIndex = 124;
            this.lblExceptionName.Text = "Exception Name:";
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMessage.Location = new System.Drawing.Point(0, 13);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(875, 20);
            this.txtMessage.TabIndex = 121;
            this.txtMessage.TextChanged += new System.EventHandler(this.FilterTextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 122;
            this.lblMessage.Text = "Message:";
            // 
            // LogViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(905, 577);
            this.FormTitle = "Log Viewer";
            this.KeyPreview = true;
            this.MainMenuStrip = this.customMainMenu1;
            this.Name = "LogViewerForm";
            this.ShowInTaskbar = false;
            this.Text = "LogViewerForm";
            this.Load += new System.EventHandler(this.LogViewerForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LogViewerForm_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogViewerForm_MouseDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LogViewerForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogViewerForm_MouseMove);
            this.pnlFormContent.ResumeLayout(false);
            this.pnlFormContent.PerformLayout();
            this.customMainMenu1.ResumeLayout(false);
            this.customMainMenu1.PerformLayout();
            this.pnlLogViewer.ResumeLayout(false);
            this.pnlLogViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLogViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Figlut.Desktop.Controls.GradientPanel pnlLogViewer;
        private Figlut.Desktop.Controls.CustomMainMenu customMainMenu1;
        private System.Windows.Forms.ToolStripMenuItem mnuCancel;
        private System.Windows.Forms.PictureBox picResizeWindow;
        private Figlut.Desktop.Controls.CustomDataGridView grdLogViewer;
        private System.Windows.Forms.TextBox txtExceptionName;
        private System.Windows.Forms.Label lblExceptionName;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;

    }
}