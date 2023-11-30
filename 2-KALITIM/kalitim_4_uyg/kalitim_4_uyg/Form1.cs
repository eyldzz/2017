using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kalitim_4_uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Araba
        {
            public int hiz = 0, vites = 0;

            public int bilgihiz()
            {
                return hiz;
            }
            public int bilgivites()
            {
                return vites;
            }

        }

        class Otomobil : Araba
        {
            public void hizlan(int a)
            {
                if (hiz < 240)
                    hiz += a;
                if (hiz >= 0 && hiz < 39)
                    vites = 1;
                else if (hiz >= 40 && hiz < 79)
                    vites = 2;
                else if (hiz >= 80 && hiz < 119)
                    vites = 3;
                else if (hiz >= 120 && hiz < 159)
                    vites = 4;
                else if (hiz >= 120 && hiz <= 240)
                    vites = 5;
                if (hiz > 240)
                {
                    hiz = 240;
                    vites = 5;
                }
            }
            public void yavasla(int a)
            {
                if (hiz > 0)
                    hiz -= a;
                if (hiz >= 0 && hiz < 39)
                    vites = 1;
                else if (hiz >= 40 && hiz < 79)
                    vites = 2;
                else if (hiz >= 80 && hiz < 119)
                    vites = 3;
                else if (hiz >= 120 && hiz < 159)
                    vites = 4;
                else if (hiz >= 160 && hiz <= 240)
                    vites = 5;
                if (hiz < 0)
                {
                    hiz = 0;
                    vites = 1;
                }
            }

        }

        class Otobus : Araba
        {
            public void hizlan(int a)
            {
                if (hiz < 150)
                    hiz += a;
                if (hiz >= 0 && hiz < 29)
                    vites = 1;
                else if (hiz >= 30 && hiz < 59)
                    vites = 2;
                else if (hiz >= 60 && hiz < 89)
                    vites = 3;
                else if (hiz >= 90 && hiz < 119)
                    vites = 4;
                else if (hiz >= 120 && hiz <= 150)
                    vites = 5;
                if (hiz > 150)
                {
                    hiz = 150;
                    vites = 5;
                }
            }
            public void yavasla(int a)
            {
                if (hiz > 0)
                    hiz -= a;
                if (hiz >= 0 && hiz < 39)
                    vites = 1;
                else if (hiz >= 30 && hiz < 59)
                    vites = 2;
                else if (hiz >= 60 && hiz < 89)
                    vites = 3;
                else if (hiz >= 90 && hiz < 119)
                    vites = 4;
                else if (hiz >= 120 && hiz <= 150)
                    vites = 5;
                if (hiz < 0)
                {
                    hiz = 0;
                    vites = 1;
                }
            }

        }

        class Kamyon : Araba
        {
            public void hizlan(int a)
            {
                if (hiz < 98)
                    hiz += a;
                if (hiz >= 0 && hiz < 20)
                    vites = 1;
                else if (hiz >= 21 && hiz < 34)
                    vites = 2;
                else if (hiz >= 35 && hiz < 48)
                    vites = 3;
                else if (hiz >= 49 && hiz < 62)
                    vites = 4;
                else if (hiz >= 63 && hiz <= 98)
                    vites = 5;
                if (hiz > 98)
                {
                    hiz = 98;
                    vites = 5;
                }
            }
            public void yavasla(int a)
            {
                if (hiz > 0)
                    hiz -= a;
                if (hiz >= 0 && hiz < 20)
                    vites = 1;
                else if (hiz >= 21 && hiz < 34)
                    vites = 2;
                else if (hiz >= 35 && hiz < 48)
                    vites = 3;
                else if (hiz >= 49 && hiz < 62)
                    vites = 4;
                else if (hiz >= 63 && hiz <= 98)
                    vites = 5;
                if (hiz < 0)
                {
                    hiz = 0;
                    vites = 1;
                }
            }

        }

        Otomobil ford = new Otomobil();
        Kamyon dodge = new Kamyon();
        Otobus neoplan = new Otobus();


        private void btnArabaHizlan_Click(object sender, EventArgs e)
        {
            ford.hizlan(int.Parse(textBox7.Text));
        }

        private void btnArabaYavasla_Click(object sender, EventArgs e)
        {
            ford.yavasla(int.Parse(textBox7.Text));
        }

        private void btnArabaBilgiler_Click(object sender, EventArgs e)
        {
            int a, b;
            a = ford.bilgihiz();
            b = ford.bilgivites();
            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();
        }

        private void btnOtobusHizlan_Click(object sender, EventArgs e)
        {
            neoplan.hizlan(int.Parse(textBox8.Text));
        }

        private void btnOtobusYavasla_Click(object sender, EventArgs e)
        {
            neoplan.yavasla(int.Parse(textBox8.Text));
        }

        private void btnOtobusBilgiler_Click(object sender, EventArgs e)
        {
            int a, b;
            a = neoplan.bilgihiz();
            b = neoplan.bilgivites();
            textBox3.Text = a.ToString();
            textBox4.Text = b.ToString();
        }

        private void btnKamyonHizlan_Click(object sender, EventArgs e)
        {
            dodge.hizlan(int.Parse(textBox9.Text));
        }

        private void btnKamyonYavasla_Click(object sender, EventArgs e)
        {
            dodge.yavasla(int.Parse(textBox9.Text));
        }

        private void btnKamyonBilgiler_Click(object sender, EventArgs e)
        {
            int a, b;
            a = dodge.bilgihiz();
            b = dodge.bilgivites();
            textBox5.Text = a.ToString();
            textBox6.Text = b.ToString();
        }
    }
}
