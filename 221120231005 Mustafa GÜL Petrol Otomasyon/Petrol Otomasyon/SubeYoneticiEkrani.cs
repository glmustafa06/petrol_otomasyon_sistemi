using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol_Otomasyon
{
    public partial class SubeYoneticiEkrani : Form
    {
        private string connectionString = @"Server=DESKTOP-GE9UJQI;Database=PetrolOtomasyon;Integrated Security=True";

        public SubeYoneticiEkrani()
        {
            InitializeComponent();
        }

        private void SubeYoneticiEkrani_Load(object sender, EventArgs e)
        {
            LoadSubePerformansi();
            LoadYakitStokDurumu();
            LoadYakıtTalepleri();
            LoadPersonelDurumu();
        }

        private void LoadSubePerformansi()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SubePerformansi";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSubePerformansi.DataSource = dt;
            }
        }

        private void LoadYakitStokDurumu()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM YakitStok";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewYakitStok.DataSource = dt;
            }
        }

        private void LoadYakıtTalepleri()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM YakıtTalep";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewYakıtTalepleri.DataSource = dt;
            }
        }

        private void LoadPersonelDurumu()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Calisanlar";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewPersonel.DataSource = dt;
            }
        }
    }
}
