﻿using IleriPersonel.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriPersonel
{
    public partial class FrmTemel : Form
    {
        PersonelContext db = new PersonelContext();
        public FrmTemel()
        {
            InitializeComponent();
        }
    }
}