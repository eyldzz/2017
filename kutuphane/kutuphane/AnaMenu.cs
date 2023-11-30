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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
        OleDbCommand komut;
        OleDbDataReader dr;

        private void btnUyeIslemleri_Click(object sender, EventArgs e)
        {
            Uyeislemleri frm = new Uyeislemleri();
            frm.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnKitapIslemleri_Click(object sender, EventArgs e)
        {
            Kitapislemleri frm = new Kitapislemleri();
            frm.Show();
            this.Hide();
        }

        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            OduncAlVer frm = new OduncAlVer();
            frm.Show();
            this.Hide();
        }

        private void btnKullaniciAyarlari_Click(object sender, EventArgs e)
        {
            KullaniciAyarlari frm = new KullaniciAyarlari();
            frm.Show();
            this.Hide();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            
                komut = new OleDbCommand("select * from kullanici where kullaniciadi='" + kutuphane.Kullanici.kadi + "' and sifre='" + kutuphane.Kullanici.sifree + "'", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {

                    if (dr["Yetki"].ToString() == "Yonetici")
                    {
                        btnKullaniciAyarlari.Enabled = true;
                    }
                    else
                    {
                        btnKullaniciAyarlari.Enabled = false;
                    }
                }
                baglanti.Close();
        }
    }
}
