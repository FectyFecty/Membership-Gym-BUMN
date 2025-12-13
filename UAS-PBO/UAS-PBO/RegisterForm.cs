using GymMembershipVirtual;
using System;
using System.Windows.Forms;

namespace UAS_PBO
{
    public partial class RegisterForm : Form
    {
        private KelolaPelanggan manager;

        public RegisterForm(KelolaPelanggan mgr)
        {
            manager = mgr;
            InitializeComponent();

            btnRegister.Click += BtnRegister_Click;
            btnCancel.Click += (s, e) => this.Close();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string nama = txtNama.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check username exists
            if (manager.cariUsername(username) != null)
            {
                MessageBox.Show("Username sudah digunakan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Membership plan;
            int durasi;
            int loker = 0;
            string tipeName = "";

            switch (cboMembership.SelectedIndex)
            {
                case 0: // Gold
                    plan = new GoldMembership();
                    durasi = 6;
                    loker = new Random().Next(200, 300);
                    tipeName = "Gold";
                    break;
                case 1: // Silver
                    plan = new SilverMembership();
                    durasi = 3;
                    loker = new Random().Next(200, 300);
                    tipeName = "Silver";
                    break;
                case 2: // Bronze
                    plan = new BronzeMembership();
                    durasi = 1;
                    loker = 0;
                    tipeName = "Bronze";
                    break;
                default:
                    MessageBox.Show("Pilihan tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            manager.Pelangganan.Add(new Pelanggan(username, password, nama, plan, durasi, loker, true));

            string lokerInfo = loker == 0 ? "Tidak mendapatkan loker" : $"Nomor loker: {loker}";
            MessageBox.Show($"Pendaftaran berhasil!\n\nUsername: {username}\nTipe: {tipeName}\n{lokerInfo}\n\nSelamat berolahraga!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
