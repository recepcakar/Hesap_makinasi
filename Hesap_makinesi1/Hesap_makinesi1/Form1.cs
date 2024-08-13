using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_makinesi1
{      
    public partial class Form1 : Form
    {
        int birinci_sayi;
        int ikinci_sayi;
        int sonuc;
        public int secilen_deger = 5;
        public Form1()
        {
            
            InitializeComponent();
            rtex_ekran.Text = "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {  if (rtex_ekran.Text.Length == 1 && rtex_ekran.Text == "0")
            {
                rtex_ekran.Text = "1";
            }
            else
            {
                rtex_ekran.Text = rtex_ekran.Text + "1";
            }
           if (secilen_deger == 0)
            {
               rtex_ekran.Text= "1";
                secilen_deger = 5;
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (rtex_ekran.Text.Length == 1 && rtex_ekran.Text == "0")
            {
                rtex_ekran.Text = "2";
            }
            else
            {
                rtex_ekran.Text = rtex_ekran.Text + "2";
            }
            if (secilen_deger == 0)
            {
                rtex_ekran.Text = "2";
                secilen_deger = 5;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (rtex_ekran.Text.Length == 1 && rtex_ekran.Text == "0")
            {
                rtex_ekran.Text = "3";
            }
            else
            {
                rtex_ekran.Text = rtex_ekran.Text + "3";
            }
            if (secilen_deger == 0)
            {
                rtex_ekran.Text = "3";
                secilen_deger = 5;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (rtex_ekran.Text.Length == 1 && rtex_ekran.Text == "0")
            {
                rtex_ekran.Text = "4";
            }
            else
            {
                rtex_ekran.Text = rtex_ekran.Text + "4";
            }
            if (secilen_deger == 0)
            {
                rtex_ekran.Text = "4";
                secilen_deger = 5;
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (rtex_ekran.Text.Length == 1 && rtex_ekran.Text == "0")
            {
                rtex_ekran.Text = "5";
            }
            else
            {
                rtex_ekran.Text = rtex_ekran.Text + "5";
            }
            if (secilen_deger == 0)
            {
                rtex_ekran.Text = "5";
                secilen_deger = 5;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (rtex_ekran.Text.Length == 1 && rtex_ekran.Text == "0")
            {
                rtex_ekran.Text = "6";
            }
            else
            {
                rtex_ekran.Text = rtex_ekran.Text + "6";
            }
            if (secilen_deger == 0)
            {
                rtex_ekran.Text = "6";
                secilen_deger = 5;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (rtex_ekran.Text.Length == 1 && rtex_ekran.Text == "0")
            {
                rtex_ekran.Text = "7";
            }
            else
            {
                rtex_ekran.Text = rtex_ekran.Text + "7";
            }
            if (secilen_deger == 0)
            {
                rtex_ekran.Text = "7";
                secilen_deger = 5;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (rtex_ekran.Text.Length == 1 && rtex_ekran.Text == "0")
            {
                rtex_ekran.Text = "8";
            }
            else
            {
                rtex_ekran.Text = rtex_ekran.Text + "8";
            }
            if (secilen_deger == 0)
            {
                rtex_ekran.Text = "8";
                secilen_deger = 5;
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (rtex_ekran.Text.Length == 1 && rtex_ekran.Text == "0")
            {
                rtex_ekran.Text = "9";
            }
            else
            {
                rtex_ekran.Text = rtex_ekran.Text + "9";
            }
            if (secilen_deger == 0)
            {
                rtex_ekran.Text = "9";
                secilen_deger = 5;
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (rtex_ekran.Text.Length == 1 && rtex_ekran.Text == "0")
            {
                rtex_ekran.Text = "0";
            }
            else
            {
                rtex_ekran.Text = rtex_ekran.Text + "0";
            }
            if (secilen_deger == 0)
            {
                rtex_ekran.Text = "0";
                secilen_deger = 5;
            }
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            secilen_deger = 1;
            birinci_sayi = Convert.ToInt32(rtex_ekran.Text);
            rtex_ekran.Text = "0";
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            secilen_deger = 2;
            birinci_sayi = Convert.ToInt32(rtex_ekran.Text);
            rtex_ekran.Text = "0";
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            secilen_deger = 3;
            birinci_sayi = Convert.ToInt32(rtex_ekran.Text);
            rtex_ekran.Text = "0";
        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            secilen_deger = 4;
            birinci_sayi = Convert.ToInt32(rtex_ekran.Text);
            rtex_ekran.Text = "0";
        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            ikinci_sayi = Convert.ToInt32(rtex_ekran.Text);
            if (secilen_deger == 1)
            {
                sonuc = birinci_sayi + ikinci_sayi;
                rtex_ekran.Text=sonuc.ToString();
                secilen_deger = 0;
            }
            else if (secilen_deger == 2)
            {
                sonuc = birinci_sayi * ikinci_sayi;
                rtex_ekran.Text = sonuc.ToString();
                secilen_deger = 0;
            }
            else if (secilen_deger == 3)
            {
                sonuc = birinci_sayi / ikinci_sayi;
                rtex_ekran.Text = sonuc.ToString();
                secilen_deger = 0;
            }
             else if (secilen_deger == 4)
            {
                sonuc = birinci_sayi - ikinci_sayi;
                rtex_ekran.Text = sonuc.ToString();
                secilen_deger = 0;
            }
            else 
            { 
                ///
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rtex_ekran.Text = "0";
            birinci_sayi = 0;
            ikinci_sayi = 0;
        }
    }
}
