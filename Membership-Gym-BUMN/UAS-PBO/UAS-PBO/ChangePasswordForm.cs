using GymMembershipVirtual;
using System;
using System.Windows.Forms;

namespace UAS_PBO
{
    public partial class ChangePasswordForm : Form
    {
        private Pelanggan member;

        public ChangePasswordForm(Pelanggan mem)
        {
            member = mem;
            InitializeComponent();

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text != member.password)
            {
                MessageBox.Show("Password lama salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                MessageBox.Show("Password baru tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Konfirmasi password tidak cocok!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            member.password = txtNewPassword.Text;
            MessageBox.Show("Password berhasil diubah!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
