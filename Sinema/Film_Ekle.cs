using Sinema.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema
{
    public partial class Film_Ekle : Form
    {
        public Film_Ekle()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.filmbilgileriTableAdapter filmekle = new DataSet1TableAdapters.filmbilgileriTableAdapter();
        void cevir()
        {
            label1.Text = Localization.filmadi;
            label2.Text = Localization.yonetmen;
            label3.Text = Localization.filmtürü;
            label4.Text = Localization.filmsüresi;
            label5.Text = Localization.yapımyılı;
            label6.Text = Localization.oyuncular;
            Tarih.Text = Localization.vizyontarih;
            label8.Text = Localization.filmulke;
            label7.Text = Localization.özet;
            button1.Text = Localization.filmekle;
            button2.Text = Localization.afişekle;
            this.Text = Localization.filmekle;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picturebox.ImageLocation = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filmAdıtxt.Text != "" && yonetmentxt.Text != "" && comboBox1.Text != "" && suretxt.Text != "" && yiltxt.Text != "" && oyunculartxt.Text != "" && ozettxt.Text != "" && comboBox2.Text!="")
            {
                try
            {
                
                    filmekle.filmekle(filmAdıtxt.Text, yonetmentxt.Text, comboBox1.Text, suretxt.Text, yiltxt.Text, picturebox.ImageLocation, oyunculartxt.Text, ozettxt.Text,comboBox2.Text);
                    MessageBox.Show(Localization.eklendi,Localization.kayıt);
                    foreach (Control item in groupBox1.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = null;
                            comboBox1.Text = null;
                            picturebox.ImageLocation = null;
                        }
                    }
                }
            catch (Exception)
            {
                MessageBox.Show(Localization.eklenmedi,Localization.hataa);
                throw;
            } 
           
        }
            else
            {
                MessageBox.Show(Localization.hata,Localization.hataa);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Film_Ekle_Load(object sender, EventArgs e)
        {
            cevir();
        }

 
    }
}
