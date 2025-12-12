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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblDurasi = new System.Windows.Forms.Label();
            this.lblMembership = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.numDurasi = new System.Windows.Forms.NumericUpDown();
            this.cboMembership = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDurasi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TAMBAH MEMBER BARU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(50, 70);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(120, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(200, 70);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(50, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(200, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.PasswordChar = '*';
            // 
            // lblNama
            // 
            this.lblNama.Location = new System.Drawing.Point(50, 150);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(120, 20);
            this.lblNama.TabIndex = 5;
            this.lblNama.Text = "Nama Lengkap:";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(200, 150);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 20);
            this.txtNama.TabIndex = 6;
            // 
            // lblDurasi
            // 
            this.lblDurasi.Location = new System.Drawing.Point(50, 190);
            this.lblDurasi.Name = "lblDurasi";
            this.lblDurasi.Size = new System.Drawing.Size(120, 20);
            this.lblDurasi.TabIndex = 7;
            this.lblDurasi.Text = "Durasi (bulan):";
            // 
            // numDurasi
            // 
            this.numDurasi.Location = new System.Drawing.Point(200, 190);
            this.numDurasi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numDurasi.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            this.numDurasi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numDurasi.Name = "numDurasi";
            this.numDurasi.Size = new System.Drawing.Size(200, 20);
            this.numDurasi.TabIndex = 8;
            // 
            // lblMembership
            // 
            this.lblMembership.Location = new System.Drawing.Point(50, 230);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(140, 20);
            this.lblMembership.TabIndex = 9;
            this.lblMembership.Text = "Tipe Membership:";
            // 
            // cboMembership
            // 
            this.cboMembership.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMembership.Items.AddRange(new object[] { "Gold", "Silver", "Bronze" });
            this.cboMembership.Location = new System.Drawing.Point(200, 230);
            this.cboMembership.Name = "cboMembership";
            this.cboMembership.Size = new System.Drawing.Size(200, 20);
            this.cboMembership.TabIndex = 10;
            this.cboMembership.SelectedIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Tambah";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Batal";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddMemberForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblDurasi);
            this.Controls.Add(this.numDurasi);
            this.Controls.Add(this.lblMembership);
            this.Controls.Add(this.cboMembership);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "AddMemberForm";
            this.Text = "Tambah Member Baru";
            ((System.ComponentModel.ISupportInitialize)(this.numDurasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
