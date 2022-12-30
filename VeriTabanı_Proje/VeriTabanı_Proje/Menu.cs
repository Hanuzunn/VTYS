using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabanı_Proje
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Satis_Click(object sender, EventArgs e)
        {
            Satis Satis =new Satis();
            Satis.Show();
            this.Hide();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Siparis_Click(object sender, EventArgs e)
        {
            Siparis siparis =new Siparis();
            siparis.Show();
            this.Hide();
        }

        private void Rapor_Click(object sender, EventArgs e)
        {
            Rapor rapor =new Rapor();
            rapor.Show();
            this.Hide();
        }

        private void Musteri_Click(object sender, EventArgs e)
        {
            Musteri musteri=new Musteri(); 
            musteri.Show();
            this.Hide();
        }

        private void Urunler_Click(object sender, EventArgs e)
        {
            Urunler urunler =new Urunler();
            urunler.Show();
            this.Hide();
        }
    }
}
