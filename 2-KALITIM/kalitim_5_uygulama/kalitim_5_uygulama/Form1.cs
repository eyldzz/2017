using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kalitim_5_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Oyun
        {
            public int puan = 0;
            public int durum()
            {
                return puan;
            }
        }
        class Ust : Oyun
        {
            public void durum(int a)
            {
                puan += 3 * a;

            }
        }
        class Orta : Oyun
        {
            public void durum(int a)
            {
                puan += 2 * a;
            }
        }

        class Alt : Oyun
        {
            public void durum(int a)
            {
                puan += a;
            }
        }


        Ust ustt = new Ust();
        Orta ortaa = new Orta();
        Alt altt = new Alt();

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
                 ustt.durum(a);
            }
            else if (radioButton2.Checked)
            {
                 ortaa.durum(a);
            }
            else if (radioButton3.Checked)
            {
                 altt.durum(a);
            }
            else
            {
                MessageBox.Show("Seviye Seçin");
            }
        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                textBox2.Text = ustt.durum().ToString();
            else if (radioButton2.Checked)
                textBox2.Text = ortaa.durum().ToString();
            else if (radioButton3.Checked)
                textBox2.Text = altt.durum().ToString();
            else
                MessageBox.Show("Seviye Seçin");
        }


      
    }
}
