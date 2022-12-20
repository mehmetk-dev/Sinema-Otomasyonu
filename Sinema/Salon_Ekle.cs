using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sinema
{
    public partial class Salon_Ekle : Form
    {
        public Salon_Ekle()
        {
            InitializeComponent();
        }
        void cevir()
        {
            label1.Text = Localization.ekleneceksalonid;
            label2.Text = Localization.silineceksalonid;
            button3.Text = Localization.sil;
            button1.Text = Localization.ekle;
            this.Text = Localization.salonbilgileri;
        }
        DataSet1TableAdapters.salonbilgileriTableAdapter salonekleme = new DataSet1TableAdapters.salonbilgileriTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                salonekleme.salonekle(salontxt.Text);
                MessageBox.Show(Localization.saloneklendi,Localization.kayıt);
                salontxt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hataa + ex.Message,Localization.hataa);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salon_Ekle_Load(object sender, EventArgs e)
        {
            cevir();
            // TODO: Bu kod satırı 'sinemadbDataSet1.salonlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.salonlarTableAdapter.Fill(this.sinemadbDataSet1.salonlar);
            // TODO: Bu kod satırı 'sinemadbDataSet.salonbilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.salonbilgileriTableAdapter1.Fill(this.sinemadbDataSet.salonbilgileri);
            // TODO: Bu kod satırı 'dataSet1.salonbilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.salonbilgileriTableAdapter.salonbilgileri(this.dataSet1.salonbilgileri);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kodlar kf = new kodlar();
            kf.salonsil(textBox1);
            this.salonbilgileriTableAdapter.salonbilgileri(this.dataSet1.salonbilgileri);

        }
    }
}
