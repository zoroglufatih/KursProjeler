using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string isKod;
        int s1, s2;
        private void cmIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            isKod = cmIslem.SelectedItem.ToString();
            s1 = Cevir(txS1.Text);
            s2 = Cevir(txS2.Text);
            //int sonuc = Hesapla(s1, s2);
            //txSonuc.Text = Convert.ToString(sonuc);
            txSonuc.Text = Hesapla(s1, s2).ToString();
        }

        private int Hesapla(int s1, int s2)
        {
            int sonuc = 0;
            if (isKod == "+")
            {
                sonuc = Topla(s1, s2);
            }
            else if (isKod == "-")
            {
                sonuc = Cikar(s1, s2);
            }
            else if (isKod == "*")
            {
                sonuc = Carp(s1, s2);
            }
            else if (isKod == "/")
            {
                sonuc = Bol(s1, s2);
            }
            else if (isKod == "K")
            {
                sonuc = Karekok(s1, s2);
            }
            else
            {
                MessageBox.Show("Yanlış İşlem Kodu");
            }
            return sonuc;
        }

        private int Karekok(int s1, int s2)
        {
            return (int)Math.Sqrt(s1);
        }

        private int Bol(int s1, int s2)
        {
            if (s2 == 0)
            {
                MessageBox.Show("Sıfıra Bölme Olamaz!");
                return 0;
            }
            else
            {
                return s1 / s2;
            }
            
        }

        private int Carp(int s1, int s2)
        {
            return s1 * s2;
        }

        private int Cikar(int s1, int s2)
        {
            return s1 - s2;
        }

        private int Topla(int s1, int s2)
        {
            return s1 + s2;
        }

        private int Cevir(string text)
        {
            try
            {
                return Convert.ToInt32(text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata Oluştu: " + e.Message);
                return 0;
            }
        }
    }
}
