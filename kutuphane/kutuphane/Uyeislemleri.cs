using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace kutuphane
{
    public partial class Uyeislemleri : Form
    {
        public Uyeislemleri()
        {
            InitializeComponent();
        }
        private void DataGridCagir()
        { 
            ds.Clear();
            da = new OleDbDataAdapter("select * from Uyeler", baglanti);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                }
            }
        }
        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            label11.Text = "";
            pictureBox1.ImageLocation = "";
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
        OleDbCommand komut;
        OleDbDataReader dr;
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Uyeislemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaMenu frm = new AnaMenu();
            frm.Show();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string x;
            label11.Text = "";
            baglanti.Open();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                label11.Text = "Boş Bırakmayın";
            }
            else
            {
                 komut = new OleDbCommand("select * from Uyeler where UyeNo=" + int.Parse(textBox1.Text) + " or TcKimlik='" + textBox2.Text + "' or Eposta='" + textBox5.Text + "' or Tel='" + textBox6.Text + "' ", baglanti);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        label11.Text = "Uye numarasını, TC Kimlik numarasını, e-postayı ve telefonu kontrol edin";
                    }
                    else
                    {
                        if (pictureBox1.ImageLocation != "" && label12.Text != "")
                        {

                            if (File.Exists(@"UyeResimleri\" + "" + openFileDialog1.SafeFileName))
                            {
                                label11.Text = "Aynı isimde resim var";
                            }
                            else
                            {
                                File.Copy(openFileDialog1.FileName, @"UyeResimleri\" + "" + openFileDialog1.SafeFileName);
                                x = (@"UyeResimleri\"+ "" + openFileDialog1.SafeFileName);
                                komut = new OleDbCommand("insert into Uyeler(UyeNo,TcKimlik,UyeAdi,UyeSoyadi,Sinif,Eposta,Tel,Adres,ResimYolu,ResimAdi) values('" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + " " + comboBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + x + "','"+openFileDialog1.SafeFileName+"')", baglanti);
                                komut.ExecuteNonQuery();
                                Temizle();
                                label11.Text = "Kayıt Tamamlandı";
                            }
                        }
                        else
                        {
                            label11.Text = "ÜYE RESMİ SEÇİNİZ";
                        }


                    }
                
               

            }

            DataGridCagir();

            baglanti.Close();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (textBox1.Text == "")
            {
                label11.Text = "Üye Numarası Girin";
            }
            else
            {
                komut = new OleDbCommand("select * from Uyeler where UyeNo=" + int.Parse(textBox1.Text) + "", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    komut = new OleDbCommand("delete from Uyeler where UyeNo=" + int.Parse(textBox1.Text) + "",baglanti);
                    File.Delete(dr["ResimYolu"].ToString());
                    komut.ExecuteNonQuery();
                    label11.Text = "Kayıt Silindi";

                }
                else
                    label11.Text = "Uye Numarası Yok";
            }
            Temizle();
            label11.Text = "Kayıt silindi";
            DataGridCagir();
            baglanti.Close();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string siniff;

            baglanti.Open();
            if (textBox1.Text == "")
            {
                label11.Text = "Üye Numarası Girin";
            }
            else
            {
                komut = new OleDbCommand("select * from Uyeler where UyeNo=" + int.Parse(textBox1.Text) + "", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    siniff = dr["Sinif"].ToString();
                    textBox2.Text = dr["TcKimlik"].ToString();
                    textBox3.Text = dr["UyeAdi"].ToString();
                    textBox4.Text = dr["UyeSoyadi"].ToString();
                    comboBox1.Text = siniff.Substring(0, 2);
                    comboBox2.Text = siniff.Substring(3, 1);
                    textBox5.Text = dr["Eposta"].ToString();
                    textBox6.Text = dr["Tel"].ToString();
                    textBox7.Text = dr["Adres"].ToString();
                    label12.Text = dr["ResimYolu"].ToString();
                    pictureBox1.ImageLocation = label12.Text;
                }
                else
                {
                    Temizle();
                    label11.Text = "Bu numarada bir kayıt yok";
                }
            }
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string x;
            baglanti.Open();
            if (textBox1.Text == "")
            {
                label11.Text = "Üye Numarası Girin";
            }
            else
            {
                komut = new OleDbCommand("select * from Uyeler where UyeNo=" + int.Parse(textBox1.Text) + "", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    label12.Text = dr["ResimYolu"].ToString();
                    label13.Text = dr["ResimAdi"].ToString();
                    if (a == 0)
                    {

                        komut = new OleDbCommand("update Uyeler set TcKimlik ='" + textBox2.Text + "',UyeAdi='" + textBox3.Text + "',UyeSoyadi='" + textBox4.Text + "',Sinif='" + comboBox1.Text + " " + comboBox2.Text + "',Eposta='" + textBox5.Text + "',Tel='" + textBox6.Text + "',Adres='" + textBox7.Text + "', ResimYolu= '" + label12.Text + "',ResimAdi='"+label13.Text+"'where UyeNo=" + int.Parse(textBox1.Text) + "", baglanti);
                        komut.ExecuteNonQuery();
                    }

                    else
                    {
                        if (File.Exists(@"UyeResimleri\"+ "" + openFileDialog1.SafeFileName))
                        {
                            label11.Text = "Aynı isimde resim var";
                        }
                        else
                        {
                            File.Delete(dr["ResimYolu"].ToString());
                            File.Copy(openFileDialog1.FileName, @"UyeResimleri\" + "" + openFileDialog1.SafeFileName);
                            x = (@"UyeResimleri\" + "" + openFileDialog1.SafeFileName);
                            komut = new OleDbCommand("update Uyeler set TcKimlik ='" + textBox2.Text + "',UyeAdi='" + textBox3.Text + "',UyeSoyadi='" + textBox4.Text + "',Sinif='" + comboBox1.Text + " " + comboBox2.Text + "',Eposta='" + textBox5.Text + "',Tel='" + textBox6.Text + "',Adres='" + textBox7.Text + "', ResimYolu= '" + x + "',ResimAdi='" + openFileDialog1.SafeFileName + "' where UyeNo=" + int.Parse(textBox1.Text) + "", baglanti);
                            komut.ExecuteNonQuery();
                               Temizle();
                            label11.Text = "GÜNCELLEME BAŞARILI";
                        }
                    }

                }
                else
                { label11.Text = "Böyle bir resim yok"; }
            }
            baglanti.Close();
            DataGridCagir();
        }




        private void Uyeislemleri_Load(object sender, EventArgs e)
        {
            DataGridCagir();
        }

        int a = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seçiniz";
            openFileDialog1.InitialDirectory = @"C:\Users\Public\Pictures\Sample Pictures";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label12.Text = openFileDialog1.FileName;
                label13.Text = openFileDialog1.SafeFileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
            else
            {
                label11.Text = "RESİM SEÇİNİZ";
            }
            a = 1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string x;
            try
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["UyeNo"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["TcKimlik"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["UyeAdi"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["UyeSoyadi"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["Eposta"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["Tel"].Value.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["Adres"].Value.ToString();
                label12.Text = dataGridView1.Rows[e.RowIndex].Cells["ResimYolu"].Value.ToString();
                pictureBox1.ImageLocation = label12.Text;
                x = dataGridView1.Rows[e.RowIndex].Cells["Sinif"].Value.ToString();
                comboBox1.Text = x.Substring(0, 2);
                comboBox2.Text = x.Substring(3, 1);

                label11.Text = "";
            }
            catch
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
