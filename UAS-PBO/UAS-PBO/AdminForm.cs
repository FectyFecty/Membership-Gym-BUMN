using GymMembershipVirtual;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UAS_PBO
{
    public partial class AdminForm : Form
    {
        private KelolaPelanggan manager;

        public AdminForm(KelolaPelanggan mgr)
        {
            manager = mgr;
            InitializeComponent();
            LoadMemberData();

            // Event handlers
            btnAdd.Click += BtnAdd_Click;
            btnRefresh.Click += (s, e) => LoadMemberData();
            btnDelete.Click += BtnDelete_Click;
            btnToggleStatus.Click += BtnToggleStatus_Click;
            btnFilterType.Click += BtnFilterType_Click;
            btnTotal.Click += (s, e) => MessageBox.Show($"Total member: {manager.TotalPelanggan()}", "Info");
            btnLogout.Click += (s, e) => this.Close();
        }

        private void LoadMemberData(List<Pelanggan> list = null)
        {
            dgvMembers.Rows.Clear();
            dgvMembers.Columns.Clear();

            dgvMembers.Columns.Add("Username", "Username");
            dgvMembers.Columns.Add("Tipe", "Tipe");
            dgvMembers.Columns.Add("NamaLengkap", "Nama Lengkap");
            dgvMembers.Columns.Add("Durasi", "Durasi (bln)");
            dgvMembers.Columns.Add("Loker", "Loker");
            dgvMembers.Columns.Add("Status", "Status");
            dgvMembers.Columns.Add("Benefit", "Benefit");

            var members = list ?? manager.Pelangganan;

            foreach (var m in members)
            {
                dgvMembers.Rows.Add(
                    m.username,
                    m.membershipPlan.GetName(),
                    m.namaLengkap,
                    m.durasiLangganan,
                    m.loker == 0 ? "-" : m.loker.ToString(),
                    m.isAktif ? "Aktif" : "Expired",
                    m.membershipPlan.GetBenefit()
                );
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddMemberForm addForm = new AddMemberForm(manager);
            addForm.ShowDialog();
            LoadMemberData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih member yang akan dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = dgvMembers.SelectedRows[0].Cells[0].Value.ToString();
            var member = manager.cariUsername(username);
            if (member == null) return;

            if (MessageBox.Show($"Yakin hapus {member.namaLengkap} ({member.username})?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                manager.hapusPelanggan(username);
                MessageBox.Show("Member berhasil dihapus!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMemberData();
            }
        }

        private void BtnToggleStatus_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih member untuk mengubah status!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = dgvMembers.SelectedRows[0].Cells[0].Value.ToString();
            var member = manager.cariUsername(username);
            if (member == null) return;

            if (MessageBox.Show($"Status saat ini: {(member.isAktif ? "Aktif" : "Expired")}\nGanti status?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                manager.ToggleAktif(username);
                MessageBox.Show("Status berhasil diubah!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMemberData();
            }
        }

        private void BtnFilterType_Click(object sender, EventArgs e)
        {
            string selected = Microsoft.VisualBasic.Interaction.InputBox(
                "Masukkan tipe membership:\n(Gold/Silver/Bronze/Semua)",
                "Filter by Type", "Semua");

            if (string.IsNullOrEmpty(selected)) return;

            if (selected.Equals("Semua", StringComparison.OrdinalIgnoreCase))
            {
                LoadMemberData();
            }
            else
            {
                var filtered = manager.cariTipeMembership(selected);
                if (filtered.Count == 0)
                {
                    MessageBox.Show("Tidak ada member dengan tipe tersebut!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                LoadMemberData(filtered);
            }
        }
    }
}
