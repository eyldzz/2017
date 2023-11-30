using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kalitim_6_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class oyun
        {
            public int puan = 0;
        }
        class ust : oyun
        {
            public int durum(int a)
            {
                puan += 3 * a;
                return puan;
            }
        }
        class orta : oyun
        {
            public int durum(int a)
            {
                puan += 2 * a;
                return puan;
            }
        }
        class alt : oyun
        {
            public int durum(int a)
            {
                puan += 1 * a;
                return puan;
            }
        }
        ust u = new ust();
        orta o = new orta();
        alt s = new alt();

        private void btnSayiUret_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(-5, 5);
            textBox1.Text = a.ToString();
        }

        private void btnIlerle_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
            {
                int l = u.durum(a);
                textBox2.Text = l.ToString();
            }
            else if (radioButton2.Checked)
            {
                int l = o.durum(a);
                textBox2.Text = l.ToString();
            }
            else if (radioButton3.Checked)
            {
                int l = s.durum(a);
                textBox2.Text = l.ToString();
            }
            else
            {
                MessageBox.Show("Seviye Seçin");
            }
        }
    }
}
