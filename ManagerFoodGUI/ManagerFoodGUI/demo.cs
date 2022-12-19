using ManagerFoodGUI.DTO;
using ManagerFoodGUI.valid;
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
    public partial class demo : Form
    {
        public demo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountDTO accountDTO = new AccountDTO();
            accountDTO.UserName = textBox1.Text;
            accountDTO.FullName = textBox2.Text;
            accountDTO.PassWord = textBox3.Text;
            var valid = Validations<AccountDTO>.Check(accountDTO);
            foreach(var v in valid)
            {
                label1.Text += v.ErrorMessage;
            }
        }
    }
}
