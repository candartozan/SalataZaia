﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalataZaia.Desktop
{
    public partial class TusBilgiForm : Form
    {
        public TusBilgiForm()
        {
            InitializeComponent();
        }

        private void kapatmaButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}