// Data user - class member
namespace GymMembershipVirtual
{
    public class Pelanggan : User
    {
        public string namaLengkap;
        public Membership membershipPlan;
        public int durasiLangganan;
        public int loker;
        public bool isAktif;
        
            public Pelanggan(string user, string pw, string fullName, Membership plan, int durasi, int lokNum, bool aktif) : base(user, pw)
        {
            namaLengkap = fullName;
            membershipPlan = plan;
            durasiLangganan = durasi;
            loker = lokNum;
            isAktif = aktif;
        }
    }
}

// Nama, membershipnya, lokernya