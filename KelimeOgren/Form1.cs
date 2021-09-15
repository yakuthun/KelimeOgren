using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
// geliştir
namespace KelimeOgren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\yakut\Desktop\dbSozluk.accdb");
            Random rast = new Random();
        int sure = 30;
        public int kelime = 0;
        int dogruCevap = 0;
        void getir()
        {
            int sayi;
            sayi = rast.Next(1, 2490);
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBoxIngilizce.Text = dr[1].ToString();
                labelCevap.Text = dr[2].ToString();
                labelCevap.Text = labelCevap.Text.ToLower();
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            textBoxTurkce.Focus();
            timer1.Start();
        }

        private void textBoxTurkce_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTurkce.Text == labelCevap.Text)
            {
                kelime++;
                labelKelime.Text = kelime.ToString();
                getir();
                textBoxTurkce.Clear();
                labelCevap.Visible = false;
                dogruCevap++;
                labelDogru.Text = dogruCevap.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            labelSure.Text = sure.ToString();
            if (sure == 0)
            {
                textBoxTurkce.Enabled = false;
                textBoxIngilizce.Enabled = false;
                timer1.Stop();
            }
        }
        public int bakilan = 0;
        public int gecilen = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            labelCevap.Visible = true;
            bakilan++;
            labelBakilan.Text = bakilan.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kelime++;
            getir();
            gecilen++;
            labelGecilen.Text = gecilen.ToString();
        }
    }
}
