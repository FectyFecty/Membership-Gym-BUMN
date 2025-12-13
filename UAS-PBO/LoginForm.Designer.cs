namespace UAS_PBO
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(150, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LOGIN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(50, 70);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(50, 110);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(150, 70);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(180, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 110);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(180, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(100, 170);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(210, 170);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            ClientSize = new Size(400, 300);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
