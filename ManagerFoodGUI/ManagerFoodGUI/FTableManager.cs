using ManagerFoodGUI.DTO;
using ManagerFoodGUI.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerFoodGUI
{
    public partial class FTableManager : Form
    {
        public FTableManager()
        {
            InitializeComponent();
            LoadTable();
            loadCategory();
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = cultureInfo;




        }
        /*  LOAD DATA */
        void LoadTable()
        {
            List<TableDTO> list = TableService.getAll();
            foreach (TableDTO table in list)
            {
                Button button = new Button() { Width = 100, Height = 70 };
                string status = table.Status == 0 ? "Bàn trống" : "Đã Có Người";
                button.BackColor = table.Status == 0 ? Color.Red : Color.Aqua;
                button.Text = table.Name + Environment.NewLine + status;
                button.Tag = table;
                button.Click += btnshowbill_click;
                fpanelTable.Controls.Add(button);
            }
        }
        void ShowBill(int idTable)
        {
            List<BillInforDTO> list = BillInforService.getAllInnerFoodAndBill(idTable);

            if (list.Count > 0)
            {
                int i = 0;
                int totalAllPrice = 0;
                foreach (var item in list)
                {
                    int totalPrice = item.Count * item.FoodDTO1.Price;
                    totalAllPrice += totalPrice;
                    lvbillinfor.Items.Add((i + 1).ToString());
                    lvbillinfor.Items[i].SubItems.Add(item.FoodDTO1.Name);
                    lvbillinfor.Items[i].SubItems.Add(item.Count.ToString());
                    lvbillinfor.Items[i].SubItems.Add(item.FoodDTO1.Price.ToString());
                    lvbillinfor.Items[i].SubItems.Add(totalPrice.ToString());
                    lvbillinfor.Tag = idTable;

                    i++;
                }

                txttotalprice.Text = totalAllPrice.ToString();
            }



        }
        void loadFood(int idCategory)
        {
            cbfood.DataSource = FoodService.FindByIdCategory(idCategory);
            cbfood.DisplayMember = "name";
            cbfood.ValueMember = "id";
        }
        void loadCategory()
        {
            txtcategory.DataSource = CategoryService.GetAll();
            txtcategory.Tag = CategoryService.GetAll();
            txtcategory.DisplayMember = "name";
            txtcategory.ValueMember = "id";
        }


        /*
         END LOAD DATA*/
        /*  EVENT*/
        private void pROFILEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FProfile fProfile = new FProfile();
            this.Hide();
            fProfile.ShowDialog();
            this.Show();

        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAdmin fAdmin = new FAdmin();
            this.Hide();
            fAdmin.ShowDialog();
            this.Show();
        }

        void btnshowbill_click(object sender, EventArgs e)
        {
            lvbillinfor.Items.Clear();
            txttotalprice.Text = "";
            int tableId = ((sender as Button).Tag as TableDTO).Id;
            btnorder.Tag = tableId;
            ShowBill(tableId);
            btnorder.Enabled = true;


        }




        private void txtcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcategory_SelectedValueChanged(object sender, EventArgs e)
        {
            int idCategory = 0;
            if (int.TryParse(txtcategory.SelectedValue.ToString(), out idCategory))
            {
                loadFood(idCategory);
            }
        }

        private void FTableManager_Load(object sender, EventArgs e)
        {

        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            if (btnorder.Tag != null)
            {
                lvbillinfor.Items.Clear();

                int tableId = Int32.Parse(btnorder.Tag.ToString());
                int foodId = Int32.Parse(cbfood.SelectedValue.ToString());
                int count = Int32.Parse(numcount.Value.ToString());
                BillDTO billDTO = new BillDTO(DateTime.Now, tableId, 1);
                BillService.Order(billDTO, foodId, count);
                ShowBill(tableId);
                MessageBox.Show(DateTime.Now.ToString());
                fpanelTable.Controls.Clear();
                LoadTable();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn");
            }







        }

        private void btnsale_Click(object sender, EventArgs e)
        {
            if (lvbillinfor.Tag != null)
            {
                int priceTotal = Int32.Parse(txttotalprice.Text);

                float sale = Int32.Parse(numricsale.Value.ToString());
                float priceTotalSale = priceTotal - (priceTotal * (sale / 100));

                txttotalprice.Text = priceTotalSale.ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lvbillinfor.Tag != null)
            {

                int tableId = Int32.Parse(lvbillinfor.Tag.ToString());
                BillService.Checkout(tableId);
                lvbillinfor.Items.Clear();
                fpanelTable.Controls.Clear();
                LoadTable();

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn thanh toán");
            }


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }




        /*   END EVENT*/
    }
}
