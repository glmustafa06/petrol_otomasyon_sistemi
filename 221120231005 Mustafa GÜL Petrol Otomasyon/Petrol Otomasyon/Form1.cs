using System.Data.SqlClient;

namespace Petrol_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            // Y�netici i�in sabit kullan�c� bilgileri
            string adminKullaniciAdi = "admin";
            string adminSifre = "admin123";
            string subeYoneticiKullaniciAdi = "subeyonetici";
            string subeYoneticiSifre = "sube456";
            string pompaciKullaniciAdi = "pompaci";
            string pompaciSifre = "pompa789";

            // Kullan�c� ad� ve �ifre do�rulamas�
            if (kullaniciAdi == adminKullaniciAdi && sifre == adminSifre)
            {
                // Genel Merkez Y�netici ekran�n� a�
                Y�neticiEkrani y�neticiFormu = new Y�neticiEkrani();
                y�neticiFormu.Show();
                this.Hide(); // Giri� ekran�n� gizle
            }
            else if (kullaniciAdi == subeYoneticiKullaniciAdi && sifre == subeYoneticiSifre)
            {
                // �ube Y�neticisi ekran�n� a�
                SubeYoneticiEkrani subeFormu = new SubeYoneticiEkrani();
                subeFormu.Show();
                this.Hide(); // Giri� ekran�n� gizle
            }
            else if (kullaniciAdi == pompaciKullaniciAdi && sifre == pompaciSifre)
            {
                // Pompac� ekran�n� a�
                PompaciEkrani pompaciFormu = new PompaciEkrani();
                pompaciFormu.Show();
                this.Hide(); // Giri� ekran�n� gizle
            }
            else
            {
                // Hatal� giri� yap�ld���nda uyar� mesaj�
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
