using GymMembershipVirtual;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UAS_PBO
{
    public partial class LoginForm : Form
    {
        private KelolaPelanggan manager;
        private List<AdminAccount> admins;

        public LoginForm(KelolaPelanggan mgr, List<AdminAccount> adminList)
        {
            manager = mgr;
            admins = adminList;
            InitializeComponent();

            btnLogin.Click += BtnLogin_Click;
            btnCancel.Click += (s, e) => this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // check admin
            var admin = admins.Find(a => a.username == username && a.password == password);
            if (admin != null)
            {
                MessageBox.Show("Login berhasil sebagai Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminForm adminForm = new AdminForm(manager);
                this.Hide();
                adminForm.ShowDialog();
                this.Close();
                return;
            }

            // check member
            var member = manager.cariUsername(username);
            if (member != null && member.password == password)
            {
                MessageBox.Show($"Login berhasil! Selamat datang {member.namaLengkap}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserForm userForm = new UserForm(member, manager);
                this.Hide();
                userForm.ShowDialog();
                this.Close();
                return;
            }

            MessageBox.Show("Login gagal: username/password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(manager);
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}
