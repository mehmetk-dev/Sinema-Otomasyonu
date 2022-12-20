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
    public partial class personel_ekle : Form
    {
        public personel_ekle()
        {
            InitializeComponent();
        }
        void cevir()
        {
            label1.Text = Localization.username;
            label2.Text= Localization.password;
            label3.Text = Localization.personelekle;
            button1.Text = Localization.ekle;
            label10.Text = Localization.personelsil;
            label11.Text = Localization.silinecekpersonel;
            label5.Text = Localization.personelbilgileri;
            label6.Text = Localization.personelbilgi;
            label7.Text = Localization.adsoyad;
            label9.Text = Localization.username;
            label8.Text = Localization.password;
            button2.Text = Localization.guncelle;
            button3.Text = Localization.sil;
            this.Text = Localization.personelbilgileri;
            dataGridView1.Columns[0].HeaderText = Localization.uyeid;
            dataGridView1.Columns[1].HeaderText = Localization.adsoyad;
            dataGridView1.Columns[2].HeaderText = Localization.username;
            dataGridView1.Columns[3].HeaderText = Localization.password;

        }
        SqlConnection baglanti = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=sinemadb;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text=="")
            {
                MessageBox.Show(Localization.hata,Localization.hataa);
            }
            else
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into uyeler1(adsoyad,kullanıcıadı,sifre,uyetip) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','2')", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show(Localization.personeleklendi);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    baglanti.Close();
                    personelcek();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Localization.personeleklenemedi+ ex.Message,"Hata");
                    throw;
                }
            }
        }

        private void personel_ekle_Load(object sender, EventArgs e)
        {
            cevir();
            try
            {
                personelcek();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        private void personelcek()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from uyeler1 where uyetip='2'", baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells["uyeid"].Value = rd["uyeid"];
                dataGridView1.Rows[index].Cells["adsoyad"].Value = rd["adsoyad"];
                dataGridView1.Rows[index].Cells["kullanıcıadı"].Value = rd["kullanıcıadı"];
                dataGridView1.Rows[index].Cells["sifre"].Value = rd["sifre"];
            }
            baglanti.Close();
        }
        string uyecek;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            uyecek = dataGridView1.Rows[e.RowIndex].Cells["uyeid"].Value.ToString();
            textBox7.Text = uyecek;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from uyeler1 where uyeid='" + uyecek + "'", baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            if (rd.Read())
            {
                textBox4.Text = rd["adsoyad"].ToString();
                textBox5.Text = rd["kullanıcıadı"].ToString();
                textBox6.Text = rd["sifre"].ToString();
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show(Localization.hata,Localization.hataa);
                }
                else
                {
                    dataGridView1.Rows.Clear();
                    SqlCommand komut = new SqlCommand("update uyeler1 set adsoyad='" + textBox4.Text + "',kullanıcıadı='" + textBox5.Text + "',sifre='" + textBox6.Text + "' where uyeid='"+uyecek+"'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show(Localization.bilgilerguncellendi);
                    personelcek();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hataa + ex.Message,Localization.hataa);
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from uyeler1 where uyeid='" + textBox7.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show(Localization.personelsilindi);
                baglanti.Close();
                dataGridView1.Rows.Clear();
                personelcek();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.personelsilinemedi+ ex.Message,Localization.hataa);
                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    }

