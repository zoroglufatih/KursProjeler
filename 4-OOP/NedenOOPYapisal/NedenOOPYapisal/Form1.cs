using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NedenOOPYapisal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = { "Ali", "Veli", "Ayşe" };
        int[] Idler = { 1, 2, 3 };
        private void btnGonder_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtBoxId.Text);
            if(id == 1)
            {
                txtBoxAd.Text = "Ali";
            }
            else if (id == 2)
            {
                txtBoxAd.Text = "Veli";
            }
            else if(id == 3)
            {
                txtBoxAd.Text = "Ayşe";
            }
            else
            {
                txtBoxAd.Text = "Yanlış Id";
            }
        }
    }
}
