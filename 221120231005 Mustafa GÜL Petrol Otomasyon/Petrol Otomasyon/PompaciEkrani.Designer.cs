namespace Petrol_Otomasyon
{
    partial class PompaciEkrani
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.ComboBox cmbFuelType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnPerformTransaction;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.ComboBox cmbBranch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnPerformTransaction = new System.Windows.Forms.Button();
            this.lblBranch = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(150, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pompacı Ekranı";
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(50, 80);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(60, 15);
            this.lblFuelType.TabIndex = 1;
            this.lblFuelType.Text = "Yakıt Türü";
            // 
            // cmbFuelType
            // 
            this.cmbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuelType.FormattingEnabled = true;
            this.cmbFuelType.Items.AddRange(new object[] {
            "V/Max Kurşunsuz 95",
            "V/Max Diesel",
            "PO/gaz Otogaz"});
            this.cmbFuelType.Location = new System.Drawing.Point(150, 77);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(200, 23);
            this.cmbFuelType.TabIndex = 2;
            this.cmbFuelType.SelectedIndexChanged += new System.EventHandler(this.cmbFuelType_SelectedIndexChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(50, 120);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(43, 15);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Miktar";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(150, 117);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 23);
            this.txtQuantity.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(50, 160);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Fiyat";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(150, 157);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(200, 23);
            this.txtPrice.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(150, 200);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Hesapla";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(50, 240);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 15);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Toplam";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(150, 237);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(200, 23);
            this.txtTotal.TabIndex = 10;
            // 
            // btnPerformTransaction
            // 
            this.btnPerformTransaction.Location = new System.Drawing.Point(150, 270);
            this.btnPerformTransaction.Name = "btnPerformTransaction";
            this.btnPerformTransaction.Size = new System.Drawing.Size(200, 23);
            this.btnPerformTransaction.TabIndex = 11;
            this.btnPerformTransaction.Text = "İşlemi Gerçekleştir";
            this.btnPerformTransaction.UseVisualStyleBackColor = true;
            this.btnPerformTransaction.Click += new System.EventHandler(this.btnPerformTransaction_Click);
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(50, 50);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(38, 15);
            this.lblBranch.TabIndex = 12;
            this.lblBranch.Text = "Şube";
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(150, 47);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(200, 23);
            this.cmbBranch.TabIndex = 13;
            // 
            // PompaciEkrani
            // 
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.btnPerformTransaction);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cmbFuelType);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.lblTitle);
            this.Name = "PompaciEkrani";
            this.Text = "Pompacı Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
