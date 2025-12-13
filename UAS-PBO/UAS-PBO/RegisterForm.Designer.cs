namespace UAS_PBO
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cboMembership;
        private System.Windows.Forms.Button btnRegister;
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
            this.lblMembership = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cboMembership = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DAFTAR MEMBER BARU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(50, 70);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(180, 70);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(50, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(180, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.PasswordChar = '*';
            // 
            // lblNama
            // 
            this.lblNama.Location = new System.Drawing.Point(50, 150);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(100, 20);
            this.lblNama.TabIndex = 5;
            this.lblNama.Text = "Nama Lengkap:";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(180, 150);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 20);
            this.txtNama.TabIndex = 6;
            // 
            // lblMembership
            // 
            this.lblMembership.Location = new System.Drawing.Point(50, 190);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(120, 20);
            this.lblMembership.TabIndex = 7;
            this.lblMembership.Text = "Tipe Membership:";
            // 
            // cboMembership
            // 
            this.cboMembership.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMembership.Items.AddRange(new object[] { "Gold (6 Bulan)", "Silver (3 Bulan)", "Bronze (1 Bulan)" });
            this.cboMembership.Location = new System.Drawing.Point(180, 190);
            this.cboMembership.Name = "cboMembership";
            this.cboMembership.Size = new System.Drawing.Size(200, 20);
            this.cboMembership.TabIndex = 8;
            this.cboMembership.SelectedIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(100, 270);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 40);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Daftar";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Batal";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblMembership);
            this.Controls.Add(this.cboMembership);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "RegisterForm";
            this.Text = "Daftar Member Baru";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
