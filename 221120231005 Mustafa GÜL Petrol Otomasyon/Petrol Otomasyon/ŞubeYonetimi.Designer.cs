namespace PetrolOtomasyonSistemi
{
    partial class ŞubeYonetimi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSubeAdi;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.TextBox txtCalisanSayisi; // Çalışan sayısı için ekledim
        private System.Windows.Forms.Button btnSubeEkle;
        private System.Windows.Forms.Button btnSubeSil;  // Şube silme butonu
        private System.Windows.Forms.Button btnSubeGuncelle;  // Şube güncelleme butonu
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSubeAdi;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label lblIlce;
        private System.Windows.Forms.Label lblCalisanSayisi; // Çalışan sayısı için etiket

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
            txtSubeAdi = new TextBox();
            txtSehir = new TextBox();
            txtIlce = new TextBox();
            txtCalisanSayisi = new TextBox();
            btnSubeEkle = new Button();
            btnSubeSil = new Button();
            btnSubeGuncelle = new Button();
            dataGridView1 = new DataGridView();
            lblSubeAdi = new Label();
            lblSehir = new Label();
            lblIlce = new Label();
            lblCalisanSayisi = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSubeAdi
            // 
            txtSubeAdi.Location = new Point(320, 30);
            txtSubeAdi.Name = "txtSubeAdi";
            txtSubeAdi.Size = new Size(200, 23);
            txtSubeAdi.TabIndex = 0;
            // 
            // txtSehir
            // 
            txtSehir.Location = new Point(320, 70);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(200, 23);
            txtSehir.TabIndex = 1;
            // 
            // txtIlce
            // 
            txtIlce.Location = new Point(320, 107);
            txtIlce.Name = "txtIlce";
            txtIlce.Size = new Size(200, 23);
            txtIlce.TabIndex = 2;
            // 
            // txtCalisanSayisi
            // 
            txtCalisanSayisi.Location = new Point(320, 147);
            txtCalisanSayisi.Name = "txtCalisanSayisi";
            txtCalisanSayisi.Size = new Size(200, 23);
            txtCalisanSayisi.TabIndex = 3;
            // 
            // btnSubeEkle
            // 
            btnSubeEkle.Location = new Point(120, 200);
            btnSubeEkle.Name = "btnSubeEkle";
            btnSubeEkle.Size = new Size(75, 23);
            btnSubeEkle.TabIndex = 4;
            btnSubeEkle.Text = "Ekle";
            btnSubeEkle.UseVisualStyleBackColor = true;
            btnSubeEkle.Click += btnSubeEkle_Click;
            // 
            // btnSubeSil
            // 
            btnSubeSil.Location = new Point(220, 200);
            btnSubeSil.Name = "btnSubeSil";
            btnSubeSil.Size = new Size(75, 23);
            btnSubeSil.TabIndex = 5;
            btnSubeSil.Text = "Sil";
            btnSubeSil.UseVisualStyleBackColor = true;
            btnSubeSil.Click += btnSubeSil_Click;
            // 
            // btnSubeGuncelle
            // 
            btnSubeGuncelle.Location = new Point(320, 200);
            btnSubeGuncelle.Name = "btnSubeGuncelle";
            btnSubeGuncelle.Size = new Size(75, 23);
            btnSubeGuncelle.TabIndex = 6;
            btnSubeGuncelle.Text = "Güncelle";
            btnSubeGuncelle.UseVisualStyleBackColor = true;
            btnSubeGuncelle.Click += btnSubeGuncelle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(758, 200);
            dataGridView1.TabIndex = 7;
            // 
            // lblSubeAdi
            // 
            lblSubeAdi.AutoSize = true;
            lblSubeAdi.Location = new Point(120, 30);
            lblSubeAdi.Name = "lblSubeAdi";
            lblSubeAdi.Size = new Size(54, 15);
            lblSubeAdi.TabIndex = 8;
            lblSubeAdi.Text = "Şube Adı";
            // 
            // lblSehir
            // 
            lblSehir.AutoSize = true;
            lblSehir.Location = new Point(118, 70);
            lblSehir.Name = "lblSehir";
            lblSehir.Size = new Size(33, 15);
            lblSehir.TabIndex = 9;
            lblSehir.Text = "Şehir";
            // 
            // lblIlce
            // 
            lblIlce.AutoSize = true;
            lblIlce.Location = new Point(120, 107);
            lblIlce.Name = "lblIlce";
            lblIlce.Size = new Size(25, 15);
            lblIlce.TabIndex = 10;
            lblIlce.Text = "İlçe";
            // 
            // lblCalisanSayisi
            // 
            lblCalisanSayisi.AutoSize = true;
            lblCalisanSayisi.Location = new Point(118, 147);
            lblCalisanSayisi.Name = "lblCalisanSayisi";
            lblCalisanSayisi.Size = new Size(77, 15);
            lblCalisanSayisi.TabIndex = 11;
            lblCalisanSayisi.Text = "Çalışan Sayısı";
            // 
            // ŞubeYonetimi
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(lblCalisanSayisi);
            Controls.Add(lblIlce);
            Controls.Add(lblSehir);
            Controls.Add(lblSubeAdi);
            Controls.Add(dataGridView1);
            Controls.Add(btnSubeGuncelle);
            Controls.Add(btnSubeSil);
            Controls.Add(btnSubeEkle);
            Controls.Add(txtCalisanSayisi);
            Controls.Add(txtIlce);
            Controls.Add(txtSehir);
            Controls.Add(txtSubeAdi);
            Name = "ŞubeYonetimi";
            Text = "Şube Yönetimi";
            Load += ŞubeYonetimi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
