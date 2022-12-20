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
using System.Globalization;
using System.Threading;
using System.Reflection.Emit;


namespace Sinema
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=sinemadb;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            Cevir();
        }

        void Cevir()
        {
            label1.Text = Localization.username;
            label2.Text = Localization.password;
            Button1.Text = Localization.login;
            dilSeçimiToolStripMenuItem.Text = Localization.menu;
            label3.Text = Localization.baslik;
            this.Text = Localization.dil;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (kullaniciaditxt.Text!="" && sifretxt.Text!="")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from uyeler1 where kullanıcıadı='" + kullaniciaditxt.Text + "'", baglanti);
                SqlDataReader rd = komut.ExecuteReader();
                if (rd.Read())
                {
                    if (rd["sifre"].ToString() == sifretxt.Text)
                    {
                        if (rd["uyetip"].ToString() == "2")
                        {
                            this.Hide();
                            Bilet_Sat bs = new Bilet_Sat();
                            bs.Show();
                            
                        }
                        else if (rd["uyetip"].ToString() == "3")
                        {
                            this.Hide();
                            Yönetici_Ekranı yönetici = new Yönetici_Ekranı();
                            yönetici.Show();
                           
                        }
                    }
                    else
                    {
                        MessageBox.Show(Localization.uyari, Localization.hataa);
                    }
                }
                else
                {
                    MessageBox.Show(Localization.uyari,Localization.hataa);
                }
                baglanti.Close(); 
            }
            else
            {
                MessageBox.Show(Localization.hata, Localization.hataa);
            }
        }

        private void ingilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("en-US");
            Cevir();
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("tr-TR");
            Cevir();
        }
    }
}
