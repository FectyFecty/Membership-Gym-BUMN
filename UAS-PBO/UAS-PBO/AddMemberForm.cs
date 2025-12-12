using GymMembershipVirtual;
using System;
using System.Windows.Forms;

namespace UAS_PBO
{
    public partial class AddMemberForm : Form
    {
        private KelolaPelanggan manager;

        public AddMemberForm(KelolaPelanggan mgr)
        {
            manager = mgr;
            InitializeComponent();

            btnAdd.Click += BtnAdd_Click;
            btnCancel.Click += (s, e) => this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string nama = txtNama.Text.Trim();
            int durasi = (int)numDurasi.Value;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (manager.cariUsername(username) != null)
            {
                MessageBox.Show("Username sudah digunakan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Membership plan;
            int loker = 0;

            switch (cboMembership.SelectedIndex)
            {
                case 0:
                    plan = new GoldMembership();
                    loker = new Random().Next(200, 300);
                    break;
                case 1:
                    plan = new SilverMembership();
                    loker = new Random().Next(200, 300);
                    break;
                case 2:
                    plan = new BronzeMembership();
                    loker = 0;
                    break;
                default:
                    MessageBox.Show("Pilihan tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            manager.Pelangganan.Add(new Pelanggan(username, password, nama, plan, durasi, loker, true));
            string lokerInfo = loker == 0 ? "-" : loker.ToString();
            MessageBox.Show($"Member baru berhasil ditambahkan!\nUsername: {username}\nTipe: {plan.GetName()}\nLoker: {lokerInfo}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
