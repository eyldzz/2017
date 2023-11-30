using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kalitim_7_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class insanlar
        {
            public double borc = 0;

            public void borcode(int a)
            {
                borc -= a;
            }
        }
        class Akademisyen : insanlar
        {
            public void tutarhesapla(double a)
            {
                borc += a;
            }
        }

        class Asistan : insanlar
        {
            public void tutarhesapla(double a)
            {
                borc += a * 95 / 100;
            }
        }

        class Ogrenci : insanlar
        {
            public void tutarhesapla(double a)
            {
                borc += a * 80 / 100;
            }
        }


        Akademisyen Feyza = new Akademisyen();
        Asistan Umut = new Asistan();
        Asistan Sevket = new Asistan();
        Ogrenci Gizem = new Ogrenci();
        Ogrenci Kerem = new Ogrenci();
        Ogrenci Osman = new Ogrenci();


        private void btnTutarHesapla_Click(object sender, EventArgs e)
        {

            if (radioButton10.Checked)
            {
                if (radioButton1.Checked)
                {
                    Feyza.tutarhesapla(15);
                }
                if (radioButton2.Checked)
                {
                    Feyza.tutarhesapla(12);
                }
                if (radioButton3.Checked)
                {
                    Feyza.tutarhesapla(10);
                }
                if (radioButton4.Checked)
                {
                    Feyza.tutarhesapla(3);
                }
                if (radioButton5.Checked)
                {
                    Feyza.tutarhesapla(2);
                }
                if (radioButton6.Checked)
                {
                    Feyza.tutarhesapla(1);
                }
                if (radioButton7.Checked)
                {
                    Feyza.tutarhesapla(20);
                }
                if (radioButton8.Checked)
                {
                    Feyza.tutarhesapla(15);
                }
                if (radioButton9.Checked)
                {
                    Feyza.tutarhesapla(10);
                }
            }

            if (radioButton11.Checked)
            {
                if (radioButton1.Checked)
                {
                    Kerem.tutarhesapla(15);
                }
                if (radioButton2.Checked)
                {
                    Kerem.tutarhesapla(12);
                }
                if (radioButton3.Checked)
                {
                    Kerem.tutarhesapla(10);
                }
                if (radioButton4.Checked)
                {
                    Kerem.tutarhesapla(3);
                }
                if (radioButton5.Checked)
                {
                    Kerem.tutarhesapla(2);
                }
                if (radioButton6.Checked)
                {
                    Kerem.tutarhesapla(1);
                }
                if (radioButton7.Checked)
                {
                    Kerem.tutarhesapla(20);
                }
                if (radioButton8.Checked)
                {
                    Kerem.tutarhesapla(15);
                }
                if (radioButton9.Checked)
                {
                    Kerem.tutarhesapla(10);
                }
            }

            if (radioButton12.Checked)
            {
                if (radioButton1.Checked)
                {
                    Umut.tutarhesapla(15);
                }
                if (radioButton2.Checked)
                {
                    Umut.tutarhesapla(12);
                }
                if (radioButton3.Checked)
                {
                    Umut.tutarhesapla(10);
                }
                if (radioButton4.Checked)
                {
                    Umut.tutarhesapla(3);
                }
                if (radioButton5.Checked)
                {
                    Umut.tutarhesapla(2);
                }
                if (radioButton6.Checked)
                {
                    Umut.tutarhesapla(1);
                }
                if (radioButton7.Checked)
                {
                    Umut.tutarhesapla(20);
                }
                if (radioButton8.Checked)
                {
                    Umut.tutarhesapla(15);
                }
                if (radioButton9.Checked)
                {
                    Umut.tutarhesapla(10);
                }
            }

            if (radioButton13.Checked)
            {
                if (radioButton1.Checked)
                {
                    Gizem.tutarhesapla(15);
                }
                if (radioButton2.Checked)
                {
                    Gizem.tutarhesapla(12);
                }
                if (radioButton3.Checked)
                {
                    Gizem.tutarhesapla(10);
                }
                if (radioButton4.Checked)
                {
                    Gizem.tutarhesapla(3);
                }
                if (radioButton5.Checked)
                {
                    Gizem.tutarhesapla(2);
                }
                if (radioButton6.Checked)
                {
                    Gizem.tutarhesapla(1);
                }
                if (radioButton7.Checked)
                {
                    Gizem.tutarhesapla(20);
                }
                if (radioButton8.Checked)
                {
                    Gizem.tutarhesapla(15);
                }
                if (radioButton9.Checked)
                {
                    Gizem.tutarhesapla(10);
                }
            }

            if (radioButton14.Checked)
            {
                if (radioButton1.Checked)
                {
                    Osman.tutarhesapla(15);
                }
                if (radioButton2.Checked)
                {
                    Osman.tutarhesapla(12);
                }
                if (radioButton3.Checked)
                {
                    Osman.tutarhesapla(10);
                }
                if (radioButton4.Checked)
                {
                    Osman.tutarhesapla(3);
                }
                if (radioButton5.Checked)
                {
                    Osman.tutarhesapla(2);
                }
                if (radioButton6.Checked)
                {
                    Osman.tutarhesapla(1);
                }
                if (radioButton7.Checked)
                {
                    Osman.tutarhesapla(20);
                }
                if (radioButton8.Checked)
                {
                    Osman.tutarhesapla(15);
                }
                if (radioButton9.Checked)
                {
                    Osman.tutarhesapla(10);
                }
            }

            if (radioButton15.Checked)
            {
                if (radioButton1.Checked)
                {
                    Sevket.tutarhesapla(15);
                }
                if (radioButton2.Checked)
                {
                    Sevket.tutarhesapla(12);
                }
                if (radioButton3.Checked)
                {
                    Sevket.tutarhesapla(10);
                }
                if (radioButton4.Checked)
                {
                    Sevket.tutarhesapla(3);
                }
                if (radioButton5.Checked)
                {
                    Sevket.tutarhesapla(2);
                }
                if (radioButton6.Checked)
                {
                    Sevket.tutarhesapla(1);
                }
                if (radioButton7.Checked)
                {
                    Sevket.tutarhesapla(20);
                }
                if (radioButton8.Checked)
                {
                    Sevket.tutarhesapla(15);
                }
                if (radioButton9.Checked)
                {
                    Sevket.tutarhesapla(10);
                }
            }

        }

        private void btnBorcOgren_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                textBox1.Text = Feyza.borc.ToString();
            }
            
            else if (radioButton11.Checked)
            {
                textBox1.Text = Kerem.borc.ToString();
            }
            else if (radioButton12.Checked)
            {
                textBox1.Text = Umut.borc.ToString();
            }
            else if (radioButton13.Checked)
            {
                textBox1.Text = Gizem.borc.ToString();
            }
            else if (radioButton14.Checked)
            {
                textBox1.Text = Osman.borc.ToString();
            }
            else if (radioButton15.Checked)
            {
                textBox1.Text = Sevket.borc.ToString();
            }
        }

        private void btnBorcOde_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                Feyza.borcode(int.Parse(textBox2.Text));
            }

            else if (radioButton11.Checked)
            {
                Kerem.borcode(int.Parse(textBox2.Text));
            }
            else if (radioButton12.Checked)
            {
                Umut.borcode(int.Parse(textBox2.Text));
            }
            else if (radioButton13.Checked)
            {
                Gizem.borcode(int.Parse(textBox2.Text));
            }
            else if (radioButton14.Checked)
            {
                Osman.borcode(int.Parse(textBox2.Text));
            }
            else if (radioButton15.Checked)
            {
                Sevket.borcode(int.Parse(textBox2.Text));
            }
        }

  
    }
}
