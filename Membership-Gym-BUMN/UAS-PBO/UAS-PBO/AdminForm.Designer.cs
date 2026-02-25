namespace UAS_PBO
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnToggleStatus;
        private System.Windows.Forms.Button btnFilterType;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvMembers = new DataGridView();
            panelButtons = new Panel();
            btnAdd = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnToggleStatus = new Button();
            btnFilterType = new Button();
            btnTotal = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(312, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "=== ADMIN MENU ===";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.ColumnHeadersHeight = 29;
            dgvMembers.Location = new Point(12, 60);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(840, 350);
            dgvMembers.TabIndex = 1;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(btnRefresh);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnToggleStatus);
            panelButtons.Controls.Add(btnFilterType);
            panelButtons.Controls.Add(btnTotal);
            panelButtons.Controls.Add(btnLogout);
            panelButtons.Location = new Point(12, 420);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(840, 120);
            panelButtons.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 40);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Tambah Member";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(182, 10);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 40);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh Data";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(352, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Hapus Member";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnToggleStatus
            // 
            btnToggleStatus.Location = new Point(520, 10);
            btnToggleStatus.Name = "btnToggleStatus";
            btnToggleStatus.Size = new Size(140, 40);
            btnToggleStatus.TabIndex = 3;
            btnToggleStatus.Text = "Ubah Status";
            btnToggleStatus.UseVisualStyleBackColor = true;
            // 
            // btnFilterType
            // 
            btnFilterType.Location = new Point(686, 10);
            btnFilterType.Name = "btnFilterType";
            btnFilterType.Size = new Size(140, 40);
            btnFilterType.TabIndex = 4;
            btnFilterType.Text = "Filter by Type";
            btnFilterType.UseVisualStyleBackColor = true;
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(10, 60);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(140, 40);
            btnTotal.TabIndex = 5;
            btnTotal.Text = "Total Member";
            btnTotal.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Location = new Point(686, 60);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(140, 40);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            ClientSize = new Size(862, 600);
            Controls.Add(lblTitle);
            Controls.Add(dgvMembers);
            Controls.Add(panelButtons);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Menu";
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
