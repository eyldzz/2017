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
    public partial class Kitapislemleri : Form
    {
        public Kitapislemleri()
        {
            InitializeComponent();
        }
        private void DataGridRenklendir()
        {
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
        private void DataGridCagir()
        {
            ds.Clear();
            da = new OleDbDataAdapter("select * from KitapBilgiler", baglanti);
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

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
        OleDbCommand komut;
        OleDbDataReader dr;
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();

         private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            label3.Text = "";
        }

        private void Kitapislemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaMenu frm = new AnaMenu();
            frm.Show();
        }

        private void Kitapislemleri_Load(object sender, EventArgs e)
        {
            DataGridCagir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string x;
            baglanti.Open();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
            {
                label3.Text = "Boş Bırakmayın";
            }
            else
            {
                komut = new OleDbCommand("select * from KitapBilgiler where KitapNo=" + int.Parse(textBox1.Text) + " ", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    label3.Text = "Bu numarada zaten bir kitap kaydı var";
                }
                else
                {
                    if (pictureBox1.ImageLocation != "" && label10.Text != "")
                    {

                        if (File.Exists(@"KitapResimleri\" + "" + openFileDialog1.SafeFileName))
                        {
                            label3.Text = "Aynı isimde resim var";
                        }
                        else
                        {
                            File.Copy(openFileDialog1.FileName, @"KitapResimleri\" + "" + openFileDialog1.SafeFileName);
                            x = (@"KitapResimleri\" + "" + openFileDialog1.SafeFileName);
                            komut = new OleDbCommand("insert into KitapBilgiler(KitapNo,KitapAdi,KitapTuru,KitapYazari,KitapYayinEvi,BulunduguBolum,Kitapicerigi,KitapSayisi,VeriYolu,ResimAdi) values('" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + int.Parse(textBox5.Text) + "','" + x + "','"+openFileDialog1.SafeFileName+"')", baglanti);
                            komut.ExecuteNonQuery();
                            Temizle();
                            label3.Text = "Kayıt Tamamlandı";
                        }

                    }
                    else
                    {
                        label3.Text = "Resim seçin";
                    }

                }
            }
            baglanti.Close();
            DataGridCagir();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (textBox1.Text == "")
            {
                label3.Text = "Üye Numarası Girin";
            }
            else
            {
                komut = new OleDbCommand("select * from KitapBilgiler where KitapNo=" + int.Parse(textBox1.Text) + " ", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr["KitapAdi"].ToString();
                    comboBox1.Text = dr["KitapTuru"].ToString();
                    comboBox2.Text = dr["KitapYazari"].ToString();
                    comboBox3.Text = dr["KitapYayinEvi"].ToString();
                    textBox3.Text = dr["BulunduguBolum"].ToString();
                    textBox4.Text = dr["Kitapicerigi"].ToString();
                    textBox5.Text = dr["KitapSayisi"].ToString();
                    label10.Text = dr["VeriYolu"].ToString();
                    pictureBox1.ImageLocation = label10.Text;
                    
                }
                else
                {
                    label3.Text = "Bu Numarada Bir Kitap Yok";

                }
            }
            baglanti.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            pictureBox1.ImageLocation = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (textBox1.Text == "")
            {
                label3.Text = "Kitap Numarası Girin";
            }
            else
            {
                komut = new OleDbCommand("select * from KitapBilgiler where KitapNo=" + int.Parse(textBox1.Text) + "", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    komut = new OleDbCommand("delete from KitapBilgiler where KitapNo=" + int.Parse(textBox1.Text) + "",baglanti);
                    File.Delete(dr["VeriYolu"].ToString());
                    komut.ExecuteNonQuery();
                    label3.Text = "Kayıt Silindi";

                }
                else
                    label3.Text = "Kitap Numarası Yok";
            }
            DataGridCagir();
            baglanti.Close();
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string x;
             baglanti.Open();
             if (textBox1.Text == "")
             {
                 label3.Text = "Kitap Numarası Girin";
             }
             else
             {
                 komut = new OleDbCommand("select * from KitapBilgiler where KitapNo=" + int.Parse(textBox1.Text) + "", baglanti);
                 dr = komut.ExecuteReader();
                 if (dr.Read())
                 {
                     label10.Text = dr["VeriYolu"].ToString();
                     label11.Text = dr["ResimAdi"].ToString();
                     if (a == 0)
                     {
                         komut = new OleDbCommand("update KitapBilgiler set KitapAdi='" + textBox2.Text + "', KitapTuru= '" + comboBox1.Text + "',KitapYazari='" + comboBox2.Text + "',KitapYayinEvi='" + comboBox3.Text + "',BulunduguBolum='" + textBox3.Text + "',Kitapicerigi='" + textBox4.Text + "',KitapSayisi='" + textBox5.Text + "',VeriYolu='" + label10.Text + "', ResimAdi = '" + label11.Text + "'where KitapNo = " + int.Parse(textBox1.Text) + " ", baglanti);
                         komut.ExecuteNonQuery();
                     }
                     else
                     {
                         if (File.Exists(@"KitapResimleri\" + "" + openFileDialog1.SafeFileName))
                         {
                             label3.Text = "Aynı isimde resim var";
                         }
                         else
                         {
                             File.Delete(dr["VeriYolu"].ToString());
                             File.Copy(openFileDialog1.FileName, @"KitapResimleri\" + "" + openFileDialog1.SafeFileName);
                             x = (@"KitapResimleri\" + "" + openFileDialog1.SafeFileName);
                             komut = new OleDbCommand("update KitapBilgiler set KitapAdi='" + textBox2.Text + "', KitapTuru= '" + comboBox1.Text + "',KitapYazari='" + comboBox2.Text + "',KitapYayinEvi='" + comboBox3.Text + "',BulunduguBolum='" + textBox3.Text + "',Kitapicerigi='" + textBox4.Text + "',KitapSayisi='" + textBox5.Text + "',VeriYolu='" + x + "',ResimAdi ='" + openFileDialog1.SafeFileName.ToString() + "'where KitapNo = " + int.Parse(textBox1.Text) + " ", baglanti);
                             komut.ExecuteNonQuery();
                             Temizle();
                             label3.Text = "GÜNCELLEME BAŞARILI";
                         }

                     }


                 }
                 else
                 {
                     label3.Text = "Böyle Bir Kayıt Yok";
                 }
                 
                 
             }
             baglanti.Close();
             DataGridCagir();
        }
        int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seçiniz";
            openFileDialog1.InitialDirectory = @"C:\Users\Public\Pictures\Sample Pictures";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label10.Text = openFileDialog1.FileName;
                label11.Text = openFileDialog1.SafeFileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
            else
            {
                label3.Text = "RESİM SEÇİNİZ";
            }
            a = 1;
        }

        private void btnTurDuzenle_Click(object sender, EventArgs e)
        {
            KitapTuruDuzenle frm = new KitapTuruDuzenle();
            frm.ShowDialog();
        }

        private void btnYayineviDuzenle_Click(object sender, EventArgs e)
        {
            YayinEviDuzenle frm = new YayinEviDuzenle();
            frm.ShowDialog();
        }

        private void btnYazarDuzenle_Click(object sender, EventArgs e)
        {
            YazarDuzenle frm = new YazarDuzenle();
            frm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["KitapNo"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["KitapAdi"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["BulunduguBolum"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["Kitapicerigi"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["KitapSayisi"].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["KitapTuru"].Value.ToString();
                comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["KitapYazari"].Value.ToString();
                comboBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["KitapYayinEvi"].Value.ToString();
                pictureBox1.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells["VeriYolu"].Value.ToString();
            }
            catch
            { }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new OleDbCommand("select TurAdi from KitapTurleri", baglanti);
            dr = komut.ExecuteReader();
            comboBox1.Items.Clear();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["TurAdi"].ToString());
            }
            baglanti.Close();
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new OleDbCommand("select YazarAdi from Yazarlar", baglanti);
            dr = komut.ExecuteReader();
            comboBox2.Items.Clear();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["YazarAdi"].ToString());
            }
            baglanti.Close();
        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new OleDbCommand("select YayinEviAdi from YayinEvleri", baglanti);
            dr = komut.ExecuteReader();
            comboBox3.Items.Clear();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["YayinEviAdi"].ToString());
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
       {
           baglanti.Open();
           if (comboBox4.Text != "" && textBox6.Text == "")
           {
               label3.Text = " Lütfen İçerik Girin";
           }
           else
           {
               if (comboBox4.Text == "Kitap Adı")
               {
                   if (textBox6.Text == "")
                   { label3.Text = "Lütfen Metin Kutusunu Doldurun"; }
                   else
                   {
                       komut = new OleDbCommand("select * from KitapBilgiler where KitapAdi='" + textBox6.Text + "' ", baglanti);
                       dr = komut.ExecuteReader();
                       if (dr.Read())
                       {
                           ds.Clear();
                           da = new OleDbDataAdapter("select * from KitapBilgiler where KitapAdi='" + textBox6.Text + "'", baglanti);
                           da.Fill(ds);
                           dataGridView1.DataSource = ds.Tables[0];
                           DataGridRenklendir();
                       }
                       else
                       {
                           label3.Text = "Böyle Bir Kitap Yok";
                       }
                   }
               }
               if (comboBox4.Text == "Kitap Türü")
               {
                   if (textBox6.Text == "")
                   { label3.Text = "Lütfen Metin Kutusunu Doldurun"; }
                   else
                   {
                       komut = new OleDbCommand("select * from KitapBilgiler where KitapTuru='" + textBox6.Text + "' ", baglanti);
                       dr = komut.ExecuteReader();
                       if (dr.Read())
                       {
                           ds.Clear();
                           da = new OleDbDataAdapter("select * from KitapBilgiler where KitapTuru='" + textBox6.Text + "'", baglanti);
                           da.Fill(ds);
                           dataGridView1.DataSource = ds.Tables[0];
                           DataGridRenklendir();
                       }
                       else
                       { label3.Text = "Böyle Bir Tür Yok"; }
                   }
                }
               if (comboBox4.Text == "Kitap Yazari")
               {
                   if (textBox6.Text == "")
                   { label3.Text = "Lütfen Metin Kutusunu Doldurun"; }
                   else
                   {
                       komut = new OleDbCommand("select * from KitapBilgiler where KitapYazari='" + textBox6.Text + "' ", baglanti);
                       dr = komut.ExecuteReader();
                       if (dr.Read())
                       {
                           ds.Clear();
                           da = new OleDbDataAdapter("select * from KitapBilgiler where KitapYazari='" + textBox6.Text + "'", baglanti);
                           da.Fill(ds);
                           dataGridView1.DataSource = ds.Tables[0];
                           DataGridRenklendir();
                       }
                       else
                       { label3.Text = "Böyle Bir Yazar Yok"; }
                   }
               }
               if (comboBox4.Text == "Kitap Yayınevi")
               {
                   if (textBox6.Text == "")
                   { label3.Text = "Lütfen Metin Kutusunu Doldurun"; }
                   else
                   {
                       komut = new OleDbCommand("select * from KitapBilgiler where KitapYayinEvi='" + textBox6.Text + "' ", baglanti);
                       dr = komut.ExecuteReader();
                       if (dr.Read())
                       {
                           ds.Clear();
                           da = new OleDbDataAdapter("select * from KitapBilgiler where KitapYayinEvi='" + textBox6.Text + "'", baglanti);
                           da.Fill(ds);
                           dataGridView1.DataSource = ds.Tables[0];
                           DataGridRenklendir();
                       }
                       else
                       { label3.Text = "Böyle Bir Yayınevi Yok"; }
                   }
               }
               if (comboBox4.Text == "Kitap İçeriği")
               {
                   if (textBox6.Text == "")
                   { label3.Text = "Lütfen Metin Kutusunu Doldurun"; }
                   else
                   {
                       komut = new OleDbCommand("select * from KitapBilgiler where Kitapicerigi='" + textBox6.Text + "' ", baglanti);
                       dr = komut.ExecuteReader();
                       if (dr.Read())
                       {
                           ds.Clear();
                           da = new OleDbDataAdapter("select * from KitapBilgiler where Kitapicerigi='" + textBox6.Text + "'", baglanti);
                           da.Fill(ds);
                           dataGridView1.DataSource = ds.Tables[0];
                           DataGridRenklendir();
                       }
                       else
                       { label3.Text = "Böyle Bir İçerik Yok"; }
                   }
               }
               if (comboBox4.Text == "" && textBox6.Text == "")
               {
                   DataGridCagir();
               }

           }
           baglanti.Close();
        
            
        }


    }
}
        
    
