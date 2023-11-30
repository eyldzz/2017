using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kalitim_2_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Musteriler
        {
            public double borc =0 , adet = 0;

            public void bilgiler()
            {
                if (borc < 0)
                {
                    borc = borc * -1;
                    MessageBox.Show("Alacağınız: " + borc);
                }
                else
                    MessageBox.Show("Borcunuz: " + borc);
                
            }
            public void BorcAzalt(double x)
            {
                borc -= x;

            }
        
        }
        class NormalMusteriler : Musteriler
        {
            public void BorcArtir(double a,double b)
            {
                borc += a * b;
            }
           

        }
        class VipMusteriler : Musteriler
        {
            
            public void BorcArtir(double a, double b)
            {
                double toplam = 0;
                toplam += a * b;
                toplam -= toplam * 2 / 100;
                borc += toplam;
                toplam = 0;
            }
            
        }

        NormalMusteriler Hakan = new NormalMusteriler();
        NormalMusteriler Gonca = new NormalMusteriler();
        VipMusteriler Seyfullah = new VipMusteriler();



        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (comboBox1.Text == "Defter")
                    Hakan.BorcArtir(5, double.Parse(textBox1.Text));
                else if (comboBox1.Text == "Kalem")
                    Hakan.BorcArtir(3, double.Parse(textBox1.Text));
                else if (comboBox1.Text == "Silgi")
                    Hakan.BorcArtir(2, double.Parse(textBox1.Text));
                
            }

            else if (radioButton2.Checked)
            {
                if (comboBox1.Text == "Defter")
                    Gonca.BorcArtir(5, double.Parse(textBox1.Text));
                else if (comboBox1.Text == "Kalem")
                    Gonca.BorcArtir(3, double.Parse(textBox1.Text));
                else if (comboBox1.Text == "Silgi")
                    Gonca.BorcArtir(2, double.Parse(textBox1.Text));
            }

            else if (radioButton3.Checked)
            {
                if (comboBox1.Text == "Defter")
                    Seyfullah.BorcArtir(5, double.Parse(textBox1.Text));
                else if (comboBox1.Text == "Kalem")
                    Seyfullah.BorcArtir(3, double.Parse(textBox1.Text));
                else if (comboBox1.Text == "Silgi")
                    Seyfullah.BorcArtir(2, double.Parse(textBox1.Text));
            }
        }

        private void btnBorcOde_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Hakan.BorcAzalt(double.Parse(textBox2.Text));
            }

            else if (radioButton2.Checked)
            {
                Gonca.BorcAzalt(double.Parse(textBox2.Text));
            }

            else if (radioButton3.Checked)
            {
                Seyfullah.BorcAzalt(double.Parse(textBox2.Text));
            }
        }

        private void btnBilgiler_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Hakan.bilgiler();
            }

            else if (radioButton2.Checked)
            {
                Gonca.bilgiler();
            }

            else if (radioButton3.Checked)
            {
                Seyfullah.bilgiler();
            }
        }

    }
}
