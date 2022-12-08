using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyIconGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(5000,"day la notify",textb.Text,ToolTipIcon.Warning);
        }

     
        private void textb_TextChanged(object sender, EventArgs e)
        {
            textb.Text = notifyIcon1.Text;
        }
    }
}
