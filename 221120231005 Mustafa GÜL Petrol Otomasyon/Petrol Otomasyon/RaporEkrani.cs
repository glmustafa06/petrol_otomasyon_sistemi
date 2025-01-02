using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol_Otomasyon
{
    public partial class RaporEkrani : Form
    {
        private string connectionString = @"Server=DESKTOP-GE9UJQI;Database=PetrolOtomasyon;Integrated Security=True";

        public RaporEkrani()
        {
            InitializeComponent();
        }

        private void RaporEkrani_Load(object sender, EventArgs e)
        {
            LoadYakıtTalepleri();
            LoadIslemler();
            LoadSubePerformanslari();
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

        private void LoadIslemler()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Islemler";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewIslemler.DataSource = dt;
            }
        }

        private void LoadSubePerformanslari()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT s.SubeAdi, COUNT(i.IslemID) AS ToplamIslem, SUM(i.Miktar) AS ToplamMiktar
                FROM Subeler s
                LEFT JOIN Islemler i ON s.SubeID = i.SubeID
                GROUP BY s.SubeAdi";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSubePerformans.DataSource = dt;
            }
        }

        public void AddTransaction(string branchName, string fuelType, decimal quantity, decimal total)
        {
            DataTable dt = dataGridViewIslemler.DataSource as DataTable;
            if (dt == null)
            {
                dt = new DataTable();
                dt.Columns.Add("BranchName", typeof(string));
                dt.Columns.Add("FuelType", typeof(string));
                dt.Columns.Add("Quantity", typeof(decimal));
                dt.Columns.Add("Total", typeof(decimal));
                dataGridViewIslemler.DataSource = dt;
            }

            DataRow newRow = dt.NewRow();
            newRow["BranchName"] = branchName;
            newRow["FuelType"] = fuelType;
            newRow["Quantity"] = quantity;
            newRow["Total"] = total;
            dt.Rows.Add(newRow);
        }
    }
}
