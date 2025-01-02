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

            // Yönetici için sabit kullanýcý bilgileri
            string adminKullaniciAdi = "admin";
            string adminSifre = "admin123";
            string subeYoneticiKullaniciAdi = "subeyonetici";
            string subeYoneticiSifre = "sube456";
            string pompaciKullaniciAdi = "pompaci";
            string pompaciSifre = "pompa789";

            // Kullanýcý adý ve þifre doðrulamasý
            if (kullaniciAdi == adminKullaniciAdi && sifre == adminSifre)
            {
                // Genel Merkez Yönetici ekranýný aç
                YöneticiEkrani yöneticiFormu = new YöneticiEkrani();
                yöneticiFormu.Show();
                this.Hide(); // Giriþ ekranýný gizle
            }
            else if (kullaniciAdi == subeYoneticiKullaniciAdi && sifre == subeYoneticiSifre)
            {
                // Þube Yöneticisi ekranýný aç
                SubeYoneticiEkrani subeFormu = new SubeYoneticiEkrani();
                subeFormu.Show();
                this.Hide(); // Giriþ ekranýný gizle
            }
            else if (kullaniciAdi == pompaciKullaniciAdi && sifre == pompaciSifre)
            {
                // Pompacý ekranýný aç
                PompaciEkrani pompaciFormu = new PompaciEkrani();
                pompaciFormu.Show();
                this.Hide(); // Giriþ ekranýný gizle
            }
            else
            {
                // Hatalý giriþ yapýldýðýnda uyarý mesajý
                MessageBox.Show("Kullanýcý adý veya þifre hatalý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
