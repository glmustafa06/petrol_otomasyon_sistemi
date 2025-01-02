using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Petrol_Otomasyon
{
    public partial class PompaciEkrani : Form
    {
        private string connectionString = @"Server=DESKTOP-GE9UJQI;Database=PetrolOtomasyon;Integrated Security=True";

        public PompaciEkrani()
        {
            InitializeComponent();
            LoadBranches();
        }

        private void LoadBranches()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SubeID, SubeAdi FROM Subeler";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbBranch.Items.Add(new { Text = reader["SubeAdi"].ToString(), Value = reader["SubeID"] });
                }
                cmbBranch.DisplayMember = "Text";
                cmbBranch.ValueMember = "Value";
            }
        }

        private void cmbFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFuelType.SelectedItem.ToString())
            {
                case "V/Max Kurşunsuz 95":
                    txtPrice.Text = "44.04";
                    break;
                case "V/Max Diesel":
                    txtPrice.Text = "44.76";
                    break;
                case "PO/gaz Otogaz":
                    txtPrice.Text = "26.41";
                    break;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtQuantity.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal quantity) &&
                decimal.TryParse(txtPrice.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal price))
            {
                decimal total = quantity * price;
                txtTotal.Text = total.ToString("F2", CultureInfo.InvariantCulture).TrimEnd('0').TrimEnd('.');
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin.");
            }
        }

        private void btnPerformTransaction_Click(object sender, EventArgs e)
        {
            if (cmbFuelType.SelectedIndex == -1 || string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtTotal.Text) || cmbBranch.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            string fuelType = cmbFuelType.SelectedItem.ToString();
            decimal quantity = decimal.Parse(txtQuantity.Text, CultureInfo.InvariantCulture);
            decimal price = decimal.Parse(txtPrice.Text, CultureInfo.InvariantCulture);
            decimal total = decimal.Parse(txtTotal.Text, CultureInfo.InvariantCulture);
            string branchName = (cmbBranch.SelectedItem as dynamic).Text;

            // Update the report screen directly
            UpdateReportScreen(branchName, fuelType, quantity, total);

            MessageBox.Show("Yakıt işlemi gerçekleştirildi.");
        }

        private void UpdateReportScreen(string branchName, string fuelType, decimal quantity, decimal total)
        {
            // Assuming you have a reference to the report screen form
            RaporEkrani reportScreen = Application.OpenForms["RaporEkrani"] as RaporEkrani;
            if (reportScreen != null)
            {
                reportScreen.AddTransaction(branchName, fuelType, quantity, total);
            }
        }

        private int GetFuelID(string fuelType)
        {
            switch (fuelType)
            {
                case "V/Max Kurşunsuz 95":
                    return 1;
                case "V/Max Diesel":
                    return 2;
                case "PO/gaz Otogaz":
                    return 3;
                default:
                    return -1;
            }
        }
    }
}
