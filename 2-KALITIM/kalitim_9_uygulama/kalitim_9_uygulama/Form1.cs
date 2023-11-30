using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kalitim_9_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Operator
        {
            public double borc = 0;
            public void borcode(double a)
            {
                borc -= a;
            }
            public double borcgoster()
            {
                return borc;
            }

        }

        class Turkcell : Operator
        {
            public void borcArtir(double a)
            {
                if (a > 50)
                    borc += a * 0.90;
                else
                    borc += a;
            }

        }

        class Vodafone : Operator
        {
            public void borcArtir(double a)
            {
                if (a > 50)
                    borc += a * 0.80;
                else
                    borc += a;
            } 

        }

        class Telekom : Operator
        {
            public void borcArtir(double a)
            {
                if (a > 50)
                    borc += a * 0.70;
                else
                    borc += a;
            }
        }

        Turkcell Gizem = new Turkcell();
        Vodafone Feyza = new Vodafone();
        Telekom Kerem = new Telekom();
        Telekom Umut = new Telekom();

        double dk, sms, net;

        private void btnBorcArtir_Click(object sender, EventArgs e)
        {
            double x = 0;
            if (comboBoxDakika.Text == "" || comboBoxInternet.Text == "" || comboBoxSms.Text == "")
            {
                MessageBox.Show("Tüm Alanları Doldurun");                       
            }

            else
            {
                if (radiobtnFeyzanur.Checked)
                {
                    if (comboBoxDakika.Text == "100")
                        dk = 9;
                    else if (comboBoxDakika.Text == "500")
                        dk = 36;
                    else if (comboBoxDakika.Text == "1000")
                        dk = 60;
                    if (comboBoxSms.Text == "100")
                        sms = 2;
                    else if (comboBoxDakika.Text == "500")
                        sms = 3;
                    else if (comboBoxDakika.Text == "1000")
                        sms = 5;
                    if (comboBoxInternet.Text == "1 GB")
                        net = 10;
                    else if (comboBoxDakika.Text == "2 GB")
                        net = 18;
                    else if (comboBoxDakika.Text == "3 GB")
                        net = 25;
                    x = dk + sms + net;
                    Feyza.borcArtir(x);
                }

                else if (radiobtnGizem.Checked)
                {
                    if (comboBoxDakika.Text == "100")
                        dk = 10;
                    else if (comboBoxDakika.Text == "500")
                        dk = 40;
                    else if (comboBoxDakika.Text == "1000")
                        dk = 70;
                    if (comboBoxSms.Text == "100")
                        sms = 2;
                    else if (comboBoxDakika.Text == "500")
                        sms = 2;
                    else if (comboBoxDakika.Text == "1000")
                        sms = 4;
                    if (comboBoxInternet.Text == "1 GB")
                        net = 9;
                    else if (comboBoxDakika.Text == "2 GB")
                        net = 15;
                    else if (comboBoxDakika.Text == "3 GB")
                        net = 20;
                    x = dk + sms + net;
                    Gizem.borcArtir(x);
                }

                else if (radiobtnKerem.Checked)
                {
                    if (comboBoxDakika.Text == "100")
                        dk = 5;
                    else if (comboBoxDakika.Text == "500")
                        dk = 20;
                    else if (comboBoxDakika.Text == "1000")
                        dk = 40;
                    if (comboBoxSms.Text == "100")
                        sms = 3;
                    else if (comboBoxDakika.Text == "500")
                        sms = 4;
                    else if (comboBoxDakika.Text == "1000")
                        sms = 7;
                    if (comboBoxInternet.Text == "1 GB")
                        net = 8;
                    else if (comboBoxDakika.Text == "2 GB")
                        net = 16;
                    else if (comboBoxDakika.Text == "3 GB")
                        net = 19;
                    x = dk + sms + net;
                    Kerem.borcArtir(x);
                }

                else if (radiobtnUmut.Checked)
                {
                    if (comboBoxDakika.Text == "100")
                        dk = 5;
                    else if (comboBoxDakika.Text == "500")
                        dk = 20;
                    else if (comboBoxDakika.Text == "1000")
                        dk = 40;
                    if (comboBoxSms.Text == "100")
                        sms = 3;
                    else if (comboBoxDakika.Text == "500")
                        sms = 4;
                    else if (comboBoxDakika.Text == "1000")
                        sms = 7;
                    if (comboBoxInternet.Text == "1 GB")
                        net = 8;
                    else if (comboBoxDakika.Text == "2 GB")
                        net = 16;
                    else if (comboBoxDakika.Text == "3 GB")
                        net = 19;
                    x = dk + sms + net;
                    Umut.borcArtir(x);
                }
            }

        }

        private void btnBorcOde_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (radiobtnFeyzanur.Checked)
                    Feyza.borcode(double.Parse(textBox1.Text));
                else if (radiobtnGizem.Checked)
                    Gizem.borcode(double.Parse(textBox1.Text));
                else if (radiobtnKerem.Checked)
                    Kerem.borcode(double.Parse(textBox1.Text));
                else if (radiobtnUmut.Checked)
                    Umut.borcode(double.Parse(textBox1.Text));
            }
            else
            {
                MessageBox.Show("Miktar Girin");
            }
        }

        private void btnBorcOgren_Click(object sender, EventArgs e)
        {
            if (radiobtnFeyzanur.Checked)
                textBox2.Text = Feyza.borcgoster().ToString();
            else if (radiobtnGizem.Checked)
                textBox2.Text = Gizem.borcgoster().ToString();
            else if (radiobtnKerem.Checked)
                textBox2.Text = Kerem.borcgoster().ToString();
            else if (radiobtnUmut.Checked)
                textBox2.Text = Umut.borcgoster().ToString();
        }
    


    }
}
