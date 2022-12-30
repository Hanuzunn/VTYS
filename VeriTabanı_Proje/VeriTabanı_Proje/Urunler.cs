using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabanı_Proje
{
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            Menu menu= new Menu();
            menu.Show();
            this.Hide();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=db_eticaret; user ID=postgres; password=1");
        private void Urun_Ad_Click(object sender, EventArgs e)
        {

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
           baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into model (id,model_no,marka_id,fiyat) values (@p1,@p2,@p3,@p4)",baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", comboBox3.SelectedValue);
            komut.Parameters.AddWithValue("@p4",int.Parse(textBox4.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün kaydı başarılı bir şekilde gerçekleşti");
        }

        private void Listele_Click(object sender, EventArgs e)
        {
             string sorgu = "select model.id,kategori.kategori_adi,urun.urun_adi,marka.marka_adi,model.model_no,model.fiyat from kategori\r\ninner join urun on kategori.id=urun.kategori_id\r\ninner join marka on urun.id=marka.urun_id\r\ninner join model on marka.id=model.marka_id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu,baglanti);
            DataSet ds=new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource= ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from marka", baglanti);
            DataTable dt2 = new DataTable();           
            da2.Fill(dt2);
            comboBox3.DisplayMember = "marka_adi";
            comboBox3.ValueMember = "id";
            comboBox3.DataSource = dt2;
            baglanti.Close();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete From model where id=@p1 ", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün başarı ile silindi.");
        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("Update model set model_no=@p1,fiyat=@p2 where id=@p3", baglanti);
            komut3.Parameters.AddWithValue("@p1", textBox3.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(textBox4.Text));
            komut3.Parameters.AddWithValue("@p3", int.Parse(textBox1.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün başarı ile güncellendi");
        }
    }
}
