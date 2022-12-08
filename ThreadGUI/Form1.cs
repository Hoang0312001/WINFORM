using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(CountNumber);
            Thread t2 = new Thread(MoveImage);


            t.Start();
            t2.Start();
            
        }
        int count= 0;
        void CountNumber()
        {
            while (true)
            {
                label1.Text = count.ToString();
                count++;
                Thread.Sleep(1000);
            }

        }
        void MoveImage()
        {
            while (true)
            {
                if (checkBox1.Checked)
                {
                    pictureBox1.Location = (new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y));
                    Thread.Sleep(1000);
                }
                else
                {
                    pictureBox1.Location = (new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y));
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
