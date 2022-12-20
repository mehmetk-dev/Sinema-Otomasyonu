using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema
{
    internal class kodlar
    {
        SqlConnection baglanti = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=sinemadb;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        Yönetici_Ekranı yeni = new Yönetici_Ekranı();
        public SqlDataReader kullanıcı(TextBox kullanıcıadı, TextBox sifre)
        {

            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from dbo.uyeler1 where kullanıcıadı='" + kullanıcıadı.Text + "'";
            read = komut.ExecuteReader();
            if (read.Read() == true)
            {
                if (sifre.Text == read["sifre"].ToString())
                {
                    MessageBox.Show("Giriş Başarılı");
                    yeni.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Şifrenizi kontrol ediniz", "Hata1");
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz", "Hata2");
            }
            baglanti.Close();
            return read;
        }
        public void filmsil(TextBox id)
        {

            try
            {
                baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "delete from dbo.filmbilgileri where filmID='" + id.Text + "'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(Localization.filmsilindi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hataa + ex.Message,Localization.hataa);
            }
        }
        public void filmguncelle(string filmId,string resim, string filmadı, string yönetmen, string filmtürü, string filmsüresi, string filmyılı,string oyuncular,string ozet)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=sinemadb;Integrated Security=True");
                baglanti.Close();
                baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "update dbo.filmbilgileri set filmAdı='" + filmadı + "',resim='" + resim + "', yonetmen='" + yönetmen + "', filmTuru='" + filmtürü + "',filmSuresi='" + filmsüresi + "',vizyontarih='" + filmyılı + "',oyuncular='"+oyuncular+"',ozet='"+ozet+ "' where filmId='" + filmId + "'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(Localization.işlembaşarılı);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        public void salonsil(TextBox id)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "delete from dbo.salonbilgileri where salonID='" + id.Text + "'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(Localization.salonsilindi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hataa+ex.Message,Localization.hataa);
            }
        }
        public void seanssil(TextBox id)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "delete from dbo.seanslar where seansID='" + id.Text + "'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(Localization.seanssilindi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hataa+ex.Message);
            }
        }
        public void fiyatgüncelle(string fiyat,string tip)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update bilet_fiyatları set ücret='" + fiyat + "'where ad='" + tip + "'", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show(Localization.fiyatguncellendi);
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Localization.hataa + ex.Message);
                throw;
            }

        }
    }
    
}