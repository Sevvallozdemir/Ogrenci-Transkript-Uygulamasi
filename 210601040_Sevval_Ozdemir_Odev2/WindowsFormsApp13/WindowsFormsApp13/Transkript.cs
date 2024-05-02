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
using Npgsql;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace WindowsFormsApp13
{
    public partial class Transkript : Form
    {
        public Transkript()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=ders;User ID=postgres;password=Seval802");

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
            NpgsqlCommand komut5 = new NpgsqlCommand("select dersbilgi where harfnotu=@p7");

            baglanti.Open();




            if (harfnotutext.Text == "AA")
            {
                MessageBox.Show("gano 4.00");
            }
            else if (harfnotutext.Text == "BA") 
            {
                MessageBox.Show("gano 3.50");
            } 
            else if (harfnotutext.Text == "BB")
            {
                MessageBox.Show("gano 3.00");
            }
            else if (harfnotutext.Text == "CB")
            {
                MessageBox.Show("gano 2.50");
            }
            else if (harfnotutext.Text == "CC")
            {
                MessageBox.Show("gano 2.00");
            }
            else if (harfnotutext.Text == "DC")
            {
                MessageBox.Show("gano 1.50");
            }
            else if (harfnotutext.Text == "DD")
            {
                MessageBox.Show("gano 1.00");
            }
            else if(harfnotutext.Text == "FD")
            {
                MessageBox.Show("gano 0.50");
            }
            else (harfnotutext.Text == "FF")
            {
                MessageBox.Show("gano 0.00");
            }


        }
        public double harfnotu(string harfnotu)
        {
            double puan = 0;
            switch (harfnotu)
            {
                case "AA":
                   return  4;
                    

                case "BA":
                    return 3.50;
                    

                case "BB":
                    return 3;
                  
                case "CB":
                    return 2.50;
                   
                case "CC":
                   return 2.00;
                   
                case "DC":
                    return 1.50;
                    
                case "DD":
                    return  1.00;
                   
                case "FD":
                    return 0.50;
                    
                case "FF":
                   return 0.00;



                    return 0;
            }
        }
        public int toplam_kredi(object sender, EventArgs e)
        {
           


        }
}
