namespace Petrol_Otomasyon
{
    partial class SubeYoneticiEkrani
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewSubePerformansi;
        private System.Windows.Forms.DataGridView dataGridViewYakitStok;
        private System.Windows.Forms.DataGridView dataGridViewYakıtTalepleri;
        private System.Windows.Forms.DataGridView dataGridViewPersonel;
        private System.Windows.Forms.Label lblSubePerformansi;
        private System.Windows.Forms.Label lblYakitStok;
        private System.Windows.Forms.Label lblYakıtTalepleri;
        private System.Windows.Forms.Label lblPersonel;

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
            this.dataGridViewSubePerformansi = new System.Windows.Forms.DataGridView();
            this.dataGridViewYakitStok = new System.Windows.Forms.DataGridView();
            this.dataGridViewYakıtTalepleri = new System.Windows.Forms.DataGridView();
            this.dataGridViewPersonel = new System.Windows.Forms.DataGridView();
            this.lblSubePerformansi = new System.Windows.Forms.Label();
            this.lblYakitStok = new System.Windows.Forms.Label();
            this.lblYakıtTalepleri = new System.Windows.Forms.Label();
            this.lblPersonel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubePerformansi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYakitStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYakıtTalepleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSubePerformansi
            // 
            this.dataGridViewSubePerformansi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubePerformansi.Location = new System.Drawing.Point(12, 35);
            this.dataGridViewSubePerformansi.Name = "dataGridViewSubePerformansi";
            this.dataGridViewSubePerformansi.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewSubePerformansi.TabIndex = 0;
            // 
            // dataGridViewYakitStok
            // 
            this.dataGridViewYakitStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYakitStok.Location = new System.Drawing.Point(12, 220);
            this.dataGridViewYakitStok.Name = "dataGridViewYakitStok";
            this.dataGridViewYakitStok.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewYakitStok.TabIndex = 1;
            // 
            // dataGridViewYakıtTalepleri
            // 
            this.dataGridViewYakıtTalepleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYakıtTalepleri.Location = new System.Drawing.Point(12, 405);
            this.dataGridViewYakıtTalepleri.Name = "dataGridViewYakıtTalepleri";
            this.dataGridViewYakıtTalepleri.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewYakıtTalepleri.TabIndex = 2;
            // 
            // dataGridViewPersonel
            // 
            this.dataGridViewPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonel.Location = new System.Drawing.Point(12, 590);
            this.dataGridViewPersonel.Name = "dataGridViewPersonel";
            this.dataGridViewPersonel.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewPersonel.TabIndex = 3;
            // 
            // lblSubePerformansi
            // 
            this.lblSubePerformansi.AutoSize = true;
            this.lblSubePerformansi.Location = new System.Drawing.Point(12, 17);
            this.lblSubePerformansi.Name = "lblSubePerformansi";
            this.lblSubePerformansi.Size = new System.Drawing.Size(93, 13);
            this.lblSubePerformansi.TabIndex = 4;
            this.lblSubePerformansi.Text = "Şube Performansı";
            // 
            // lblYakitStok
            // 
            this.lblYakitStok.AutoSize = true;
            this.lblYakitStok.Location = new System.Drawing.Point(12, 204);
            this.lblYakitStok.Name = "lblYakitStok";
            this.lblYakitStok.Size = new System.Drawing.Size(100, 13);
            this.lblYakitStok.TabIndex = 5;
            this.lblYakitStok.Text = "Yakıt Stok Durumu";
            // 
            // lblYakıtTalepleri
            // 
            this.lblYakıtTalepleri.AutoSize = true;
            this.lblYakıtTalepleri.Location = new System.Drawing.Point(12, 389);
            this.lblYakıtTalepleri.Name = "lblYakıtTalepleri";
            this.lblYakıtTalepleri.Size = new System.Drawing.Size(75, 13);
            this.lblYakıtTalepleri.TabIndex = 6;
            this.lblYakıtTalepleri.Text = "Yakıt Talepleri";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(12, 574);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(49, 13);
            this.lblPersonel.TabIndex = 7;
            this.lblPersonel.Text = "Personel";
            // 
            // SubeYoneticiEkrani
            // 
            this.ClientSize = new System.Drawing.Size(800, 760);
            this.Controls.Add(this.lblPersonel);
            this.Controls.Add(this.lblYakıtTalepleri);
            this.Controls.Add(this.lblYakitStok);
            this.Controls.Add(this.lblSubePerformansi);
            this.Controls.Add(this.dataGridViewPersonel);
            this.Controls.Add(this.dataGridViewYakıtTalepleri);
            this.Controls.Add(this.dataGridViewYakitStok);
            this.Controls.Add(this.dataGridViewSubePerformansi);
            this.Name = "SubeYoneticiEkrani";
            this.Text = "Şube Yönetici Ekranı";
            this.Load += new System.EventHandler(this.SubeYoneticiEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubePerformansi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYakitStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYakıtTalepleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            // 
            // lblYakitStok
            // 
            this.lblYakitStok.AutoSize = true;
            this.lblYakitStok.Location = new System.Drawing.Point(12, 204);
            this.lblYakitStok.Name = "lblYakitStok";
            this.lblYakitStok.Size = new System.Drawing.Size(100, 13);
            this.lblYakitStok.TabIndex = 5;
            this.lblYakitStok.Text = "Yakıt Stok Durumu";
            // 
            // lblYakıtTalepleri
            // 
            this.lblYakıtTalepleri.AutoSize = true;
            this.lblYakıtTalepleri.Location = new System.Drawing.Point(12, 389);
            this.lblYakıtTalepleri.Name = "lblYakıtTalepleri";
            this.lblYakıtTalepleri.Size = new System.Drawing.Size(75, 13);
            this.lblYakıtTalepleri.TabIndex = 6;
            this.lblYakıtTalepleri.Text = "Yakıt Talepleri";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(12, 574);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(49, 13);
            this.lblPersonel.TabIndex = 7;
            this.lblPersonel.Text = "Personel";
            // 
            // SubeYoneticiEkrani
            // 
            this.ClientSize = new System.Drawing.Size(800, 760);
            this.Controls.Add(this.lblPersonel);
            this.Controls.Add(this.lblYakıtTalepleri);
            this.Controls.Add(this.lblYakitStok);
            this.Controls.Add(this.lblSubePerformansi);
            this.Controls.Add(this.dataGridViewPersonel);
            this.Controls.Add(this.dataGridViewYakıtTalepleri);
            this.Controls.Add(this.dataGridViewYakitStok);
            this.Controls.Add(this.dataGridViewSubePerformansi);
            this.Name = "SubeYoneticiEkrani";
            this.Text = "Şube Yönetici Ekranı";
            this.Load += new System.EventHandler(this.SubeYoneticiEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubePerformansi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYakitStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYakıtTalepleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
