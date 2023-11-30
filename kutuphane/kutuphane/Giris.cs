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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
        OleDbCommand komut;
        OleDbDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label1.Text = "Boş Bırakmayın";
            }
            else
            {
                kutuphane.Kullanici.kadi = textBox1.Text;
                kutuphane.Kullanici.sifree = textBox2.Text;
                komut = new OleDbCommand("select * from kullanici where kullaniciadi='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    AnaMenu frm = new AnaMenu();

                    if (dr["Yetki"].ToString() == "Yonetici")
                    {
                        frm.btnKullaniciAyarlari.Enabled = true;
                    }
                    else
                    {
                        frm.btnKullaniciAyarlari.Enabled = false;
                    }
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    label1.Text = "Kullanıcı adı veya şifre yanlış!!";
                }
            }
            baglanti.Close();
        } 
    }
}
