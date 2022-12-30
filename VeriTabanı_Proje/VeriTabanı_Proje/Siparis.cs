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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }


        private void Cikis_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Siparis_Load(object sender, EventArgs e)
        {

        }
    }
}
