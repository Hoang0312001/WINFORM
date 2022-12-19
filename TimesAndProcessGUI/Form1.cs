using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimesAndProcessGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            button1.Text = button1.Text == "STOP" ? "STOP" : "START";
        }
        int i = 0;
        int value = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
         
            value+= 10;
           
            if(value == 100)
            {
                i++;
                value = 0;
            }
            label1.Text = i.ToString();
            progressBar1.Value = value;
            timer1.Interval = 500;
          
        }
    }
}
