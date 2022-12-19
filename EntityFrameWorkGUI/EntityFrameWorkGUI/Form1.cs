using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameWorkGUI
{
    public partial class Form1 : Form
    {
        SHOPEntities entities = new SHOPEntities();
        public Form1()
        {
            InitializeComponent();
        }
        void LoadData()
        {
           
            var product = from p in entities.Products select new {p.Id,p.ProductName,p.Price};
            dataGridView1.DataSource = product.ToList();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            LoadData();
            DataBinding();
        }
        void DataBinding()
        {
           /* comboBox1.DataBindings.Add(new Binding("DataSource", dataGridView1.DataSource, "ID"));
            comboBox2.DataBindings.Add(new Binding("DataSource", dataGridView1.DataSource, "ProductName"));*/
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = "DELL";
            product.Provider = "KOREA";
            product.Price = 100;

            Category category = new Category();
            category.NAME = "Category";
            category.Description = "Description";

            product.Category = category;

            entities.Products.Add(product);

            entities.SaveChanges();
            LoadData();


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
           
            int id = 4;
            int ids = Convert.ToInt32(dataGridView1.Columns["ID"].ToString());
            textBox1.Text = ids.ToString();
          /*  var prodcuct = (from p in entities.Products where p.Id == ids select p).FirstOrDefault();
            if(prodcuct != null )
            {
                prodcuct.ProductName = textBox1.Text;
                entities.SaveChanges();
                LoadData();
            }*/
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            int id = 4;
            int ids = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            var prodcuct = (from p in entities.Products where p.Id == ids select p).FirstOrDefault();
            if (prodcuct != null)
            {
                entities.Products.Remove(prodcuct);
                entities.SaveChanges();
                LoadData();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
          if(dataGridView1.SelectedRows.Count > 0)
            {
                int ids = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                string name =dataGridView1.SelectedCells[2].Value.ToString();
                textBox1.Text = ids.ToString();
                textBox2.Text = name.ToString();
            }
        }
    }
}
