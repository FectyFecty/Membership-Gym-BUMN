namespace UAS_PBO
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Label lblProfileTitle;
        private System.Windows.Forms.Label lblProfileInfo;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnViewBenefit;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.lblProfileTitle = new System.Windows.Forms.Label();
            this.lblProfileInfo = new System.Windows.Forms.Label();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnViewBenefit = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Selamat Datang, [Nama]";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProfile
            // 
            this.panelProfile.Location = new System.Drawing.Point(50, 70);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(500, 200);
            this.panelProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblProfileTitle
            // 
            this.lblProfileTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblProfileTitle.Location = new System.Drawing.Point(10, 10);
            this.lblProfileTitle.Size = new System.Drawing.Size(200, 20);
            this.lblProfileTitle.Text = "=== Profil Anda ===";
            // 
            // lblProfileInfo
            // 
            this.lblProfileInfo.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblProfileInfo.Location = new System.Drawing.Point(20, 40);
            this.lblProfileInfo.Size = new System.Drawing.Size(460, 150);
            // 
            // panelProfile Controls
            // 
            this.panelProfile.Controls.Add(this.lblProfileTitle);
            this.panelProfile.Controls.Add(this.lblProfileInfo);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(50, 290);
            this.btnViewProfile.Size = new System.Drawing.Size(200, 40);
            this.btnViewProfile.Text = "Refresh Profil";
            // 
            // btnViewBenefit
            // 
            this.btnViewBenefit.Location = new System.Drawing.Point(270, 290);
            this.btnViewBenefit.Size = new System.Drawing.Size(200, 40);
            this.btnViewBenefit.Text = "Lihat Benefit";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(50, 350);
            this.btnChangePassword.Size = new System.Drawing.Size(200, 40);
            this.btnChangePassword.Text = "Ubah Password";
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Location = new System.Drawing.Point(270, 350);
            this.btnUpgrade.Size = new System.Drawing.Size(200, 40);
            this.btnUpgrade.Text = "Upgrade/Ganti Membership";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(480, 290);
            this.btnLogout.Size = new System.Drawing.Size(70, 40);
            this.btnLogout.Text = "Logout";
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            // 
            // UserForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.btnViewBenefit);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "UserForm";
            this.Text = "User Menu";
            this.panelProfile.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
