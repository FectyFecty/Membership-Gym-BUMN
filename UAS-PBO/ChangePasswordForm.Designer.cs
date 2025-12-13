namespace UAS_PBO
{
    partial class ChangePasswordForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblOld;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblOld = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOld
            // 
            this.lblOld.Location = new System.Drawing.Point(30, 30);
            this.lblOld.Size = new System.Drawing.Size(120, 20);
            this.lblOld.Text = "Password Lama:";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(160, 30);
            this.txtOldPassword.Size = new System.Drawing.Size(180, 20);
            this.txtOldPassword.PasswordChar = '*';
            // 
            // lblNew
            // 
            this.lblNew.Location = new System.Drawing.Point(30, 70);
            this.lblNew.Size = new System.Drawing.Size(120, 20);
            this.lblNew.Text = "Password Baru:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(160, 70);
            this.txtNewPassword.Size = new System.Drawing.Size(180, 20);
            this.txtNewPassword.PasswordChar = '*';
            // 
            // lblConfirm
            // 
            this.lblConfirm.Location = new System.Drawing.Point(30, 110);
            this.lblConfirm.Size = new System.Drawing.Size(120, 20);
            this.lblConfirm.Text = "Konfirmasi Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(160, 110);
            this.txtConfirmPassword.Size = new System.Drawing.Size(180, 20);
            this.txtConfirmPassword.PasswordChar = '*';
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 170);
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.Text = "Simpan";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 170);
            this.btnCancel.Size = new System.Drawing.Size(90, 35);
            this.btnCancel.Text = "Batal";
            // 
            // ChangePasswordForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.lblOld);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "ChangePasswordForm";
            this.Text = "Ubah Password";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
