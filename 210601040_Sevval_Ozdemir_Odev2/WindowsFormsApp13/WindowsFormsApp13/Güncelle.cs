using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp13
{
    public partial class Güncelle : Form
    {
        public Güncelle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=ders;User ID=postgres;password=Seval802");

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update dersbilgi set dersadı = @p2 ,kredi = @p3,akts = @p4,öğretimüyesi = @p5 ,dönemi = @p6 where derskodu = @p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", derskodu.Text);
            komut3.Parameters.AddWithValue("@p2", dersadı.Text);
            komut3.Parameters.AddWithValue("@p3", int.Parse(kredi.Text));
            komut3.Parameters.AddWithValue("@p4", int.Parse(akts.Text));
            komut3.Parameters.AddWithValue("@p5", öğretimüyesi.Text);
            komut3.Parameters.AddWithValue("@p6", dönemi.Text);
            komut3.ExecuteNonQuery();
           
            MessageBox.Show("güncelleme basarılı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from dersbilgi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.ShowDialog();
        }
    }
}
