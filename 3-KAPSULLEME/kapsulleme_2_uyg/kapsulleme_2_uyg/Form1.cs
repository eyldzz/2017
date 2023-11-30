using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kapsulleme_2_uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class islem
        {
            int kk, uk, alan, cevre;
            public void kisakenarAl(int a)
            {
                if (a < 0)
                    a *= -1;
                kk = a;
            }
            public void uzunkenarAl(int a)
            {
                if (a < 0)
                    a *= -1;
                uk = a;
            }
            public int kisakenarGonder()
            {
                return kk;
            }
            public int uzunkenarGonder()
            {
                return uk;
            }
            public int AlanHesapla(int a, int b)
            {
                if (a >= b)
                    MessageBox.Show("KısaKenar UzunKenardan Büyük Olamaz!","UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                alan = a * b;
                return alan;
            }
            public int CevreHesapla(int a, int b)
            {
                if(a >= b)
                    MessageBox.Show("KısaKenar UzunKenardan Büyük Olamaz!","UYARI!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else
                cevre = (a + b) * 2;
                return cevre;
            }


        }

        islem d = new islem();

        private void button1_Click(object sender, EventArgs e)
        {
            d.uzunkenarAl(int.Parse(textBox1.Text));
            d.kisakenarAl(int.Parse(textBox2.Text));
            textBox3.Text = d.AlanHesapla(d.kisakenarGonder(), d.uzunkenarGonder()).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d.uzunkenarAl(int.Parse(textBox1.Text));
            d.kisakenarAl(int.Parse(textBox2.Text));
            textBox4.Text = d.CevreHesapla(d.kisakenarGonder(), d.uzunkenarGonder()).ToString();
        }
    }
}
