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


namespace WindowsFormsApp13
{
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=ders;User ID=postgres;password=Seval802");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into dersbilgi(derskodu,dersadı,kredi,akts,öğretimüyesi,dönemi,harfnotu) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            komut1.Parameters.AddWithValue("@p1", derskodu.Text);
            komut1.Parameters.AddWithValue("@p2", dersadı.Text);
            komut1.Parameters.AddWithValue("@p3", int.Parse(kredi.Text));
            komut1.Parameters.AddWithValue("@p4", int.Parse(akts.Text));
            komut1.Parameters.AddWithValue("@p5", öğretimüyesi.Text);
            komut1.Parameters.AddWithValue("@p6", dönemi.Text);
            komut1.Parameters.AddWithValue("@p7", harfnotu.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("başarılı");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from dersbilgi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Ekle_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 gerigeri = new Form1();
            gerigeri.Show();

        }
    }
}
