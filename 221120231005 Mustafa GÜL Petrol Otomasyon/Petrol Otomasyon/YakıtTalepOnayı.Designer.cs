namespace Petrol_Otomasyon
{
    partial class YakıtTalepOnayı
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewYakıtTalepleri;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnReddet;

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
            dataGridViewYakıtTalepleri = new DataGridView();
            btnOnayla = new Button();
            btnReddet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewYakıtTalepleri).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewYakıtTalepleri
            // 
            dataGridViewYakıtTalepleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewYakıtTalepleri.Location = new Point(10, 11);
            dataGridViewYakıtTalepleri.Name = "dataGridViewYakıtTalepleri";
            dataGridViewYakıtTalepleri.Size = new Size(932, 413);
            dataGridViewYakıtTalepleri.TabIndex = 0;
            // 
            // btnOnayla
            // 
            btnOnayla.Location = new Point(327, 446);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(88, 28);
            btnOnayla.TabIndex = 1;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = true;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // btnReddet
            // 
            btnReddet.Location = new Point(536, 446);
            btnReddet.Name = "btnReddet";
            btnReddet.Size = new Size(88, 28);
            btnReddet.TabIndex = 2;
            btnReddet.Text = "Reddet";
            btnReddet.UseVisualStyleBackColor = true;
            btnReddet.Click += btnReddet_Click;
            // 
            // YakıtTalepOnayı
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 497);
            Controls.Add(btnReddet);
            Controls.Add(btnOnayla);
            Controls.Add(dataGridViewYakıtTalepleri);
            Name = "YakıtTalepOnayı";
            Text = "Yakıt Talep Onayı";
            Load += YakıtTalepOnayı_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewYakıtTalepleri).EndInit();
            ResumeLayout(false);
        }
    }
}
