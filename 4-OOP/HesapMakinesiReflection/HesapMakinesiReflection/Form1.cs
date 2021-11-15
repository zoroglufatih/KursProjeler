using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HesapDll;

namespace HesapMakinesiReflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string isKod;
        int s1, s2;
        Hesapla hesapla = new Hesapla();
        private void cmIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            isKod = cmIslem.SelectedItem.ToString();
            s1 = Cevir(txS1.Text);
            s2 = Cevir(txS2.Text);
            int sonuc = HesapYap(s1, s2);
            txSonuc.Text = sonuc.ToString();
        }

        private int HesapYap(int s1, int s2)
        {
            MethodInfo methodInfo = (MethodInfo)cmIslem.SelectedItem;
            return Convert.ToInt32(methodInfo.Invoke(hesapla, new object[2] { s1, s2 }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MethodInfo[] metotlar = hesapla.GetMethods();
            foreach (var item in metotlar)
            {
                cmIslem.Items.Add(item);
                cmIslem.DisplayMember = "items.Name";
            }
        }

        private int Cevir(string text)
        {
            return Convert.ToInt32(text);
        }
    }
}
