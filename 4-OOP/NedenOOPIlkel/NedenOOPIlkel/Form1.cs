using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NedenOOPIlkel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Idler = { 100, 50, 5 };
        string[] Isimler = { "Ali", "Veli", "Ayşe" };
        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                int indis = Convert.ToInt32(txtBoxId.Text);
                int index = Array.IndexOf(Idler, indis);
                txtBoxAd.Text = Isimler[index];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
