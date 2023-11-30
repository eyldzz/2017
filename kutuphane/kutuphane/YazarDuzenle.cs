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
    public partial class YazarDuzenle : Form
    {
        public YazarDuzenle()
        {
            InitializeComponent();
        }
        private void DataGridCagir()
        {
            ds.Clear();
            da = new OleDbDataAdapter("select * from Yazarlar", baglanti);
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


        private void btnEkle_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            baglanti.Open();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label3.Text = "Boş Bırakmayın";
            }
            else
            {
                komut = new OleDbCommand("select * from Yazarlar where YazarNo='" + textBox1.Text + "' ", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    label3.Text = "Bu numaraya kayıtlı bir yazar zaten var";
                }
                else
                {
                    komut = new OleDbCommand("insert into Yazarlar(YazarNo,Yazaradi) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    label3.Text = "Kayıt Tamamlandı";
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            DataGridCagir();
            baglanti.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            baglanti.Open();
            if (textBox1.Text == "")
            {
                label3.Text = "Boş Bırakmayın";
            }
            else
            {
                komut = new OleDbCommand("select * from Yazarlar where YazarNo='" + textBox1.Text + "' ", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr["YazarAdi"].ToString();

                }
                else
                {
                    label3.Text = "Böyle bir kayıt bulunamadı";
                    textBox2.Clear();
                }

            }
            DataGridCagir();
            baglanti.Close(); 
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            baglanti.Open();
            if (textBox1.Text == "")
            {
                label3.Text = "Boş Bırakmayın";
            }
            else
            {
                komut = new OleDbCommand("select * from Yazarlar where YazarNo='" + textBox1.Text + "' ", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    komut = new OleDbCommand("update Yazarlar set YazarAdi='" + textBox2.Text + "' where YazarNo='" + textBox1.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                }
            }
            DataGridCagir();
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            baglanti.Open();
            if (textBox1.Text == "")
            {
                label3.Text = "Boş Bırakmayın";
            }
            else
            {
                komut = new OleDbCommand("select * from Yazarlar where YazarNo='" + textBox1.Text + "' ", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    komut = new OleDbCommand("delete from Yazarlar where YazarNo='" + textBox1.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    label3.Text = "kayıt basarıyla sılındı";
                    textBox1.Clear();
                    textBox2.Clear();

                }
                else
                {
                    label3.Text = "olmayan kaydi silemezsiniz"; ;
                }

            }
            DataGridCagir();
            baglanti.Close(); 
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void YazarDuzenle_Load(object sender, EventArgs e)
        {
            DataGridCagir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["YazarNo"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["YazarAdi"].Value.ToString();
        }
    }
}
