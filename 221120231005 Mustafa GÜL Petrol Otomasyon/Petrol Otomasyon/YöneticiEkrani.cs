using Petrol_Otomasyon;
using PetrolOtomasyonSistemi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Otomasyon
{
    public partial class YöneticiEkrani : Form
    {
        public YöneticiEkrani()
        {
            InitializeComponent();
        }

        private void YöneticiEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnSubeYonetimi_Click_1(object sender, EventArgs e)
        {
            ŞubeYonetimi subeYonetimiForm = new ŞubeYonetimi();
            subeYonetimiForm.Show(); // Formu yeni sekmede açma
        }

        private void btnYakitTalepOnayi_Click(object sender, EventArgs e)
        {
            // Yakıt Talep Onayı formunu aç
            YakıtTalepOnayı yakıtTalepOnayıFormu = new YakıtTalepOnayı();
            yakıtTalepOnayıFormu.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {  
            RaporEkrani raporEkraniFormu = new RaporEkrani(); 
            raporEkraniFormu.Show(); 
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            // Uygulamadan çıkış yapmak için kod
            Application.Exit();
        }
    }
}
