using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol_Otomasyon
{
    public partial class YakıtTalepOnayı : Form
    {
        // Bağlantı stringi
        private string connectionString = @"Server=DESKTOP-GE9UJQI;Database=PetrolOtomasyon;Integrated Security=True";
        private SqlConnection connection;

        public YakıtTalepOnayı()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void YakıtTalepOnayı_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open(); // Bağlantıyı açıyoruz
                AddRandomRequests(); // Rastgele talepleri ekliyoruz
                VerileriYukle(); // Verileri yükle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yakıt talepleri yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close(); // Bağlantıyı kapatıyoruz
            }
        }

        private void VerileriYukle()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id, TalepTarihi, Miktar, Durum FROM YakıtTalep WHERE Durum = 'Onay Bekliyor'"; // 'TalepId' yerine 'Id' kullandık
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewYakıtTalepleri.DataSource = dt;
            }
        }

        private void AddRandomRequests()
        {
            Random random = new Random();
            try
            {
                // 10 adet rastgele talep ekliyoruz
                for (int i = 0; i < 10; i++)
                {
                    DateTime randomDate = DateTime.Now.AddDays(random.Next(-30, 30)); // Son 30 gün içinde rastgele bir tarih
                    int randomMiktar = random.Next(10, 101); // 10 ile 100 arasında rastgele bir miktar
                    string[] durumlar = { "Onay Bekliyor", "Onaylandı", "Reddedildi" };
                    string randomDurum = durumlar[0]; // Yeni taleplerin durumu başlangıçta "Onay Bekliyor" olacak

                    // Talep verisini veritabanına ekliyoruz
                    string query = "INSERT INTO YakıtTalep (TalepTarihi, Miktar, Durum) VALUES (@TalepTarihi, @Miktar, @Durum)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TalepTarihi", randomDate);
                    command.Parameters.AddWithValue("@Miktar", randomMiktar);
                    command.Parameters.AddWithValue("@Durum", randomDurum);

                    command.ExecuteNonQuery(); // Veriyi ekliyoruz
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rastgele talepler eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (dataGridViewYakıtTalepleri.SelectedRows.Count > 0)
            {
                int talepId = Convert.ToInt32(dataGridViewYakıtTalepleri.SelectedRows[0].Cells[0].Value);
                OnayDurumunuGuncelle(talepId, true);
            }
            else
            {
                MessageBox.Show("Lütfen onaylamak için bir talep seçin.");
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            if (dataGridViewYakıtTalepleri.SelectedRows.Count > 0)
            {
                int talepId = Convert.ToInt32(dataGridViewYakıtTalepleri.SelectedRows[0].Cells[0].Value);
                OnayDurumunuGuncelle(talepId, false);
            }
            else
            {
                MessageBox.Show("Lütfen reddetmek için bir talep seçin.");
            }
        }

        private void OnayDurumunuGuncelle(int talepId, bool onay)
        {
            string onayDurumu = onay ? "Onaylandı" : "Reddedildi";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE YakıtTalep SET Durum = @Durum WHERE Id = @TalepId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Durum", onayDurumu);
                cmd.Parameters.AddWithValue("@TalepId", talepId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Talep durumu güncellendi.");
                    VerileriYukle(); // Durum güncellendikten sonra verileri tekrar yükle
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu.");
                }
            }
        }
    }
}
