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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            Menu menu= new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
