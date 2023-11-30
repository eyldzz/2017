using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace siniflar_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Musteri
        { 
            int borc = 0;

            public void borcartir(string urun, int adet)
            {
                if (urun == "Su")
                    borc += adet * 3;
                else if (urun == "Piknik Tüpü")
                    borc += adet * 13;
                else if (urun == "Mutfak Tüpü")
                    borc += adet * 35;

            }
            public void borcode(int miktar)
            {
                borc -= miktar;
            }
            public void borcogren()
            {
                MessageBox.Show("Borcunuz: " + borc);
            }

        }


        Musteri AhmetBey = new Musteri();
        Musteri AyseHanim = new Musteri();


        private void btnSatış_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Ahmet Bey")
                AhmetBey.borcartir(comboBox2.Text, int.Parse(textBox1.Text));
            else if (comboBox1.Text == "Ayşe Hanım")
                AyseHanim.borcartir(comboBox2.Text, int.Parse(textBox1.Text));
        }

        private void btnBorcOgren_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Ahmet Bey")
                AhmetBey.borcogren();
            else if (comboBox3.Text == "Ayşe Hanım")
                AyseHanim.borcogren();
        }

        private void btnBorcOde_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Ahmet Bey")
                AhmetBey.borcode(int.Parse(textBox2.Text));
            else if (comboBox4.Text == "Ayşe Hanım")
                AyseHanim.borcode(int.Parse(textBox2.Text));
        }

 
    }
}
