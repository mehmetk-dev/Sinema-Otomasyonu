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
    public partial class Seans_Ekle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=sinemadb;Integrated Security=True");

        public Seans_Ekle()
        {
            InitializeComponent();
        }
        void cevir()
        {
            label1.Text = Localization.film;
            label2.Text = Localization.salon;
            label3.Text = Localization.tarih;
            button1.Text = Localization.seansekle;
            this.Text = Localization.seansekle;
        }
        string seans = "";
        public void RadioButtonSeçiliyse()
        {
            if (radioButton1.Checked == true) seans = radioButton1.Text;
            else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;
            else if (radioButton7.Checked == true) seans = radioButton7.Text;
            else if (radioButton8.Checked == true) seans = radioButton8.Text;
            else if (radioButton9.Checked == true) seans = radioButton9.Text;
            else if (radioButton10.Checked == true) seans = radioButton10.Text;
            else if (radioButton11.Checked == true) seans = radioButton11.Text;
            else if (radioButton12.Checked == true) seans = radioButton12.Text;
        }

        private void Seans_Ekle_Load(object sender, EventArgs e)
        {
            cevir();
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();            // TODO: Bu kod satırı 'sinemadbDataSet1.salonlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.salonlarTableAdapter.Fill(this.sinemadbDataSet1.salonlar);
            // TODO: Bu kod satırı 'sinemadbDataSet1.filmbilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmbilgileriTableAdapter.Fill(this.sinemadbDataSet1.filmbilgileri);
            TarihKarşılaştır();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control item3 in groupBox1.Controls)
            {
                item3.Enabled = true;
            }
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTimePicker1.Text);
            if (yeni == bugün)
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }
                TarihKarşılaştır();
            }
            else if (yeni > bugün)
            {
                TarihKarşılaştır();
            }
            else if (yeni < bugün)
            {
                MessageBox.Show(Localization.geriyedonukislem,Localization.hataa);
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            }
        }
        sinemadbDataSetTableAdapters.seanslar1TableAdapter seansekle = new sinemadbDataSetTableAdapters.seanslar1TableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            RadioButtonSeçiliyse();
            if (seans != "" && comboBox1.Text!="" && comboBox2.Text!="")
            {
                seansekle.seansekleem(comboBox1.Text, comboBox2.Text, dateTimePicker1.Text, seans);
                MessageBox.Show(Localization.seanseklemebasarili,Localization.kayıt);
            }
            else if (seans == "")
            {
                MessageBox.Show(Localization.seanssecimiyapmadın,Localization.hataa);
            }
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TarihKarşılaştır()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from seanslar where salonAdı='" + comboBox2.Text + "' and tarih='" + dateTimePicker1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                foreach (Control item2 in groupBox1.Controls)
                {
                    if (read["seans"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;
                    }
                }
            }
            baglanti.Close();
        }
    }
}
