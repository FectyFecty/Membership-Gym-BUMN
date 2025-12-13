using GymMembershipVirtual;
using System;
using System.Windows.Forms;

namespace UAS_PBO
{
    public partial class UpgradeMembershipForm : Form
    {
        private Pelanggan member;
        private KelolaPelanggan manager;

        public UpgradeMembershipForm(Pelanggan mem, KelolaPelanggan mgr)
        {
            member = mem;
            manager = mgr;
            InitializeComponent();

            lblCurrent.Text = $"Membership Saat Ini: {member.membershipPlan.GetName()}";
            btnConfirm.Click += BtnConfirm_Click;
            btnCancel.Click += (s, e) => this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Membership newPlan = null;
            string planName = "";

            switch (cboMembership.SelectedIndex)
            {
                case 0:
                    newPlan = new GoldMembership();
                    planName = "Gold";
                    break;
                case 1:
                    newPlan = new SilverMembership();
                    planName = "Silver";
                    break;
                case 2:
                    newPlan = new BronzeMembership();
                    planName = "Bronze";
                    break;
                default:
                    return;
            }

            if (newPlan.GetName() == member.membershipPlan.GetName())
            {
                MessageBox.Show("Anda sudah menggunakan membership ini!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Konfirmasi pembayaran untuk membership {planName}?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                member.membershipPlan = newPlan;

                    Random rnd = new Random();
                    do
                    {
                        member.loker = rnd.Next(200, 300);
                    }
                while (manager.Pelangganan.Any(p => p.loker == member.loker && p != member));
                string lokerInfo = member.loker == 0 ? "-" : member.loker.ToString();
                MessageBox.Show($"Membership berhasil diganti menjadi {planName}!\nNomor loker baru: {lokerInfo}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}