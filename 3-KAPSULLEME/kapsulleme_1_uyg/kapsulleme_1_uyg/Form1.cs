using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kapsulleme_1_uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class islem
        {
            int sayi1, sayi2, sonuc;
            public int sayi1gonder()
            {
                return sayi1;
            }
            public void sayi1al(int a)
            {
                sayi1 = a;
            }
            public int sayi2gonder()
            {
                return sayi2;
            }
            public void sayi2al(int a)
            {
                sayi2 = a;
            }
            public int toplam(int a, int b)
            {
                sonuc = a + b;
                return sonuc;
            }
            public int cikar(int a, int b)
            {
                sonuc = a - b;
                return sonuc;
            }
            public int carp(int a, int b)
            {
                sonuc = a * b;
                return sonuc;
            }
            public int bol(int a, int b)
            {
                sonuc = a / b;
                return sonuc;
            }
        }

        islem T = new islem();



        private void btnTopla_Click(object sender, EventArgs e)
        {
            T.sayi1al(int.Parse(txtSayi1.Text));
            T.sayi2al(int.Parse(txtSayi2.Text));
            textBox3.Text = T.toplam(T.sayi1gonder(), T.sayi2gonder()).ToString();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            T.sayi1al(int.Parse(txtSayi1.Text));
            T.sayi2al(int.Parse(txtSayi2.Text));
            textBox4.Text = T.cikar(T.sayi1gonder(), T.sayi2gonder()).ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            T.sayi1al(int.Parse(txtSayi1.Text));
            T.sayi2al(int.Parse(txtSayi2.Text));
            textBox5.Text = T.carp(T.sayi1gonder(), T.sayi2gonder()).ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            T.sayi1al(int.Parse(txtSayi1.Text));
            T.sayi2al(int.Parse(txtSayi2.Text));
            textBox6.Text = T.bol(T.sayi1gonder(), T.sayi2gonder()).ToString();
        }


    }
}
