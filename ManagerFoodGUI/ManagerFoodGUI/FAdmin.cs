using ManagerFoodGUI.DTO;
using ManagerFoodGUI.mapper;
using ManagerFoodGUI.service;
using ManagerFoodGUI.service.impl;
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
    
    public partial class FAdmin : Form
    {
         private  IAccountService accountService;

        public FAdmin()
        {

            InitializeComponent();
            LoadAccount();
        }
        public void LoadAccount()
        {
            dtgvAccount.DataSource = AccountService.getAll();
            
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {

        }

        private void tabSales_Click(object sender, EventArgs e)
        {
           

        }

        private void btnstat_Click(object sender, EventArgs e)
        {
            DateTime endDate = DateTime.Parse(txtdateEnd.Value.ToString("dd-MM-yyyy"));
            DateTime startDate = DateTime.Parse(txtdatestart.Value.ToString("dd-MM-yyyy"));

            List<SalesDTO> list = service.BillService.Sales(txtdatestart.Value, txtdateEnd.Value);
   
            dtgvsales.DataSource = list;
        }
    }
}
