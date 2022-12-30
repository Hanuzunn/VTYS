namespace VeriTabanı_Proje
{
    partial class Siparis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Geri
            // 
            this.Geri.Location = new System.Drawing.Point(703, 414);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(87, 29);
            this.Geri.TabIndex = 0;
            this.Geri.Text = "Geri";
            this.Geri.UseVisualStyleBackColor = true;
            this.Geri.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // Siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 455);
            this.Controls.Add(this.Geri);
            this.Name = "Siparis";
            this.Text = "Siparis";
            this.Load += new System.EventHandler(this.Siparis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Geri;
    }
}