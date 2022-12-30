using Npgsql;
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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            Menu menu =new Menu();
            menu.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=db_eticaret; user ID=postgres; password=1");
        private void Listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select musteri.musteri_ad,musteri.musteri_soyad,musteribilgi.tel_no,musteribilgi.email,musteribilgi.tc from musteri\r\ninner join musteribilgi on musteri.id=musteribilgi.musteri_id\r\n";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu,baglanti);
            DataSet ds=new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource= ds.Tables[0];
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1=new NpgsqlCommand("insert into musteri (id,musteri_ad,musteri_soyad) values (@p1,@p2,@p3)", baglanti);
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into musteribilgi (id,tel_no,email,tc,adres_id,musteri_id) values (@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
            komut1.Parameters.AddWithValue("@p1",int.Parse(textBox6.Text));
            komut1.Parameters.AddWithValue("@p2", textBox1.Text);
            komut1.Parameters.AddWithValue("@p3", textBox2.Text);
            komut2.Parameters.AddWithValue("@p4", int.Parse(textBox6.Text));
            komut2.Parameters.AddWithValue("@p5", int.Parse(textBox3.Text));
            komut2.Parameters.AddWithValue("@p6", textBox4.Text);
            komut2.Parameters.AddWithValue("@p7", int.Parse(textBox5.Text));
            komut2.Parameters.AddWithValue("@p8", int.Parse(textBox6.Text));
            komut2.Parameters.AddWithValue("@p9", int.Parse(textBox6.Text));
            komut1.ExecuteNonQuery();
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Musteri Basarili Bir Sekilde Kaydedildi.");
        }

        private void Musteri_Load(object sender, EventArgs e)
        {

        }

        private void Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("Delete From musteri where id=@p1 ", baglanti);
            NpgsqlCommand komut4 = new NpgsqlCommand("Delete From musteribilgi where id=@p2", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(textBox6.Text));
            komut4.Parameters.AddWithValue("@p2", int.Parse(textBox6.Text));
            komut3.ExecuteNonQuery();
            komut4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün başarı ile silindi.");
        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("Update musteri set musteri_ad=@p1,musteri_soyad=@p2 where id=@p3", baglanti);
            NpgsqlCommand komut6 = new NpgsqlCommand("Update musteribilgi set tel_no=@p4,email=@p5,tc=@p6 where id=@p3", baglanti);
            komut5.Parameters.AddWithValue("@p1", textBox1.Text);
            komut5.Parameters.AddWithValue("@p2", textBox2.Text);
            komut6.Parameters.AddWithValue("@p4",int.Parse(textBox3.Text));
            komut6.Parameters.AddWithValue("@p5", textBox4.Text);
            komut6.Parameters.AddWithValue("@p6", int.Parse(textBox5.Text));
            komut5.Parameters.AddWithValue("@p3", int.Parse(textBox6.Text));
            komut6.Parameters.AddWithValue("@p3", int.Parse(textBox6.Text));
            komut5.ExecuteNonQuery(); komut6.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Musteri Basarili Bir Sekilde Güncelleni");
        }

        private void arama_Click(object sender, EventArgs e)
        {
            NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=db_eticaret; user ID=postgres; password=1");

            baglanti.Open();
            string sorgu = "Select * From musteri where musteri_ad like '%" + arama.Text + "%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
