using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewList
{
    public partial class Form1 : Form
    {
        ImageList imageList;
        ImageList larimagelist;
        public Form1()
        {
            InitializeComponent();
            LoadImage();

            LoadListView();
        }
        void LoadImage()
        {
            imageList = new ImageList() {ImageSize =  new Size(68, 68) };
            imageList.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\ins.png"));
            imageList.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\ytb.png"));
            imageList.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\twi.png"));
            imageList.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\twi2.png"));
            string path = Application.StartupPath + "\\Images\\twi.png";


            /*            imageList1.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\twi.png"));
                        imageList1.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\twi2.png"));*/

            larimagelist = new ImageList() { ImageSize = new Size(16, 16) };
            larimagelist.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\ins.png"));
            larimagelist.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\ytb.png"));
            larimagelist.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\twi.png"));
            larimagelist.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\twi2.png"));

        }
        void LoadListView()
        {
            lview.FullRowSelect = true;
            lview.GridLines = true;
            lview.SmallImageList = imageList;
            lview.LargeImageList = larimagelist;
            lview.Columns.Add("Column1");
            lview.Columns.Add("Column2");

            lview.Columns.Add("Column3");
            lview.Columns.Add("Column4");
            ListViewItem lvt = new ListViewItem();
         
            lvt.Text = "Item1";
            lvt.ImageIndex = 0;

            ListViewItem lvt2 = new ListViewItem();
            lvt2.ImageIndex = 1;
            lvt2.SubItems.Add("subItem1");
            lvt2.SubItems.Add("subItem2");

            lvt2.Text = "Item2";

            ListViewItem lvt3 = new ListViewItem();
            lvt3.ImageIndex = 2;
            lvt3.Text = "Item3";

            ListViewItem lvt4 = new ListViewItem();
            lvt4.ImageIndex = 3;

            lvt4.Text = "Item4";

            lview.Items.Add(lvt);
            lview.Items.Add(lvt2);
            lview.Items.Add(lvt3);
            lview.Items.Add(lvt4);



            /*    lview.Items.Add("Item1");
                lview.Items.Add("Item2");
                lview.Items.Add("Item3");
                lview.Items.Add("Item4");*/

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lview.View = View.Details;
            lview.CheckBoxes = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lview.View = View.SmallIcon;
            lview.CheckBoxes = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lview.View = View.LargeIcon;


        }

        private void lview_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lvt = sender as ListView;
            if(lvt.SelectedItems.Count > 0)
            {
                foreach (ListViewItem itemtext in lview.SelectedItems)
                {
                /*    ListViewItem item = itemtext.ToString();*/
                    MessageBox.Show(itemtext.Text);
                }
              
            }
        }
    }
}
