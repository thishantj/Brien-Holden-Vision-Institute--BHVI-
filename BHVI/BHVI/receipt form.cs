﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHVI
{
    public partial class receipt_form : Form
    {
        public receipt_form()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormsHomepage f = new FormsHomepage();
            f.Show(this);
            this.Hide();
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }
    }
}
