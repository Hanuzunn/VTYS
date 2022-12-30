namespace VeriTabanı_Proje
{
    partial class Menu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Satis = new System.Windows.Forms.Button();
            this.Siparis = new System.Windows.Forms.Button();
            this.Rapor = new System.Windows.Forms.Button();
            this.Musteri = new System.Windows.Forms.Button();
            this.Urunler = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Satis
            // 
            this.Satis.Location = new System.Drawing.Point(12, 12);
            this.Satis.Name = "Satis";
            this.Satis.Size = new System.Drawing.Size(78, 70);
            this.Satis.TabIndex = 0;
            this.Satis.Text = "Satis";
            this.Satis.UseVisualStyleBackColor = true;
            this.Satis.Click += new System.EventHandler(this.Satis_Click);
            // 
            // Siparis
            // 
            this.Siparis.Location = new System.Drawing.Point(96, 12);
            this.Siparis.Name = "Siparis";
            this.Siparis.Size = new System.Drawing.Size(78, 70);
            this.Siparis.TabIndex = 1;
            this.Siparis.Text = "Siparis";
            this.Siparis.UseVisualStyleBackColor = true;
            this.Siparis.Click += new System.EventHandler(this.Siparis_Click);
            // 
            // Rapor
            // 
            this.Rapor.Location = new System.Drawing.Point(180, 12);
            this.Rapor.Name = "Rapor";
            this.Rapor.Size = new System.Drawing.Size(78, 70);
            this.Rapor.TabIndex = 2;
            this.Rapor.Text = "Rapor";
            this.Rapor.UseVisualStyleBackColor = true;
            this.Rapor.Click += new System.EventHandler(this.Rapor_Click);
            // 
            // Musteri
            // 
            this.Musteri.Location = new System.Drawing.Point(12, 88);
            this.Musteri.Name = "Musteri";
            this.Musteri.Size = new System.Drawing.Size(78, 70);
            this.Musteri.TabIndex = 3;
            this.Musteri.Text = "Musteri";
            this.Musteri.UseVisualStyleBackColor = true;
            this.Musteri.Click += new System.EventHandler(this.Musteri_Click);
            // 
            // Urunler
            // 
            this.Urunler.Location = new System.Drawing.Point(96, 88);
            this.Urunler.Name = "Urunler";
            this.Urunler.Size = new System.Drawing.Size(78, 70);
            this.Urunler.TabIndex = 4;
            this.Urunler.Text = "Urunler";
            this.Urunler.UseVisualStyleBackColor = true;
            this.Urunler.Click += new System.EventHandler(this.Urunler_Click);
            // 
            // Cikis
            // 
            this.Cikis.Location = new System.Drawing.Point(180, 88);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(78, 70);
            this.Cikis.TabIndex = 5;
            this.Cikis.Text = "Cikis";
            this.Cikis.UseVisualStyleBackColor = true;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 194);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.Urunler);
            this.Controls.Add(this.Musteri);
            this.Controls.Add(this.Rapor);
            this.Controls.Add(this.Siparis);
            this.Controls.Add(this.Satis);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Satis;
        private System.Windows.Forms.Button Siparis;
        private System.Windows.Forms.Button Rapor;
        private System.Windows.Forms.Button Musteri;
        private System.Windows.Forms.Button Urunler;
        private System.Windows.Forms.Button Cikis;
    }
}

