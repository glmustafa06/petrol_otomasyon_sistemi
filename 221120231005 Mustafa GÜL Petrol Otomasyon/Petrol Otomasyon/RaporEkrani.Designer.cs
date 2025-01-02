namespace Petrol_Otomasyon
{
    partial class RaporEkrani
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewYakıtTalepleri;
        private System.Windows.Forms.DataGridView dataGridViewIslemler;
        private System.Windows.Forms.DataGridView dataGridViewSubePerformans;
        private System.Windows.Forms.Label lblYakıtTalepleri;
        private System.Windows.Forms.Label lblIslemler;
        private System.Windows.Forms.Label lblSubePerformans;

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
            this.dataGridViewYakıtTalepleri = new System.Windows.Forms.DataGridView();
            this.dataGridViewIslemler = new System.Windows.Forms.DataGridView();
            this.dataGridViewSubePerformans = new System.Windows.Forms.DataGridView();
            this.lblYakıtTalepleri = new System.Windows.Forms.Label();
            this.lblIslemler = new System.Windows.Forms.Label();
            this.lblSubePerformans = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYakıtTalepleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslemler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubePerformans)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewYakıtTalepleri
            // 
            this.dataGridViewYakıtTalepleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYakıtTalepleri.Location = new System.Drawing.Point(12, 35);
            this.dataGridViewYakıtTalepleri.Name = "dataGridViewYakıtTalepleri";
            this.dataGridViewYakıtTalepleri.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewYakıtTalepleri.TabIndex = 0;
            // 
            // dataGridViewIslemler
            // 
            this.dataGridViewIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIslemler.Location = new System.Drawing.Point(12, 220);
            this.dataGridViewIslemler.Name = "dataGridViewIslemler";
            this.dataGridViewIslemler.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewIslemler.TabIndex = 1;
            // 
            // dataGridViewSubePerformans
            // 
            this.dataGridViewSubePerformans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubePerformans.Location = new System.Drawing.Point(12, 405);
            this.dataGridViewSubePerformans.Name = "dataGridViewSubePerformans";
            this.dataGridViewSubePerformans.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewSubePerformans.TabIndex = 2;
            // 
            // lblYakıtTalepleri
            // 
            this.lblYakıtTalepleri.AutoSize = true;
            this.lblYakıtTalepleri.Location = new System.Drawing.Point(12, 17);
            this.lblYakıtTalepleri.Name = "lblYakıtTalepleri";
            this.lblYakıtTalepleri.Size = new System.Drawing.Size(71, 13);
            this.lblYakıtTalepleri.TabIndex = 3;
            this.lblYakıtTalepleri.Text = "Yakıt Talepleri";
            // 
            // lblIslemler
            // 
            this.lblIslemler.AutoSize = true;
            this.lblIslemler.Location = new System.Drawing.Point(12, 204);
            this.lblIslemler.Name = "lblIslemler";
            this.lblIslemler.Size = new System.Drawing.Size(41, 13);
            this.lblIslemler.TabIndex = 4;
            this.lblIslemler.Text = "İşlemler";
            // 
            // lblSubePerformans
            // 
            this.lblSubePerformans.AutoSize = true;
            this.lblSubePerformans.Location = new System.Drawing.Point(12, 389);
            this.lblSubePerformans.Name = "lblSubePerformans";
            this.lblSubePerformans.Size = new System.Drawing.Size(85, 13);
            this.lblSubePerformans.TabIndex = 5;
            this.lblSubePerformans.Text = "Şube Performansı";
            // 
            // RaporEkrani
            // 
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.lblSubePerformans);
            this.Controls.Add(this.lblIslemler);
            this.Controls.Add(this.lblYakıtTalepleri);
            this.Controls.Add(this.dataGridViewSubePerformans);
            this.Controls.Add(this.dataGridViewIslemler);
            this.Controls.Add(this.dataGridViewYakıtTalepleri);
            this.Name = "RaporEkrani";
            this.Text = "Rapor Ekranı";
            this.Load += new System.EventHandler(this.RaporEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYakıtTalepleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslemler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubePerformans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
