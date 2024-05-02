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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=ders;User ID=postgres;password=Seval802");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from dersbilgi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Ekle ekle = new Ekle();
            ekle.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sil ekle = new Sil();
            ekle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Güncelle buton = new Güncelle();
            buton.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transkript tıkla = new Transkript();
            tıkla.Show();
        }
    }
}
