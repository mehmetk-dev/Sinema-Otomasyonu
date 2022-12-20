using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema
{
    public partial class Yönetici_Ekranı : Form
    {
        public Yönetici_Ekranı()
        {
            InitializeComponent();
        }
        void cevir()
        {
            button1.Text = Localization.filmekle;
            button3.Text = Localization.filmislem;
            label1.Text = Localization.vizyondakifilmler;
            groupBox1.Text = Localization.filmislem;
            groupBox2.Text = Localization.seanslar;
            button2.Text = Localization.seansekle;
            button5.Text = Localization.seanssil;
            groupBox3.Text = Localization.salon;
            button6.Text = Localization.saloneklevesil;
            groupBox4.Text = Localization.personel;
            button10.Text = Localization.personelislem;
            groupBox5.Text = Localization.bilet;
            button7.Text = Localization.biletfiyat;
            groupBox6.Text = Localization.satis;
            button8.Text = Localization.satislistele;
            button4.Text = Localization.filmlerilistele;
            button9.Text = Localization.oturumukapat;
            button11.Text = Localization.biletsat;
            dataGridView1.Columns[0].HeaderText = Localization.filmid;
            dataGridView1.Columns[1].HeaderText = Localization.filmadi;
            dataGridView1.Columns[2].HeaderText = Localization.yonetmen;
            dataGridView1.Columns[3].HeaderText = Localization.filmtürü;
            dataGridView1.Columns[4].HeaderText = Localization.filmsüresi;
            dataGridView1.Columns[5].HeaderText = Localization.yapımyılı;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Film_Ekle f= new Film_Ekle();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Film_Düzen fd = new Film_Düzen();
            fd.Show();
        }

        private void Yönetici_Ekranı_Load(object sender, EventArgs e)
        {
            cevir();
            // TODO: Bu kod satırı 'dataSet1.filmbilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmbilgileriTableAdapter.filmbilgileri(this.dataSet1.filmbilgileri);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.filmbilgileriTableAdapter.filmbilgileri(this.dataSet1.filmbilgileri);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Film_Göster filmGoster = new Film_Göster(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            filmGoster.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Seans_Ekle sekle = new Seans_Ekle();
            sekle.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Salon_Ekle salonekle = new Salon_Ekle();
            salonekle.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Seanslar seans = new Seanslar();
            seans.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            personel_ekle pekle = new personel_ekle();
            pekle.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bilet_Fiyat bf = new Bilet_Fiyat();
            bf.Show(); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Satış_Listele sl = new Satış_Listele();
            sl.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bilet_Sat biletsat = new Bilet_Sat();
            biletsat.Show();
        }
    }
}
