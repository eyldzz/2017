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
    public partial class OduncAlVer : Form
    {
        public OduncAlVer()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
        OleDbCommand komut;
        OleDbDataReader dr;
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void OduncAlVer_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaMenu frm = new AnaMenu();
            frm.Show();
        }

        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox4.Text = "";
            pictureBox1.ImageLocation = "";
            pictureBox2.ImageLocation = "";
            label9.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(baglanti.State == ConnectionState.Closed)baglanti.Open();
            if (textBox1.Text == "")
            {
                textBox2.Clear();
                textBox3.Clear();
                pictureBox1.ImageLocation = "";
            }
            else
            {
                komut = new OleDbCommand("select * from Uyeler where UyeNo =" + int.Parse(textBox1.Text) + "", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr["UyeAdi"].ToString();
                    textBox3.Text = dr["UyeSoyadi"].ToString();
                    pictureBox1.ImageLocation = dr["ResimYolu"].ToString();
                }
                else
                {
                    textBox2.Clear();
                    textBox3.Clear();
                    pictureBox1.ImageLocation = "";
                    label9.Text = "Bu numaralı bir kayıt yok";
                }
            }
            baglanti.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox5.Clear();
                pictureBox2.ImageLocation = "";
            }
            else
            {
                baglanti.Open();
                komut = new OleDbCommand("select * from KitapBilgiler where KitapNo =" + int.Parse(textBox4.Text) + "", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    textBox5.Text = dr["KitapAdi"].ToString();
                    pictureBox2.ImageLocation = dr["VeriYolu"].ToString();

                }
                else
                {
                    textBox5.Clear();
                    pictureBox2.ImageLocation = "";
                    label9.Text = "Bu numaralı bir kitap yok";
                }
            }

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kitap ver
            baglanti.Open();
            if (textBox2.Text == "" || textBox5.Text == "")
            {
                label9.Text = "Lütfen bilgileri doğru girin";
            }
            else
            {
                komut = new OleDbCommand("select * from oduncalver where uyeno=" + int.Parse(textBox1.Text) + " and durumu='GETİRMEDİ'", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    label9.Text = "Bu üye daha önce aldığı kitabı getirmemiş";
                }
                else
                {
                    komut = new OleDbCommand("select * from KitapBilgiler where KitapNo = "+int.Parse(textBox4.Text)+"and KitapSayisi = 0", baglanti);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        label9.Text = "Bu kitaptan kütüphanede kalmamamıştır";
                    }
                    else
                    {
                        komut = new OleDbCommand("insert into oduncalver(kitabiverenkullanici,uyeno,kitapno,kitapveristarihi,durumu,kitapgerialimtarihi)values('" + kutuphane.Kullanici.kadi + "','" + int.Parse(textBox1.Text) + "','" + int.Parse(textBox4.Text) + "','" + dateTimePicker1.Value + "','" + "GETİRMEDİ" + "','" + dateTimePicker2.Value + "')", baglanti);
                        komut.ExecuteNonQuery();
                        komut = new OleDbCommand("update KitapBilgiler set KitapSayisi= KitapSayisi - 1 where KitapNo = " + int.Parse(textBox4.Text) + "", baglanti);
                        komut.ExecuteNonQuery();
                        Temizle();
                        label9.Text = "Kitap başarıyla teslim edildi";
                    }
                }
            
            }

            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kitap al
            baglanti.Open();
            if (textBox2.Text == "" || textBox5.Text == "")
            {
                label9.Text = "Lütfen bilgileri doğru girin";
            }
            else
            {
                komut = new OleDbCommand("select * from oduncalver where uyeno=" + int.Parse(textBox1.Text) + " and kitapno=" + int.Parse(textBox4.Text) + " and durumu='GETİRMEDİ'", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    komut = new OleDbCommand("update oduncalver set kitapgerialimtarihi='" + DateTime.Now + "', durumu ='GETİRDİ',kitabialankullanici='" + kutuphane.Kullanici.kadi + "' where uyeno=" + int.Parse(textBox1.Text) + " and kitapno=" + int.Parse(textBox4.Text) + "", baglanti);
                    komut.ExecuteNonQuery();
                    komut = new OleDbCommand("update KitapBilgiler set KitapSayisi= KitapSayisi+1 where KitapNo=" + int.Parse(textBox4.Text) + "", baglanti);
                    komut.ExecuteNonQuery();
                    Temizle();
                    label9.Text = "Kitap başarıyla teslim alındı"; 
                }
                else
                {
                    label9.Text = "Bu üye bu kitabı almamıştır";
                }
            }
            baglanti.Close();
        }

        /*  Bütün Verilen Kitaplar
            Elinde Kitap Olan Üyeler
            Daha Önce Kitap Alıp Geri Getirenler
            Geri Teslim Zamanı Geçenler
            Üye No
            Kitap No
        */

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (comboBox4.Text != "")
            {
                ds.Clear();
                label9.Text = "";
                if (comboBox4.Text == "Bütün Verilen Kitaplar")
                {
                        da = new OleDbDataAdapter("select oduncalver.kitabiverenkullanici,Uyeler.UyeNo,Uyeler.UyeAdi,Uyeler.UyeSoyadi,Uyeler.Sinif,Uyeler.Tel,KitapBilgiler.KitapNo,KitapBilgiler.KitapAdi,oduncalver.kitapveristarihi,oduncalver.kitapgerialimtarihi,oduncalver.durumu,oduncalver.kitabialankullanici from oduncalver,Uyeler,KitapBilgiler where oduncalver.uyeno=Uyeler.UyeNo and oduncalver.kitapno=KitapBilgiler.KitapNo", baglanti);
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else if (comboBox4.Text == "Elinde Kitap Olan Üyeler")
                {
                    da = new OleDbDataAdapter("select oduncalver.kitabiverenkullanici,Uyeler.UyeNo,Uyeler.UyeAdi,Uyeler.UyeSoyadi,Uyeler.Sinif,Uyeler.Tel,KitapBilgiler.KitapNo,KitapBilgiler.KitapAdi,oduncalver.kitapveristarihi,oduncalver.kitapgerialimtarihi,oduncalver.durumu,oduncalver.kitabialankullanici from oduncalver,Uyeler,KitapBilgiler where oduncalver.uyeno=Uyeler.UyeNo and oduncalver.kitapno=KitapBilgiler.KitapNo and oduncalver.durumu='GETİRMEDİ'", baglanti);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else if (comboBox4.Text == "Daha Önce Kitap Alıp Geri Getirenler")
                {
                    da = new OleDbDataAdapter("select oduncalver.kitabiverenkullanici,Uyeler.UyeNo,Uyeler.UyeAdi,Uyeler.UyeSoyadi,Uyeler.Sinif,Uyeler.Tel,KitapBilgiler.KitapNo,KitapBilgiler.KitapAdi,oduncalver.kitapveristarihi,oduncalver.kitapgerialimtarihi,oduncalver.durumu,oduncalver.kitabialankullanici from oduncalver,Uyeler,KitapBilgiler where oduncalver.uyeno=Uyeler.UyeNo and oduncalver.kitapno=KitapBilgiler.KitapNo and oduncalver.durumu='GETİRDİ'", baglanti);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else if (comboBox4.Text == "Geri Teslim Zamanı Geçenler")
                {
                    da = new OleDbDataAdapter("select oduncalver.kitabiverenkullanici,Uyeler.UyeNo,Uyeler.UyeAdi,Uyeler.UyeSoyadi,Uyeler.Sinif,Uyeler.Tel,KitapBilgiler.KitapNo,KitapBilgiler.KitapAdi,oduncalver.kitapveristarihi,oduncalver.kitapgerialimtarihi,oduncalver.durumu,oduncalver.kitabialankullanici from oduncalver,Uyeler,KitapBilgiler where oduncalver.uyeno=Uyeler.UyeNo and oduncalver.kitapno=KitapBilgiler.KitapNo and oduncalver.kitapgerialimtarihi>" + DateTime.Now + "", baglanti);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else if (comboBox4.Text == "Üye No")
                {
                    da = new OleDbDataAdapter("select oduncalver.kitabiverenkullanici,Uyeler.UyeNo,Uyeler.UyeAdi,Uyeler.UyeSoyadi,Uyeler.Sinif,Uyeler.Tel,KitapBilgiler.KitapNo,KitapBilgiler.KitapAdi,oduncalver.kitapveristarihi,oduncalver.kitapgerialimtarihi,oduncalver.durumu,oduncalver.kitabialankullanici from oduncalver,Uyeler,KitapBilgiler where oduncalver.uyeno=Uyeler.UyeNo and oduncalver.kitapno=KitapBilgiler.KitapNo and ", baglanti);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else if (comboBox4.Text == "Kitap No")
                {
                    da = new OleDbDataAdapter("select oduncalver.kitabiverenkullanici,Uyeler.UyeNo,Uyeler.UyeAdi,Uyeler.UyeSoyadi,Uyeler.Sinif,Uyeler.Tel,KitapBilgiler.KitapNo,KitapBilgiler.KitapAdi,oduncalver.kitapveristarihi,oduncalver.kitapgerialimtarihi,oduncalver.durumu,oduncalver.kitabialankullanici from oduncalver,Uyeler,KitapBilgiler where oduncalver.uyeno=Uyeler.UyeNo and oduncalver.kitapno=KitapBilgiler.KitapNo and oduncalver.kitapgerialimtarihi>'" + DateTime.Now + "'", baglanti);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            else
            {


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
