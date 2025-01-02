using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PetrolOtomasyonSistemi
{
    public partial class ŞubeYonetimi : Form
    {
        private string connectionString = @"Server=DESKTOP-GE9UJQI;Database=PetrolOtomasyon;Integrated Security=True"; // Veritabanı bağlantı dizesi

        public ŞubeYonetimi()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde çalışacak olan metod
        private void ŞubeYonetimi_Load(object sender, EventArgs e)
        {
            // Veritabanındaki şubeleri veri gridine yükleyin
            LoadSubeler();
        }

        // Şubeleri veritabanından alıp DataGridView'de göstermek için bir metod
        private void LoadSubeler()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Subeler"; // Subeler tablosundan tüm verileri alıyoruz
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        // Şube ekleme butonuna tıklanınca çalışacak metod
        private void btnSubeEkle_Click(object sender, EventArgs e)
        {
            string subeAdi = txtSubeAdi.Text;
            string sehir = txtSehir.Text;
            string ilce = txtIlce.Text;
            string calisanSayisiText = txtCalisanSayisi.Text;

            // Gerekli alanların boş olmadığından emin olun
            if (string.IsNullOrEmpty(subeAdi) || string.IsNullOrEmpty(sehir) || string.IsNullOrEmpty(ilce) || string.IsNullOrEmpty(calisanSayisiText))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }

            // CalisanSayisi'ni integer'a dönüştürün
            int calisanSayisi;
            bool isInteger = int.TryParse(calisanSayisiText, out calisanSayisi);

            if (!isInteger)
            {
                // Hatalı giriş durumu
                MessageBox.Show("Çalışan sayısı geçerli bir sayı olmalıdır.");
                Console.WriteLine("Hatalı giriş: " + calisanSayisiText); // Hatalı girdi ile ilgili bilgi konsola yazdırılır
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO Subeler (SubeAdi, Sehir, Ilce, CalisanSayisi) VALUES (@SubeAdi, @Sehir, @Ilce, @CalisanSayisi)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SubeAdi", subeAdi);
                    command.Parameters.AddWithValue("@Sehir", sehir);
                    command.Parameters.AddWithValue("@Ilce", ilce);
                    command.Parameters.AddWithValue("@CalisanSayisi", calisanSayisi); // Burada integer kullanıyoruz

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Şube başarıyla eklendi.");

                    // Veritabanındaki şubeleri tekrar yükle
                    LoadSubeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        // Şube silme butonuna tıklanınca çalışacak metod
        private void btnSubeSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string subeId = dataGridView1.SelectedRows[0].Cells["SubeID"].Value.ToString(); // SubeID kolonu varsayılıyor

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        string query = "DELETE FROM Subeler WHERE SubeID = @SubeID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SubeID", subeId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Şube başarıyla silindi.");

                        // Veritabanındaki şubeleri tekrar yükle
                        LoadSubeler();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silinecek şube seçilmedi.");
            }
        }

        // Şube güncelleme butonuna tıklanınca çalışacak metod
        private void btnSubeGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string subeId = dataGridView1.SelectedRows[0].Cells["SubeID"].Value.ToString(); // SubeID kolonu varsayılıyor
                string subeAdi = txtSubeAdi.Text;
                string sehir = txtSehir.Text;
                string ilce = txtIlce.Text;
                string calisanSayisiText = txtCalisanSayisi.Text;

                // Gerekli alanların boş olmadığından emin olun
                if (string.IsNullOrEmpty(subeAdi) || string.IsNullOrEmpty(sehir) || string.IsNullOrEmpty(ilce) || string.IsNullOrEmpty(calisanSayisiText))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!");
                    return;
                }

                // CalisanSayisi'ni integer'a dönüştürün
                int calisanSayisi;
                if (!int.TryParse(calisanSayisiText, out calisanSayisi))
                {
                    MessageBox.Show("Çalışan sayısı geçerli bir sayı olmalıdır.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        string query = "UPDATE Subeler SET SubeAdi = @SubeAdi, Sehir = @Sehir, Ilce = @Ilce, CalisanSayisi = @CalisanSayisi WHERE SubeID = @SubeID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SubeAdi", subeAdi);
                        command.Parameters.AddWithValue("@Sehir", sehir);
                        command.Parameters.AddWithValue("@Ilce", ilce);
                        command.Parameters.AddWithValue("@CalisanSayisi", calisanSayisi); // Burada integer kullanıyoruz
                        command.Parameters.AddWithValue("@SubeID", subeId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Şube başarıyla güncellendi.");

                        // Veritabanındaki şubeleri tekrar yükle
                        LoadSubeler();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek şube seçilmedi.");
            }
        }
    }
}
