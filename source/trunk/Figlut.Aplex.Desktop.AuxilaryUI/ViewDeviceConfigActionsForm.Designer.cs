namespace Figlut.Aplex.Desktop.AuxilaryUI
{
    partial class ViewDeviceConfigActionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDeviceConfigActionsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuMain = new Figlut.Desktop.Controls.CustomMainMenu();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDeviceConfigActions = new Figlut.Desktop.Controls.GradientPanel();
            this.grdDeviceConfigActions = new Figlut.Desktop.Controls.CustomDataGridView();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.picResizeWindow = new System.Windows.Forms.PictureBox();
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.mnuMain.SuspendLayout();
            this.pnlDeviceConfigActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeviceConfigActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(575, 21);
            this.lblFormTitle.Text = "Device Actions ";
            this.lblFormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewDeviceConfigActionsForm_MouseMove);
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewDeviceConfigActionsForm_MouseDown);
            this.lblFormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewDeviceConfigActionsForm_MouseUp);
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 383);
            this.statusMain.Size = new System.Drawing.Size(575, 21);
            this.statusMain.Text = "Logged server actions.";
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
            this.mnuMain.TabIndex = 160;
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
            this.mnuRefresh.Click += new System.EventHandler(this.ViewDeviceConfigActionsForm_Load);
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
            // pnlDeviceConfigActions
            // 
            this.pnlDeviceConfigActions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDeviceConfigActions.BackgroundImage")));
            this.pnlDeviceConfigActions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDeviceConfigActions.Controls.Add(this.grdDeviceConfigActions);
            this.pnlDeviceConfigActions.Controls.Add(this.txtDeviceId);
            this.pnlDeviceConfigActions.Controls.Add(this.lblDeviceId);
            this.pnlDeviceConfigActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeviceConfigActions.GradientEndColor = System.Drawing.Color.DimGray;
            this.pnlDeviceConfigActions.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlDeviceConfigActions.GradientStartColor = System.Drawing.Color.DarkGray;
            this.pnlDeviceConfigActions.Location = new System.Drawing.Point(15, 45);
            this.pnlDeviceConfigActions.Name = "pnlDeviceConfigActions";
            this.pnlDeviceConfigActions.Size = new System.Drawing.Size(545, 338);
            this.pnlDeviceConfigActions.TabIndex = 161;
            // 
            // grdDeviceConfigActions
            // 
            this.grdDeviceConfigActions.AllowUserToAddRows = false;
            this.grdDeviceConfigActions.AllowUserToDeleteRows = false;
            this.grdDeviceConfigActions.AllowUserToResizeRows = false;
            this.grdDeviceConfigActions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.grdDeviceConfigActions.BackgroundEndColor = System.Drawing.Color.LightGray;
            this.grdDeviceConfigActions.BackgroundStartColor = System.Drawing.Color.WhiteSmoke;
            this.grdDeviceConfigActions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdDeviceConfigActions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDeviceConfigActions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.grdDeviceConfigActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDeviceConfigActions.DefaultCellStyle = dataGridViewCellStyle20;
            this.grdDeviceConfigActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDeviceConfigActions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdDeviceConfigActions.EnableHeadersVisualStyles = false;
            this.grdDeviceConfigActions.GridColor = System.Drawing.Color.DimGray;
            this.grdDeviceConfigActions.Location = new System.Drawing.Point(0, 33);
            this.grdDeviceConfigActions.MultiSelect = false;
            this.grdDeviceConfigActions.Name = "grdDeviceConfigActions";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDeviceConfigActions.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.grdDeviceConfigActions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDeviceConfigActions.Size = new System.Drawing.Size(545, 305);
            this.grdDeviceConfigActions.TabIndex = 266;
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDeviceId.Location = new System.Drawing.Point(0, 13);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(545, 20);
            this.txtDeviceId.TabIndex = 121;
            this.txtDeviceId.TextChanged += new System.EventHandler(this.txtDeviceId_TextChanged);
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.BackColor = System.Drawing.Color.Transparent;
            this.lblDeviceId.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeviceId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDeviceId.Location = new System.Drawing.Point(0, 0);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(56, 13);
            this.lblDeviceId.TabIndex = 122;
            this.lblDeviceId.Text = "Device Id:";
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
            this.picResizeWindow.TabIndex = 269;
            this.picResizeWindow.TabStop = false;
            this.picResizeWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picResizeWindow_MouseMove);
            // 
            // picMaximize
            // 
            this.picMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaximize.BackColor = System.Drawing.Color.DarkGray;
            this.picMaximize.Image = ((System.Drawing.Image)(resources.GetObject("picMaximize.Image")));
            this.picMaximize.Location = new System.Drawing.Point(458, 5);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(16, 16);
            this.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMaximize.TabIndex = 270;
            this.picMaximize.TabStop = false;
            this.picMaximize.Click += new System.EventHandler(this.picMaximize_Click);
            // 
            // ViewDeviceConfigActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 404);
            this.Controls.Add(this.picMaximize);
            this.Controls.Add(this.picResizeWindow);
            this.Controls.Add(this.pnlDeviceConfigActions);
            this.Controls.Add(this.mnuMain);
            this.FormTitle = "Device Actions";
            this.KeyPreview = true;
            this.Name = "ViewDeviceConfigActionsForm";
            this.ShowInTaskbar = false;
            this.Status = "Logged server actions.";
            this.Text = "Device Actions";
            this.Load += new System.EventHandler(this.ViewDeviceConfigActionsForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewDeviceConfigActionsForm_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewDeviceConfigActionsForm_MouseDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ViewDeviceConfigActionsForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewDeviceConfigActionsForm_MouseMove);
            this.Controls.SetChildIndex(this.lblFormTitle, 0);
            this.Controls.SetChildIndex(this.statusMain, 0);
            this.Controls.SetChildIndex(this.pnlFormLeft, 0);
            this.Controls.SetChildIndex(this.pnlFormRight, 0);
            this.Controls.SetChildIndex(this.pnlFormContent, 0);
            this.Controls.SetChildIndex(this.mnuMain, 0);
            this.Controls.SetChildIndex(this.pnlDeviceConfigActions, 0);
            this.Controls.SetChildIndex(this.picResizeWindow, 0);
            this.Controls.SetChildIndex(this.picMaximize, 0);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlDeviceConfigActions.ResumeLayout(false);
            this.pnlDeviceConfigActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeviceConfigActions)).EndInit();
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
        private Figlut.Desktop.Controls.GradientPanel pnlDeviceConfigActions;
        private Figlut.Desktop.Controls.CustomDataGridView grdDeviceConfigActions;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.PictureBox picResizeWindow;
        private System.Windows.Forms.PictureBox picMaximize;

    }
}