using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConTextMenuStripGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void LoadMenuStrip()
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            var item = new ToolStripComboBox();
            item.Items.Add("menu");
            contextMenuStrip.Items.Add("menu");
            contextMenuStrip.Items.Add("show");
            contextMenuStrip.Items.Add(item);

         
            contextMenuStrip.Show(50, 50);

        }
        private void contextMenuStrip1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            contextMenuStrip1.Show(textBox1,new Point(50,50));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadMenuStrip();
        }
    }
}
