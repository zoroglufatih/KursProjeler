using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArr_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 10, 20, 45, 28, 77 };
            lsArray.Items.Clear();
            foreach (var item in sayilar)
            {
                lsArray.Items.Add(item);
            }
            
        }

        private void btnArray2_Click(object sender, EventArgs e)
        {
            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs" };
            lsArray.Items.Clear();
            foreach (var item in aylar)
            {
                lsArray.Items.Add(item);
            }
        }

        private void btnArL1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add("Portakal");
            arrayList.Add(300);
            arrayList.Remove(300);
            lsArrList.Items.Clear();
            foreach (var item in arrayList)
            {
                lsArrList.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(250);
            sayilar.Add(155);
            //sayilar.Remove(200);
            sayilar.RemoveAt(1);
            foreach (var item in sayilar)
            {
                lsBoxGen.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> aylar = new List<string>();
            aylar.Add("Ocak");
            aylar.Add("Şubat");
            aylar.Add("Mart");
            aylar.Add("Nisan");
            aylar.Add("Mayıs");
            aylar.Add("Haziran");
            aylar.RemoveAt(4);
            foreach (var item in aylar)
            {
                lsBoxGen.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Personel> plist = new List<Personel>();
            Personel p1 = new Personel();
            p1.Id = 1;
            p1.Ad = "Ali";
            p1.Maas = 2500m;
            Personel p2 = new Personel();
            p2.Id = 2;
            p2.Ad = "Ahmet";
            p2.Maas = 2500m;
            plist.Add(p1);
            plist.Add(p2);
            dataGridView1.DataSource = plist;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Label> llist = new List<Label>();
            for (int i = 1; i <= Convert.ToInt32(txtS1.Text); i++)
            {
                Label l = new Label();
                l.Text = i + ". Çocuk";
                llist.Add(l);
            }
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in llist)
            {
                this.flowLayoutPanel1.Controls.Add(item);
            }
        }
    }
}
