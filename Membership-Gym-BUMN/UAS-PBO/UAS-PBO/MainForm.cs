using GymMembershipVirtual;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UAS_PBO
{
    public partial class MainForm : Form
    {
        private KelolaPelanggan manager;
        private List<AdminAccount> admins;

        public MainForm()
        {
            InitializeComponent();

            manager = new KelolaPelanggan();
            admins = new List<AdminAccount> { new AdminAccount("admin", "admin123") };

            btnLogin.Click += BtnLogin_Click;
            btnRegister.Click += BtnRegister_Click;
            btnExit.Click += (s, e) => this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(manager, admins);
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(manager);
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}
