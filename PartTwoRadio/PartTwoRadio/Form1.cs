using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartTwoRadio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void result(Panel panel, Label label)
        {
            RadioButton rd = null;
            foreach (RadioButton rdt in panel.Controls)
            {
                if (rdt.Checked)
                {
                    rd = rdt;
                    break;
                }
            }
            if(rd != null)
            {
                label.Text = rd.Text;
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            result(panel1, label1);
            result(panel2, label2);

        }

        private void ChangRS(object sender, EventArgs e)
        {
            // checked change
            RadioButton rd = sender as RadioButton;
            if (rd.Checked)
            {
                label1.Text = rd.Text;
            }
        }
    }
}
