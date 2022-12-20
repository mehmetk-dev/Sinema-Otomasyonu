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
    public partial class Satış_Listele : Form
    {
        public Satış_Listele()
        {
            InitializeComponent();
        }
        void cevir()
        {
            button1.Text = Localization.tümsatış;
            this.Text = Localization.satislistele;
        }
        private void ToplamUcrethHesapla()
        {
            try
            {
                int ucrettoplam = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    ucrettoplam += Convert.ToInt32(dataGridView1.Rows[i].Cells["ucret"].Value);
                }
                label1.Text = Localization.toplamsatış+ " " + ucrettoplam + "₺";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        sinemadbDataSetTableAdapters.satisbilgileriTableAdapter satislistesi = new sinemadbDataSetTableAdapters.satisbilgileriTableAdapter();
        private void Satış_Listele_Load(object sender, EventArgs e)
        {
            cevir();
            dataGridView1.DataSource = satislistesi.tarihegörelistele2(dateTimePicker1.Text);
            dataGridView1.DataSource = satislistesi.satışlistele2();
            try
            {
                ToplamUcrethHesapla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satislistesi.satışlistele2();
            ToplamUcrethHesapla();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satislistesi.tarihegörelistele2(dateTimePicker1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
