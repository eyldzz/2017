using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class KullaniciAyarlari : Form
    {
        public KullaniciAyarlari()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
        OleDbCommand komut;
        OleDbDataReader dr;
  
        private void KullaniciAyarlari_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaMenu frm = new AnaMenu();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new OleDbCommand("select * from kullanici where kullaniciadi='" + textBox1.Text + "'", baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label4.Text = "Bu kullanıcı adı zaten kullanılmakta";
            }
            else
            {
                if (textBox2.Text == textBox3.Text)
                {
                    komut = new OleDbCommand("insert into kullanici(kullaniciadi,sifre) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    label4.Text = "Kayıt Tamamlandı";
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                    label4.Text = "Şifreler Aynı Değil!!";
            }
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (textBox1.Text == "")
            { label4.Text = "Kullanıcı Adı Girin"; }
            else
            {
                komut = new OleDbCommand("select * from kullanici where kullaniciadi='" + textBox1.Text + "'", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    komut = new OleDbCommand("delete from kullanici where kullaniciadi='" + textBox1.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    label4.Text = "Kayıt Silindi";
                }
                else
                    label4.Text = "Kullanıcı adı bulunamadı";
            }
            baglanti.Close();
        }
    }
}
