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
    public partial class KitapTuruDuzenle : Form
    {
        public KitapTuruDuzenle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabani.accdb");
        OleDbCommand komut;
        OleDbDataReader dr;
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void DataGridCagir()
        {
            ds.Clear();
            da = new OleDbDataAdapter("select * from KitapTurleri", baglanti);
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label3.Text = "Boş Bırakmayın";
            }
            else
            {
                komut = new OleDbCommand("select * from KitapTurleri where TurNo='" + textBox1.Text + "'", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    label3.Text = "Bu numarada zaten bir kayıt var";
                }
                else
                {
                    komut = new OleDbCommand("insert into KitapTurleri(TurNo,TurAdi) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    textBox1.Clear();
                    textBox2.Clear();
                    label3.Text = "Kayıt Tamamlandı";
                }
            }
            DataGridCagir();
            baglanti.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label3.Text = "Boş Bırakmayın";
            }

            komut = new OleDbCommand("select * from KitapTurleri where TurNo='" + textBox1.Text + "'", baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["TurAdi"].ToString();
            }
            else
            {
                label3.Text = "Bu numaraya kayıtlı bir kitap türü yok";
                textBox2.Clear();
            }
            DataGridCagir();
            baglanti.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (textBox1.Text == "")
            {
                label3.Text = "Tür Numarası Girin";
            }
            else
            {
                komut = new OleDbCommand("select * from KitapTurleri where TurNo='" + textBox1.Text + "'", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    komut = new OleDbCommand("update KitapTurleri set TurAdi='" + textBox2.Text + "' where TurNo='" + textBox1.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
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
                label3.Text = "Tür Numarası Girin";
            }
            else
            {
                komut = new OleDbCommand("select * from KitapTurleri where TurNo='" + textBox1.Text + "'", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    komut = new OleDbCommand("delete from KitapTurleri where TurNo='" + textBox1.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                }

            }
            DataGridCagir();
            baglanti.Close();
        }

        private void KitapTuruDuzenle_Load(object sender, EventArgs e)
        {
            DataGridCagir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["TurNo"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["TurAdi"].Value.ToString();
        }

    }
}
