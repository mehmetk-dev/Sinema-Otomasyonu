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
    public partial class Film_Düzen : Form
    {
        public Film_Düzen()
        {
            InitializeComponent();
        }
        void cevir()
        {
            label2.Text = Localization.filmadi;
            label3.Text = Localization.yonetmen;
            label4.Text = Localization.filmtürü;
            label5.Text = Localization.filmsüresi;
            label6.Text = Localization.yapımyılı;
            Oyuncular.Text = Localization.oyuncular;
            textBox7.Text = Localization.özet;
            groupBox1.Text = Localization.filmbilgileri;
            label1.Text = Localization.silfilm;
            button1.Text = Localization.sil;
            button2.Text = Localization.bilgileriguncelle;
            button3.Text = Localization.afişekle;
            this.Text = Localization.filmbilgileri;
            dataGridView1.Columns[1].HeaderText = Localization.filmadi;
            dataGridView1.Columns[0].HeaderText = Localization.filmid;
        }
        private void Film_Düzen_Load(object sender, EventArgs e)
        {
            cevir();
            // TODO: Bu kod satırı 'dataSet1.filmbilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmbilgileriTableAdapter.filmbilgileri(this.dataSet1.filmbilgileri);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.filmbilgileriTableAdapter.filmbilgileri(this.dataSet1.filmbilgileri);
            DialogResult secenek = MessageBox.Show(Localization.islemyap, Localization.dikkat, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                kodlar kf = new kodlar();
                kf.filmsil(siltxt);
                this.filmbilgileriTableAdapter.filmbilgileri(this.dataSet1.filmbilgileri);

            }
            else if (secenek == DialogResult.No)
            {
                MessageBox.Show(Localization.silmeptal);
            }

        }
        string filmId;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.filmbilgileriTableAdapter.filmbilgileri(this.dataSet1.filmbilgileri);
            filmId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            SqlConnection baglanti = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=sinemadb;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from filmbilgileri where filmId='" + filmId + "'", baglanti);
            SqlDataReader bilgi = komut.ExecuteReader();
            if (bilgi.Read())
            {
                textBox1.Text = bilgi["filmAdı"].ToString();
                textBox2.Text = bilgi["yonetmen"].ToString();
                pictureBox1.ImageLocation = bilgi["resim"].ToString();
                textBox3.Text = bilgi["filmTuru"].ToString();
                textBox4.Text = bilgi["filmSuresi"].ToString();
                textBox5.Text = bilgi["vizyontarih"].ToString();
                txtozet.Text = bilgi["ozet"].ToString();
                textBox7.Text = bilgi["oyuncular"].ToString();
                siltxt.Text = filmId;

            }
            baglanti.Close();
        }
        DataSet1TableAdapters.filmbilgileriTableAdapter filmgüncelle1 = new DataSet1TableAdapters.filmbilgileriTableAdapter();
        private void button2_Click(object sender, EventArgs e)
        {
            kodlar k = new kodlar();
            k.filmguncelle(filmId, pictureBox1.ImageLocation, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,textBox7.Text,txtozet.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
