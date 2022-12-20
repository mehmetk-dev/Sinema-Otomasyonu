using Sinema.sinemadbDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Sinema
{
    public partial class Bilet_Sat : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=sinemadb;Integrated Security=True");
        SqlConnection baglanti2 = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=sinemadb;Integrated Security=True");

        public Bilet_Sat()
        {
            InitializeComponent();
        }
        void cevir()
        {
            label2.Text = Localization.filmadi;
            label6.Text = Localization.salonno;
            label3.Text = Localization.filmtarihi;
            label4.Text = Localization.seans;
            label5.Text = Localization.koltukno;
            label8.Text = Localization.bilettipi;
            label7.Text = Localization.ucret;
            label10.Text = Localization.adsoyad;
            button1.Text = Localization.biletsat;
            button3.Text = Localization.rezerveet;
            button2.Text = Localization.biletiptal;
            groupBox1.Text = Localization.biletsat;
            groupBox2.Text = Localization.biletiptal;
            this.Text = Localization.biletsatış;
            label1.Text = Localization.perde;
            label9.Text = Localization.koltukno;
        }
        private void FilmAfişGöster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from filmbilgileri where filmAdı='" + combofilmadi.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                pictureBox1.ImageLocation = read["resim"].ToString();
            }
            baglanti.Close();
        }
        private void Film_Tarihi_Getir()
        {
                combotarih.Text = "";
                comboseans.Text = "";
                combotarih.Items.Clear();
                comboseans.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from seanslar where filmAdı='" + combofilmadi.Text + "' and salonadı='" + combosalon.Text + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    if (DateTime.Parse(read["tarih"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                    {
                        if (!combotarih.Items.Contains(read["tarih"].ToString()))
                        {
                            combotarih.Items.Add(read["tarih"].ToString());
                        }
                    }
                }
                baglanti.Close();
        }
        private void Film_Seansı_Getir()
        {
            baglanti.Open();
            comboseans.Text = "";
            comboseans.Items.Clear();
            SqlCommand komut = new SqlCommand("select * from seanslar where filmAdı='" + combofilmadi.Text + "' and salonAdı='" + combosalon.Text + "'and tarih='" + combotarih.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (DateTime.Parse(read["seans"].ToString()) > DateTime.Parse(DateTime.Now.ToShortTimeString()))
                    {
                        comboseans.Items.Add(read["seans"].ToString());

                    }
                }
                else if (DateTime.Parse(read["tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    comboseans.Items.Add(read["seans"].ToString());
                }
            }
            baglanti.Close();
        }

        public void DuzenKur()
        {
            int say = 0;
            panel1.Controls.Clear();
            int olcu = 38;
            for (int i = 0; i < txt_duzen.Lines.Count(); i++)
            {
                for (int j = 0; j < txt_duzen.Lines[i].Count(); j++)
                {
                    string satir = txt_duzen.Lines[i];
                    if (satir[j] == '*')
                    {
                        Button nesne = new Button();
                        nesne.Text = (++say).ToString();
                        nesne.Name = "buton_" + nesne.Text;
                        nesne.BackColor = Color.LightGreen;
                        nesne.Width = nesne.Height = 35;
                        nesne.Left = olcu * j;
                        nesne.Top = olcu * i;
                        panel1.Controls.Add(nesne);
                        nesne.Click += Btn_Click;
                    }
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (b.BackColor == Color.LightGreen)
            {
                koltukno.Text = b.Text;
            }
        }
        private void YenidenRenklendir()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.LightGreen;
                }
            }
        }

        private void Bilet_Sat_Load(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            cevir();
            rezervasyoniptal();
            YenidenRenklendir();
            // TODO: Bu kod satırı 'sinemadbDataSet4.bilet_fiyatları' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bilet_fiyatlarıTableAdapter.Fill(this.sinemadbDataSet4.bilet_fiyatları);
            // TODO: Bu kod satırı 'sinemadbDataSet2.filmbilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmbilgileriTableAdapter.Fill(this.sinemadbDataSet2.filmbilgileri);
            DuzenKur();
            filmvesalongetir(combofilmadi, "select * from filmbilgileri", "filmadı");
            filmvesalongetir(combosalon, "select * from salonbilgileri", "salonAdı");
        }

        private void combofilmadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            combotarih.Items.Clear();
            comboseans.Items.Clear();
            combotarih.Text = "";
            comboseans.Text = "";
            combosalon.Text = "";
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            FilmAfişGöster();
            YenidenRenklendir();
            Combo_Dolu_Koltuklar();
        }
        private void VeritabanıDoluKoltuklar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from satisbilgileri where filmAdı='" + combofilmadi.Text + "'and salonadı='" + combosalon.Text + "'and tarih='" + combotarih.Text + "' and saat='" + comboseans.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        if (read["koltukno"].ToString() == item.Text && read["dolubos"].ToString()=="1")
                        {
                            item.BackColor = Color.Red;
                        }
                        if (read["koltukno"].ToString() == item.Text && read["dolubos"].ToString() == "2")
                        {
                            item.BackColor = Color.Yellow;
                        }

                    }
                }
            }
            baglanti.Close();
        }

        private void combotarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Seansı_Getir();
        }

        private void combosalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Tarihi_Getir();
            YenidenRenklendir();
        }
        private void Combo_Dolu_Koltuklar()
        {
            comboBox6.Items.Clear();
            comboBox6.Text = "";

            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor == Color.Red)
                    {
                        comboBox6.Items.Add(item.Text);
                    }
                }
            }
        }

        private void comboseans_SelectedIndexChanged(object sender, EventArgs e)
        {
            YenidenRenklendir();
            VeritabanıDoluKoltuklar();
            Combo_Dolu_Koltuklar();
        }
        private void filmvesalongetir(ComboBox combo,string sql1,string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql1,baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                combo.Items.Add(rd[sql2].ToString());
            }
            baglanti.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fiyatbelirle();
        }

        private void fiyatbelirle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from bilet_fiyatları where ad='"+comboBox3.Text+"'", baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                ucret.Text = rd["ücret"].ToString();
            }
            baglanti.Close();
        }
        sinemadbDataSetTableAdapters.satisbilgileri1TableAdapter satis = new sinemadbDataSetTableAdapters.satisbilgileri1TableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            if (koltukno.Text!="" && combofilmadi.Text!="" && combosalon.Text!="" && comboseans.Text!="" && ucret.Text!="" && textBox1.Text!="")
            {
                try
                {
                    satis.satışyapyap(koltukno.Text, combosalon.Text, combofilmadi.Text, combotarih.Text, comboseans.Text, ucret.Text, DateTime.Now.ToShortDateString(), comboBox3.Text,textBox1.Text,"1");
                    MessageBox.Show(Localization.biletsatildi);
                    VeritabanıDoluKoltuklar();
                    foreach (Control item in groupBox1.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Localization.hataa + ex.Message, Localization.hataa);
                    throw; 
                }
            }
            else
            {
                MessageBox.Show(Localization.hata, Localization.hataa);
            }
        }

        sinemadbDataSetTableAdapters.satisbilgileriTableAdapter satiss = new satisbilgileriTableAdapter();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox6.Text != "")
                {
                    satiss.koltuksil(combofilmadi.Text, combosalon.Text, combotarih.Text, comboseans.Text, comboBox6.Text);
                    YenidenRenklendir();
                    VeritabanıDoluKoltuklar();
                    Combo_Dolu_Koltuklar();
                    MessageBox.Show(Localization.koltukiptalbasarili);
                }
                else
                {
                    MessageBox.Show(Localization.hata);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hataa + ex.Message,Localization.hataa);
                throw;
            }
        }
        sinemadbDataSetTableAdapters.satisbilgileri1TableAdapter satis2 = new satisbilgileri1TableAdapter();
        public void rezervasyoniptal()
        {
            baglanti.Open();
            baglanti2.Open();
            SqlCommand komut = new SqlCommand("select * from satisbilgileri where dolubos=2", baglanti2);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                DateTime yeni = DateTime.Parse(DateTime.Now.ToShortTimeString());
                yeni.AddHours(1);
                DateTime now= DateTime.Parse(dr["tarih2"].ToString());
                string satisid = dr["satisId"].ToString();
                if (yeni<now)
                {
                    SqlCommand komut2 = new SqlCommand("delete from satisbilgileri where satisId='"+satisid+"' ",baglanti);
                    komut2.ExecuteNonQuery();
                }
            }
            baglanti.Close();
            baglanti2.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (koltukno.Text != "" && combofilmadi.Text != "" && combosalon.Text != "" && comboseans.Text != "" && ucret.Text != "" && textBox1.Text != "")
            {
                try
                {
                    satis2.biletrezervasyon(koltukno.Text, combosalon.Text, combofilmadi.Text, combotarih.Text, comboseans.Text, ucret.Text, DateTime.Now.ToShortDateString(), comboBox3.Text, textBox1.Text,"2");
                    rezervasyoniptal();
                    YenidenRenklendir();
                    VeritabanıDoluKoltuklar();
                    Combo_Dolu_Koltuklar();
                    {
                        foreach (Control item2 in groupBox1.Controls)
                        {
                            if (item2 is TextBox)
                            {
                                item2.Text = "";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Localization.hataa+ ""+ ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show(Localization.hata);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
    }

