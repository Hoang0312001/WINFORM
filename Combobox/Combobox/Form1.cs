using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class Form1 : Form
    {
        List<Food> foods;
        List<SinhVien> sv;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            bindingFoodByPrice();

            //sinhvien
            LoadDataSinhVien();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            List<Food> list = new List<Food>() {
             new Food() {name = "qua buoi", price = "2000" },
             new Food() {name = "qua tao", price = "5000" },
             new Food() {name = "qua le", price = "3000" }


            };

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "name";
        }

        private void ValueChange(object sender, EventArgs e)
        {
            /*ComboBox cb = sender as ComboBox;
            Food f = cb.SelectedValue as Food;
            label1.Text = f.price;*/
        }
        void bindingFoodByPrice()
        {
            label1.DataBindings.Add(new Binding("text", comboBox1.DataSource, "price"));
        }



        // Sinh Vien 


        void LoadDataSinhVien()
        {
            List<SinhVien> list = new List<SinhVien>() {
             new SinhVien() {khoa = "12a1", sv = new List<string>() { "a1","a2"} },
             new SinhVien() {khoa = "12a2",sv = new List<string>() { "a3","a4"}  },
             new SinhVien() {khoa = "12a3", sv = new List<string>() { "a5","a6"} }


            };
            cbkhoa.DataSource = list;
            cbkhoa.DisplayMember = "khoa";

        }

        private void ChangeValueCBKHOA(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SinhVien Obsv = cb.SelectedValue as SinhVien;

            cbsv.DataSource = Obsv.sv;

        }
    }


    class Food
    {
        public string name { set; get; }
        public string price { set; get; }
    }
    class SinhVien
    {
        public string khoa { set; get; }
        public List<String> sv { set; get; }
    }
}
