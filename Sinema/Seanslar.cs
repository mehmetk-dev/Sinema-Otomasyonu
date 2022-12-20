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
    public partial class Seanslar : Form
    {
        public Seanslar()
        {
            InitializeComponent();
        }
        void cevir()
        {
            label1.Text = Localization.silinecekseansid;
            button1.Text = Localization.sil;
            this.Text = Localization.seans;
            dataGridView1.Columns[0].HeaderText = Localization.seansid;
            dataGridView1.Columns[1].HeaderText = Localization.filmadi;
            dataGridView1.Columns[2].HeaderText = Localization.salon;
            dataGridView1.Columns[3].HeaderText = Localization.tarih;
            dataGridView1.Columns[4].HeaderText = Localization.seans;

        }
        private void Seanslar_Load(object sender, EventArgs e)
        {
            cevir();
            // TODO: Bu kod satırı 'sinemadbDataSet1.seanslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // TODO: Bu kod satırı 'sinemadbDataSet2.seanslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seanslarTableAdapter1.Fill(this.sinemadbDataSet2.seanslar);
            // TODO: Bu kod satırı 'sinemadbDataSet.seanslar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // TODO: Bu kod satırı 'sinemadbDataSet.seanslar2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seanslar2TableAdapter.seansgetir(this.sinemadbDataSet.seanslar2);

            // TODO: Bu kod satırı 'sinemadbDataSet.seanslar1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.



        }

        private void button1_Click(object sender, EventArgs e)
        {
            kodlar k = new kodlar();
            k.seanssil(textBox1);
            this.seanslar2TableAdapter.seansgetir(this.sinemadbDataSet.seanslar2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
