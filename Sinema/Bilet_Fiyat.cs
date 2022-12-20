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
    public partial class Bilet_Fiyat : Form
    {
        public Bilet_Fiyat()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=sinemadb;Integrated Security=True");

        void cevir()
        {
            label1.Text = Localization.tambilet;
            label2.Text = Localization.ogrenci;
            button1.Text = Localization.guncelle;
            label3.Text = Localization.biletfiyat;
            this.Text = Localization.biletfiyat;
        }
        private void Bilet_Fiyat_Load(object sender, EventArgs e)
        {
            cevir();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from bilet_fiyatları where ad='Tam'", baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            if (rd.Read())
            {
                textBox1.Text = rd["ücret"]+ '₺'.ToString();
                rd.Close();
            }
            SqlCommand komut1 = new SqlCommand("select * from bilet_fiyatları where ad='Öğrenci'", baglanti);
            SqlDataReader rd1 = komut1.ExecuteReader();
            if (rd1.Read())
            {
                textBox2.Text = rd1["ücret"]+ '₺'.ToString();
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kodlar k = new kodlar();
            k.fiyatgüncelle(textBox1.Text, "Tam");
            k.fiyatgüncelle(textBox2.Text, "Öğrenci");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
