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
    public partial class YeniKayit : Form
    {
        public YeniKayit()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VeriTabani.accdb");
        OleDbCommand komut;
        OleDbDataReader dr;

        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            label10.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                groupBox3.Enabled = true;
                textBox5.Enabled = true;
                textBox5.Text = "";
            }
            else
            {
                groupBox3.Enabled = false;
                radioButton9.Checked = false;
                radioButton10.Checked = false;
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }

        private void YeniKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaMenu frm = new AnaMenu();
            frm.Show();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        int ikramiyee = 0;
        string cs, mesaizmn;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || radioButton1.Checked == false && radioButton2.Checked == false)
            {
                label10.Text = "Boş Bırakmayın";
            }
            else
            {
                if (radioButton3.Checked)// çocuk sayısı
                {
                    cs = "1";
                    textBox6.Text = (int.Parse(textBox4.Text) * 10/100).ToString();
                }
                else if (radioButton4.Checked)
                {
                    cs = "2";
                    textBox6.Text = (int.Parse(textBox4.Text) * 15/100).ToString();
                }
                else if (radioButton5.Checked)
                {
                    cs = "3+";
                    textBox6.Text = (int.Parse(textBox4.Text) * 10/100).ToString();
                }
                else
                {
                    cs = "0";
                    textBox6.Text = "0";
                }
                //
                if (radioButton6.Checked)  // ikramiye
                    ikramiyee = int.Parse(textBox4.Text) / 2;
                else if (radioButton7.Checked)
                    ikramiyee = int.Parse(textBox4.Text);
                else if (radioButton8.Checked)
                    ikramiyee = int.Parse(textBox4.Text) * 2;
                else
                    ikramiyee = 0;
                //
                if (radioButton9.Checked)// Mesai
                {
                    mesaizmn = "Gece";
                    if (textBox5.Text == "")
                        label10.Text = "Mesai Saati Girin";
                    else
                    textBox7.Text = (int.Parse(textBox5.Text) * 10).ToString();
                }
                else if (radioButton10.Checked)
                {
                    mesaizmn = "Haftasonu";
                    if (textBox5.Text == "")
                        label10.Text = "Mesai Saati Girin";
                    else
                    textBox7.Text = (int.Parse(textBox5.Text) * 15).ToString();
                }
                else
                {
                    mesaizmn = "";
                    textBox7.Text = "0";
                }
                
                    if (checkBox3.Checked == false)
                    {
                        textBox5.Text = "0";
                        textBox7.Text = "0";
                    }
                    textBox8.Text = (int.Parse(textBox6.Text) + ikramiyee + int.Parse(textBox7.Text)).ToString();
                    textBox9.Text = (int.Parse(textBox8.Text) + int.Parse(textBox4.Text)).ToString();
                    btnKaydet.Enabled = true;
                    btnGuncelle.Enabled = true;
                
            }
            

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { label10.Text = "Gerekli Alanı Doldurun"; }
            else
            {
                string x;
                int a;
                baglanti.Open();
                komut = new OleDbCommand("select * from calisan where SicilNo = " + int.Parse(textBox1.Text) + "", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr["Adi"].ToString();
                    textBox3.Text = dr["Soyadi"].ToString();
                    textBox4.Text = dr["Maas"].ToString();
                    textBox6.Text = dr["CocukYardimi"].ToString();
                    textBox7.Text = dr["MesaiUcreti"].ToString();
                    textBox8.Text = dr["ToplamEkUcret"].ToString();
                    textBox9.Text = dr["ToplamMaas"].ToString();
                    x = dr["Cinsiyet"].ToString();
                    if (x == "Bay")
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;

                    x = dr["CocukSayisi"].ToString();
                    if (x == "1")
                    {
                        checkBox1.Checked = true;
                        groupBox1.Enabled = true;
                        radioButton3.Checked = true;
                    }
                    else if (x == "2")
                    {
                        checkBox1.Checked = true;
                        // groupBox1.Enabled = true;
                        radioButton4.Checked = true;
                    }
                    else if (x == "3+")
                    {
                        checkBox1.Checked = true;
                        // groupBox1.Enabled = true;
                        // radioButton5.Checked = true;
                    }
                    else
                    {
                        checkBox1.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                    }

                    a = Convert.ToInt32(dr["ikramiye"]);
                    if (a == Convert.ToInt32(dr["Maas"]) / 2)
                    {
                        checkBox2.Checked = true;
                        groupBox2.Enabled = true;
                        radioButton6.Checked = true;
                    }
                    else if (a == Convert.ToInt32(dr["Maas"]))
                    {
                        checkBox2.Checked = true;
                        // groupBox2.Enabled = true;
                        radioButton7.Checked = true;
                    }
                    else if (a == Convert.ToInt32(dr["Maas"]) * 2)
                    {
                        checkBox2.Checked = true;
                        //groupBox2.Enabled = true;
                        radioButton8.Checked = true;
                    }
                    else
                    {
                        checkBox2.Checked = false;
                        radioButton6.Checked = false;
                        radioButton7.Checked = false;
                        radioButton8.Checked = false;
                    }

                    x = dr["MesaiZamani"].ToString();
                    if (x == "Gece")
                    {
                        checkBox3.Checked = true;
                        radioButton9.Checked = true;
                    }
                    else if (x == "Haftasonu")
                    {
                        checkBox3.Checked = true;
                        radioButton10.Checked = true;
                    }
                    else
                    {
                        checkBox3.Checked = false;
                        radioButton9.Checked = false;
                        radioButton10.Checked = false;
                    }


                    textBox5.Text = dr["FazlaMesai"].ToString();

                }
                else
                {
                    Temizle();
                    label10.Text = "Böyle Bir Kayıt Yok";
                }
                baglanti.Close();
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
                string cins;
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    label10.Text = "Boş Bırakmayın";
                }
                else
                {
                    if (radioButton9.Checked == true && radioButton10.Checked == true || textBox5.Text == "")
                    { label10.Text = "Mesai Saati Girin"; }
                    else
                    {
                        baglanti.Open();
                        komut = new OleDbCommand("select * from calisan where SicilNo=" + int.Parse(textBox1.Text) + " ", baglanti);
                        dr = komut.ExecuteReader();
                        if (dr.Read())
                        {
                            label10.Text = "Bu Sicil Numarasında Zaten Bir Kayıt Var";
                        }
                        else
                        {
                            if (radioButton1.Checked == true)
                                cins = "Bay";
                            else
                                cins = "Bayan";

                            komut = new OleDbCommand("insert into calisan(SicilNo,Adi,Soyadi,Cinsiyet,Maas,FazlaMesai,CocukYardimi,MesaiUcreti,ToplamEkUcret,ToplamMaas,CocukSayisi,ikramiye,MesaiZamani) values('" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + cins + "','" + int.Parse(textBox4.Text) + "','" + int.Parse(textBox5.Text) + "','" + int.Parse(textBox6.Text) + "','" + int.Parse(textBox7.Text) + "','" + int.Parse(textBox8.Text) + "','" + int.Parse(textBox9.Text) + "','" + cs + "','" + ikramiyee + "','" + mesaizmn + "')", baglanti);
                            komut.ExecuteNonQuery();
                            Temizle();
                            label10.Text = "Kayıt Başarılı";
                        }
                    }
                }
            baglanti.Close();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new OleDbCommand("select * from calisan where SicilNo=" + int.Parse(textBox1.Text) + "", baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                komut = new OleDbCommand("delete from calisan where SicilNo=" + int.Parse(textBox1.Text) + "", baglanti);
                komut.ExecuteNonQuery();
                Temizle();
                label10.Text = "Kayıt silindi";
            }
            else
                label10.Text = "Böyle Bir Kayıt Yok";
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cins;
            if (radioButton1.Checked == true)
               cins = "Bay";
            else
               cins = "Bayan";

            baglanti.Open();
            komut = new OleDbCommand("select * from calisan where SicilNo=" + int.Parse(textBox1.Text) + "", baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                komut = new OleDbCommand("update calisan set Adi='"+textBox2.Text+"',Soyadi='"+textBox3.Text+"',Cinsiyet='"+cins+"',Maas='"+int.Parse(textBox4.Text)+"',FazlaMesai='"+int.Parse(textBox5.Text)+"',CocukYardimi='"+int.Parse(textBox6.Text)+"',MesaiUcreti='"+int.Parse(textBox7.Text)+"',ToplamEkUcret='"+int.Parse(textBox8.Text)+"',ToplamMaas='"+int.Parse(textBox9.Text)+"',CocukSayisi='"+cs+"',ikramiye='"+ikramiyee+"',MesaiZamani='"+mesaizmn+"' where SicilNo="+int.Parse(textBox1.Text)+" ",baglanti);
                komut.ExecuteNonQuery();
                Temizle();
                label10.Text = "Güncelleme Başarılı";
            }
            else
            {
                label10.Text = "Güncelleme Yapılamadı";
            }
            baglanti.Close();
        }

     
    }
}
