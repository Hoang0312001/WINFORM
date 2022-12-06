using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* AddButton();
             Button btn = sender as Button;
             MessageBox.Show(btn.Text);*/

            /*     string checkresult = check.CheckState == CheckState.Checked ? "dung la " : check.CheckState == CheckState.Unchecked ? "Khong phai" : "vua phai vua khong";
                 string result = $"ban {checkresult} {txtnum.Text}";
                 MessageBox.Show(result);*/
            DialogResult  rs =  MessageBox.Show("Noi dung", "title", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                MessageBox.Show("chon oke");
            }




        }
        int i = 0;
        void AddButton()
        {
            Random rd = new Random();

            Button btn = new Button() { Text = i.ToString(), Location = new Point(rd.Next(0, this.Size.Width), rd.Next(0, this.Size.Height)) };
            this.Controls.Add(btn);
            i++;


        }

        private void TxtChange(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(txtnum.Text, out num))
            {

                kq.Text = (num * num).ToString();

            }
            else
            {
                kq.Text = " nhap so nhe";
            }

        }
    }
}
