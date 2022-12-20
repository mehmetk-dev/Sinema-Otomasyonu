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

namespace Sinema
{
    public partial class Film_Göster : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=sinemadb;Integrated Security=True");

        public string id;

        public Film_Göster(string filmID)
        {
            InitializeComponent();
            this.id=filmID;
        }
        void cevir()
        {
            label1.Text = Localization.filmadi;
            label6.Text = Localization.oyuncular;
            label2.Text = Localization.yonetmen;
            label3.Text = Localization.filmtürü;
            label4.Text = Localization.filmsüresi;
            label5.Text = Localization.vizyontarih;
            label7.Text = Localization.özet;
        }
        private void Film_Göster_Load(object sender, EventArgs e)
        {
            cevir();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from filmbilgileri where filmId='" + this.id + "'", baglanti);
            SqlDataReader bilgi = komut.ExecuteReader();
            if (bilgi.Read())
            {
                textBox1.Text = bilgi["filmAdı"].ToString();
                pictureBox1.ImageLocation = bilgi["resim"].ToString();
                textBox2.Text = bilgi["yonetmen"].ToString();
                textBox3.Text = bilgi["filmTuru"].ToString();
                textBox4.Text = bilgi["filmSuresi"].ToString();
                textBox5.Text = bilgi["vizyontarih"].ToString();
                textBox6.Text = bilgi["oyuncular"].ToString();
                textBox7.Text = bilgi["ozet"].ToString();
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
