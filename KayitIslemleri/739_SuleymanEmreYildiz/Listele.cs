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
    public partial class Listele : Form
    {
        public Listele()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VeriTabani.accdb");
        OleDbDataAdapter da;
        DataSet ds = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            baglanti.Open();
            ds.Clear();
            if (radioButton1.Checked)
            {
                da = new OleDbDataAdapter("select * from calisan",baglanti);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (radioButton2.Checked)
            {
                da = new OleDbDataAdapter("select * from calisan where Cinsiyet='Bay'", baglanti);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (radioButton3.Checked)
            {
                da = new OleDbDataAdapter("select * from calisan where Cinsiyet='Bayan'", baglanti);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (radioButton4.Checked)
            {
                da = new OleDbDataAdapter("select * from calisan where CocukSayisi='1'", baglanti);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (radioButton5.Checked)
            {
                da = new OleDbDataAdapter("select * from calisan where CocukSayisi='2'", baglanti);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (radioButton6.Checked)
            {
                da = new OleDbDataAdapter("select * from calisan where Cocuksayisi='3+'", baglanti);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (radioButton7.Checked)
            {
              
                da = new OleDbDataAdapter("select * from calisan where ikramiye=maas/2", baglanti);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (radioButton8.Checked)
            {
                
                da = new OleDbDataAdapter("select * from calisan where ikramiye=maas", baglanti);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (radioButton9.Checked)
            {
                
                da = new OleDbDataAdapter("select * from calisan where ikramiye=maas*2", baglanti);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (radioButton10.Checked)
            {
                
                da = new OleDbDataAdapter("select * from calisan where MesaiZamani='Gece'", baglanti);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (radioButton11.Checked)
            {
                
                da = new OleDbDataAdapter("select * from calisan where MesaiZamani='Haftasonu'", baglanti);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
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


                baglanti.Close();
        }

        private void Listele_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaMenu frm = new AnaMenu();
            frm.Show();
            this.Hide();
        }

    }
}
