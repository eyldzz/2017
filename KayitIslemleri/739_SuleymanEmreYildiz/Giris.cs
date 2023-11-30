using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _739_SuleymanEmreYildiz
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VeriTabani.accdb");
        OleDbCommand komut;
        OleDbDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label3.Text = "Boş Bırakmayın";
            }
            else
            {
                baglanti.Open();
                komut = new OleDbCommand("select * from kullanici where kullaniciadi='" + textBox1.Text + "' and sifre='" + textBox2.Text + "' ", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    AnaMenu frm = new AnaMenu();
                    frm.Show();
                    this.Hide();
                }
                else
                { label3.Text = "Yanlış Kullanıcı Adı veya Şifre!!"; }
            }
            baglanti.Close();
        }

    }
}
