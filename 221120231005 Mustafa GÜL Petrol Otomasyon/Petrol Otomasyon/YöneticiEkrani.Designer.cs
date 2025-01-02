namespace Petrol_Otomasyon
{
    partial class YöneticiEkrani
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnSubeYonetimi = new Button();
            btnYakitTalepOnayi = new Button();
            btnRaporlar = new Button();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // btnSubeYonetimi
            // 
            btnSubeYonetimi.Location = new Point(86, 30);
            btnSubeYonetimi.Name = "btnSubeYonetimi";
            btnSubeYonetimi.Size = new Size(150, 40);
            btnSubeYonetimi.TabIndex = 4;
            btnSubeYonetimi.Text = "Şube Yönetimi";
            btnSubeYonetimi.UseVisualStyleBackColor = true;
            btnSubeYonetimi.Click += btnSubeYonetimi_Click_1;
            // 
            // btnYakitTalepOnayi
            // 
            btnYakitTalepOnayi.Location = new Point(458, 30);
            btnYakitTalepOnayi.Name = "btnYakitTalepOnayi";
            btnYakitTalepOnayi.Size = new Size(150, 40);
            btnYakitTalepOnayi.TabIndex = 1;
            btnYakitTalepOnayi.Text = "Yakıt Talep Onayı";
            btnYakitTalepOnayi.UseVisualStyleBackColor = true;
            btnYakitTalepOnayi.Click += btnYakitTalepOnayi_Click;
            // 
            // btnRaporlar
            // 
            btnRaporlar.Location = new Point(86, 150);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(150, 40);
            btnRaporlar.TabIndex = 2;
            btnRaporlar.Text = "Raporlar";
            btnRaporlar.UseVisualStyleBackColor = true;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(458, 150);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(150, 40);
            btnCikis.TabIndex = 3;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // YöneticiEkrani
            // 
            ClientSize = new Size(682, 297);
            Controls.Add(btnCikis);
            Controls.Add(btnRaporlar);
            Controls.Add(btnYakitTalepOnayi);
            Controls.Add(btnSubeYonetimi);
            Name = "YöneticiEkrani";
            Text = "Yönetici Ekranı";
            Load += YöneticiEkrani_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnSubeYonetimi;
        private System.Windows.Forms.Button btnYakitTalepOnayi;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnCikis;
    }
}
