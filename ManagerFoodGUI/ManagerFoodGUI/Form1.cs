using ManagerFoodGUI.service;
using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FTableManager fTable = new FTableManager();
            bool rs = AccountService.findAccountByUserName(txtusername.Text,txtpassword.Text);
            if (rs == true)
            {
                this.Hide();
                fTable.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Login fail");
            }
           
          
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
          DialogResult =   MessageBox.Show("You want to exit program ","EXIT",MessageBoxButtons.OKCancel);
            if(DialogResult == DialogResult.OK)
            {
                this.Close();
            }
          
        }
    }
}
