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
    public partial class Sil : Form
    {
        public Sil()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=ders;User ID=postgres;password=Seval802");

        private void Sil_Load(object sender, EventArgs e)
        {

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from dersbilgi where derskodu=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", derskodu.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("silme basarılı","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select*from dersbilgi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Form1 geri = new Form1();
            geri.ShowDialog();
        }
    }
}
