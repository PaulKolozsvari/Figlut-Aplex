namespace Figlut.Aplex.Desktop.AuxilaryUI
{
    partial class ViewEmailActionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmailActionsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuMain = new Figlut.Desktop.Controls.CustomMainMenu();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlEmailActions = new Figlut.Desktop.Controls.GradientPanel();
            this.grdEmailActions = new Figlut.Desktop.Controls.CustomDataGridView();
            this.txtToEmailAddress = new System.Windows.Forms.TextBox();
            this.lblToEmailAddress = new System.Windows.Forms.Label();
            this.picResizeWindow = new System.Windows.Forms.PictureBox();
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.mnuMain.SuspendLayout();
            this.pnlEmailActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmailActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(575, 21);
            this.lblFormTitle.Text = "Emails Actions ";
            this.lblFormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewEmailActionsForm_MouseMove);
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewEmailActionsForm_MouseDown);
            this.lblFormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewEmailActionsForm_MouseUp);
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 383);
            this.statusMain.Size = new System.Drawing.Size(575, 21);
            this.statusMain.Text = "Logged emails.";
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
            this.mnuMain.TabIndex = 162;
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
            this.mnuRefresh.Click += new System.EventHandler(this.ViewEmailActionsForm_Load);
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
            // pnlEmailActions
            // 
            this.pnlEmailActions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEmailActions.BackgroundImage")));
            this.pnlEmailActions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEmailActions.Controls.Add(this.grdEmailActions);
            this.pnlEmailActions.Controls.Add(this.txtToEmailAddress);
            this.pnlEmailActions.Controls.Add(this.lblToEmailAddress);
            this.pnlEmailActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmailActions.GradientEndColor = System.Drawing.Color.DimGray;
            this.pnlEmailActions.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlEmailActions.GradientStartColor = System.Drawing.Color.DarkGray;
            this.pnlEmailActions.Location = new System.Drawing.Point(15, 45);
            this.pnlEmailActions.Name = "pnlEmailActions";
            this.pnlEmailActions.Size = new System.Drawing.Size(545, 338);
            this.pnlEmailActions.TabIndex = 163;
            // 
            // grdEmailActions
            // 
            this.grdEmailActions.AllowUserToAddRows = false;
            this.grdEmailActions.AllowUserToDeleteRows = false;
            this.grdEmailActions.AllowUserToResizeRows = false;
            this.grdEmailActions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.grdEmailActions.BackgroundEndColor = System.Drawing.Color.LightGray;
            this.grdEmailActions.BackgroundStartColor = System.Drawing.Color.WhiteSmoke;
            this.grdEmailActions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdEmailActions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEmailActions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEmailActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEmailActions.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdEmailActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEmailActions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdEmailActions.EnableHeadersVisualStyles = false;
            this.grdEmailActions.GridColor = System.Drawing.Color.DimGray;
            this.grdEmailActions.Location = new System.Drawing.Point(0, 33);
            this.grdEmailActions.MultiSelect = false;
            this.grdEmailActions.Name = "grdEmailActions";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEmailActions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdEmailActions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmailActions.Size = new System.Drawing.Size(545, 305);
            this.grdEmailActions.TabIndex = 266;
            // 
            // txtToEmailAddress
            // 
            this.txtToEmailAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtToEmailAddress.Location = new System.Drawing.Point(0, 13);
            this.txtToEmailAddress.Name = "txtToEmailAddress";
            this.txtToEmailAddress.Size = new System.Drawing.Size(545, 20);
            this.txtToEmailAddress.TabIndex = 121;
            this.txtToEmailAddress.TextChanged += new System.EventHandler(this.txtToEmailAddress_TextChanged);
            // 
            // lblToEmailAddress
            // 
            this.lblToEmailAddress.AutoSize = true;
            this.lblToEmailAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblToEmailAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblToEmailAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblToEmailAddress.Location = new System.Drawing.Point(0, 0);
            this.lblToEmailAddress.Name = "lblToEmailAddress";
            this.lblToEmailAddress.Size = new System.Drawing.Size(92, 13);
            this.lblToEmailAddress.TabIndex = 122;
            this.lblToEmailAddress.Text = "To Email Address:";
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
            this.picResizeWindow.TabIndex = 271;
            this.picResizeWindow.TabStop = false;
            this.picResizeWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picResizeWindow_MouseMove);
            // 
            // picMaximize
            // 
            this.picMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaximize.BackColor = System.Drawing.Color.DarkGray;
            this.picMaximize.Image = ((System.Drawing.Image)(resources.GetObject("picMaximize.Image")));
            this.picMaximize.Location = new System.Drawing.Point(462, 5);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(16, 16);
            this.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMaximize.TabIndex = 272;
            this.picMaximize.TabStop = false;
            this.picMaximize.Click += new System.EventHandler(this.picMaximize_Click);
            // 
            // ViewEmailActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 404);
            this.Controls.Add(this.picMaximize);
            this.Controls.Add(this.picResizeWindow);
            this.Controls.Add(this.pnlEmailActions);
            this.Controls.Add(this.mnuMain);
            this.FormTitle = "Emails Actions";
            this.KeyPreview = true;
            this.Name = "ViewEmailActionsForm";
            this.ShowInTaskbar = false;
            this.Status = "Logged emails.";
            this.Text = "ViewEmailActionsForm";
            this.Load += new System.EventHandler(this.ViewEmailActionsForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewEmailActionsForm_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewEmailActionsForm_MouseDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ViewEmailActionsForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewEmailActionsForm_MouseMove);
            this.Controls.SetChildIndex(this.lblFormTitle, 0);
            this.Controls.SetChildIndex(this.statusMain, 0);
            this.Controls.SetChildIndex(this.pnlFormLeft, 0);
            this.Controls.SetChildIndex(this.pnlFormRight, 0);
            this.Controls.SetChildIndex(this.pnlFormContent, 0);
            this.Controls.SetChildIndex(this.mnuMain, 0);
            this.Controls.SetChildIndex(this.pnlEmailActions, 0);
            this.Controls.SetChildIndex(this.picResizeWindow, 0);
            this.Controls.SetChildIndex(this.picMaximize, 0);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlEmailActions.ResumeLayout(false);
            this.pnlEmailActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmailActions)).EndInit();
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
        private Figlut.Desktop.Controls.GradientPanel pnlEmailActions;
        private Figlut.Desktop.Controls.CustomDataGridView grdEmailActions;
        private System.Windows.Forms.TextBox txtToEmailAddress;
        private System.Windows.Forms.Label lblToEmailAddress;
        private System.Windows.Forms.PictureBox picResizeWindow;
        private System.Windows.Forms.PictureBox picMaximize;
    }
}