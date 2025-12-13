namespace UAS_PBO
{
    partial class AddMemberForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblDurasi;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.NumericUpDown numDurasi;
        private System.Windows.Forms.ComboBox cboMembership;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblNama = new Label();
            lblDurasi = new Label();
            lblMembership = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtNama = new TextBox();
            numDurasi = new NumericUpDown();
            cboMembership = new ComboBox();
            btnAdd = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numDurasi).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(100, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TAMBAH MEMBER BARU";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(50, 70);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(120, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(50, 110);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(120, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // lblNama
            // 
            lblNama.Location = new Point(50, 150);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(120, 20);
            lblNama.TabIndex = 5;
            lblNama.Text = "Nama Lengkap:";
            // 
            // lblDurasi
            // 
            lblDurasi.Location = new Point(50, 190);
            lblDurasi.Name = "lblDurasi";
            lblDurasi.Size = new Size(120, 20);
            lblDurasi.TabIndex = 7;
            lblDurasi.Text = "Durasi (bulan):";
            // 
            // lblMembership
            // 
            lblMembership.Location = new Point(50, 230);
            lblMembership.Name = "lblMembership";
            lblMembership.Size = new Size(140, 20);
            lblMembership.TabIndex = 9;
            lblMembership.Text = "Tipe Membership:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(200, 70);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(200, 110);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(200, 150);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(200, 27);
            txtNama.TabIndex = 6;
            // 
            // numDurasi
            // 
            numDurasi.Location = new Point(200, 190);
            numDurasi.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numDurasi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDurasi.Name = "numDurasi";
            numDurasi.Size = new Size(200, 27);
            numDurasi.TabIndex = 8;
            numDurasi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboMembership
            // 
            cboMembership.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMembership.Items.AddRange(new object[] { "Gold (6 bulan)", "Silver (3 bulan)", "Bronze (1 bulan)" });
            cboMembership.Location = new Point(200, 230);
            cboMembership.Name = "cboMembership";
            cboMembership.Size = new Size(200, 28);
            cboMembership.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(100, 310);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Tambah";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(220, 310);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Batal";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddMemberForm
            // 
            ClientSize = new Size(450, 450);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblNama);
            Controls.Add(txtNama);
            Controls.Add(lblDurasi);
            Controls.Add(numDurasi);
            Controls.Add(lblMembership);
            Controls.Add(cboMembership);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddMemberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tambah Member Baru";
            ((System.ComponentModel.ISupportInitialize)numDurasi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
