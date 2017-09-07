namespace Figlut.Aplex.Desktop.AuxilaryUI
{
    partial class ManageDevicesPendingApprovalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDevicesPendingApprovalForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuMain = new Figlut.Desktop.Controls.CustomMainMenu();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditApprove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCustomers = new Figlut.Desktop.Controls.GradientPanel();
            this.grdDevicesPendingApproval = new Figlut.Desktop.Controls.CustomDataGridView();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.pnlFormContent.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.pnlCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDevicesPendingApproval)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(575, 21);
            this.lblFormTitle.Text = "Manage Devices Pending Approval ";
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 383);
            this.statusMain.Size = new System.Drawing.Size(575, 21);
            this.statusMain.Text = "Approve, update or delete devices pending approvals.";
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Controls.Add(this.pnlCustomers);
            this.pnlFormContent.Controls.Add(this.mnuMain);
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
            this.mnuFile,
            this.mnuEdit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
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
            this.mnuSave,
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
            this.mnuRefresh.Click += new System.EventHandler(this.ManageDevicesPendingApprovalForm_Load);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(154, 22);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
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
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditApprove,
            this.mnuEditDelete});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuEditApprove
            // 
            this.mnuEditApprove.Name = "mnuEditApprove";
            this.mnuEditApprove.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuEditApprove.Size = new System.Drawing.Size(161, 22);
            this.mnuEditApprove.Text = "Approve";
            this.mnuEditApprove.Click += new System.EventHandler(this.mnuEditApprove_Click);
            // 
            // mnuEditDelete
            // 
            this.mnuEditDelete.Name = "mnuEditDelete";
            this.mnuEditDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuEditDelete.Size = new System.Drawing.Size(149, 22);
            this.mnuEditDelete.Text = "&Delete";
            this.mnuEditDelete.Click += new System.EventHandler(this.mnuEditDelete_Click);
            // 
            // pnlCustomers
            // 
            this.pnlCustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCustomers.BackgroundImage")));
            this.pnlCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCustomers.Controls.Add(this.grdDevicesPendingApproval);
            this.pnlCustomers.Controls.Add(this.txtDeviceId);
            this.pnlCustomers.Controls.Add(this.lblDeviceId);
            this.pnlCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomers.GradientEndColor = System.Drawing.Color.DimGray;
            this.pnlCustomers.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlCustomers.GradientStartColor = System.Drawing.Color.DarkGray;
            this.pnlCustomers.Location = new System.Drawing.Point(0, 24);
            this.pnlCustomers.Name = "pnlCustomers";
            this.pnlCustomers.Size = new System.Drawing.Size(545, 338);
            this.pnlCustomers.TabIndex = 161;
            // 
            // grdDevicesPendingApproval
            // 
            this.grdDevicesPendingApproval.AllowUserToAddRows = false;
            this.grdDevicesPendingApproval.AllowUserToDeleteRows = false;
            this.grdDevicesPendingApproval.AllowUserToResizeRows = false;
            this.grdDevicesPendingApproval.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.grdDevicesPendingApproval.BackgroundEndColor = System.Drawing.Color.LightGray;
            this.grdDevicesPendingApproval.BackgroundStartColor = System.Drawing.Color.WhiteSmoke;
            this.grdDevicesPendingApproval.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdDevicesPendingApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDevicesPendingApproval.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdDevicesPendingApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDevicesPendingApproval.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdDevicesPendingApproval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDevicesPendingApproval.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdDevicesPendingApproval.EnableHeadersVisualStyles = false;
            this.grdDevicesPendingApproval.GridColor = System.Drawing.Color.DimGray;
            this.grdDevicesPendingApproval.Location = new System.Drawing.Point(0, 33);
            this.grdDevicesPendingApproval.MultiSelect = false;
            this.grdDevicesPendingApproval.Name = "grdDevicesPendingApproval";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDevicesPendingApproval.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grdDevicesPendingApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDevicesPendingApproval.Size = new System.Drawing.Size(545, 305);
            this.grdDevicesPendingApproval.TabIndex = 266;
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
            // ManageDevicesPendingApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 404);
            this.FormTitle = "Manage Devices Pending Approval";
            this.KeyPreview = true;
            this.Name = "ManageDevicesPendingApprovalForm";
            this.ShowInTaskbar = false;
            this.Status = "Approve, update or delete devices pending approvals.";
            this.Text = "Manage Devices Pending ApprovalForm";
            this.Load += new System.EventHandler(this.ManageDevicesPendingApprovalForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ManageDevicesPendingApprovalForm_KeyUp);
            this.pnlFormContent.ResumeLayout(false);
            this.pnlFormContent.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlCustomers.ResumeLayout(false);
            this.pnlCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDevicesPendingApproval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Figlut.Desktop.Controls.CustomMainMenu mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuCancel;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDelete;
        private Figlut.Desktop.Controls.GradientPanel pnlCustomers;
        private Figlut.Desktop.Controls.CustomDataGridView grdDevicesPendingApproval;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.ToolStripMenuItem mnuEditApprove;
    }
}