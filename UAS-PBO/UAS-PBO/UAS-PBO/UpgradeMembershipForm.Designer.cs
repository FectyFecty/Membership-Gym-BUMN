namespace UAS_PBO
{
    partial class UpgradeMembershipForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.ComboBox cboMembership;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblCurrent = new Label();
            lblNew = new Label();
            cboMembership = new ComboBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblCurrent
            // 
            lblCurrent.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblCurrent.Location = new Point(50, 30);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(350, 25);
            lblCurrent.TabIndex = 0;
            lblCurrent.Text = "Membership Saat Ini: [Nama]";
            // 
            // lblNew
            // 
            lblNew.Location = new Point(50, 80);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(150, 20);
            lblNew.TabIndex = 1;
            lblNew.Text = "Pilih Membership Baru:";
            // 
            // cboMembership
            // 
            cboMembership.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMembership.Items.AddRange(new object[] { "Gold (Rp 249.999 - 6 bulan)", "Silver (Rp 129.999 - 3 bulan)", "Bronze (Rp 49.999 - 1 bulan)" });
            cboMembership.Location = new Point(50, 110);
            cboMembership.Name = "cboMembership";
            cboMembership.Size = new Size(340, 28);
            cboMembership.TabIndex = 2;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(80, 180);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(140, 40);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Konfirmasi";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(230, 180);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 40);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Batal";
            // 
            // UpgradeMembershipForm
            // 
            ClientSize = new Size(450, 300);
            Controls.Add(lblCurrent);
            Controls.Add(lblNew);
            Controls.Add(cboMembership);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "UpgradeMembershipForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Upgrade Membership";
            ResumeLayout(false);
        }

        #endregion
    }
}
