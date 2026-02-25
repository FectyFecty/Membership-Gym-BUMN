using GymMembershipVirtual;
using System;
using System.Windows.Forms;

namespace UAS_PBO
{
    public partial class UserForm : Form
    {
        private Pelanggan member;
        private KelolaPelanggan manager;

        public UserForm(Pelanggan mem, KelolaPelanggan mgr)
        {
            member = mem;
            manager = mgr;
            InitializeComponent();

            lblTitle.Text = $"Selamat Datang, {member.namaLengkap}";
            lblProfileInfo.Text = GetProfileInfo();

            btnViewProfile.Click += (s, e) => { lblProfileInfo.Text = GetProfileInfo(); MessageBox.Show("Profil di-refresh!", "Info"); };
            btnViewBenefit.Click += BtnViewBenefit_Click;
            btnChangePassword.Click += BtnChangePassword_Click;
            btnUpgrade.Click += BtnUpgrade_Click;
            btnLogout.Click += (s, e) => this.Close();
        }

        private string GetProfileInfo()
        {
            return $"Username    : {member.username}\n" +
                   $"Nama        : {member.namaLengkap}\n" +
                   $"Membership  : {member.membershipPlan.GetName()}\n" +
                   $"Durasi      : {member.durasiLangganan} bulan\n" +
                   $"Loker       : {(member.loker == 0 ? "-" : member.loker.ToString())}\n" +
                   $"Status      : {(member.isAktif ? "Aktif" : "Expired")}";
        }

        private void BtnViewBenefit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Benefit Membership {member.membershipPlan.GetName()}:\n\n{member.membershipPlan.GetBenefit()}",
                "Benefit Membership", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changeForm = new ChangePasswordForm(member);
            changeForm.ShowDialog();
            lblProfileInfo.Text = GetProfileInfo(); // refresh profile info
        }

        private void BtnUpgrade_Click(object sender, EventArgs e)
        {
            UpgradeMembershipForm upgradeForm = new UpgradeMembershipForm(member, manager);
            upgradeForm.ShowDialog();
            lblProfileInfo.Text = GetProfileInfo(); // refresh profile info
        }
    }
}
