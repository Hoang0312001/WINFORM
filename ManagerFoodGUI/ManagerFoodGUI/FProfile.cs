﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerFoodGUI
{
    public partial class FProfile : Form
    {
        public FProfile()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("You want to come back table manager ", "Back", MessageBoxButtons.OKCancel);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
