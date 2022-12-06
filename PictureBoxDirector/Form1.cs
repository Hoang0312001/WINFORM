using System;
using System.Collections;
using System.Drawing;
using System.IO;



using System.Windows.Forms;

namespace PictureBoxDirector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedValueChanged += CbImageValueChange;
            getFileNameByFolder();
        }
        public void CbImageValueChange(Object sender , EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb != null)
            {
                Bitmap bm = new Bitmap(@"E:\VS_C#\Winform\PictureBoxDirector\Images\" + cb.Text);
                pictureBox2.Image = bm;
                txtfilename.Text = cb.Text;

            }
           
        }
        private void btnopenfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.png)|*.jpg;*.png;";
            if(open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
                txtfilename.Text = $"save thanh cong { Path.GetFileName(textBox1.Text)}";

            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            File.Copy(textBox1.Text, Path.Combine(@"E:\VS_C#\Winform\PictureBoxDirector\Images\" + Path.GetFileName(textBox1.Text)));
            txtfilename.Text = $"save thanh cong { Path.GetFileName(textBox1.Text)}";
            getFileNameByFolder();

        }
        public void getFileNameByFolder()
        {
            string[] files = Directory.GetFiles(@"E:\VS_C#\Winform\PictureBoxDirector\Images\");
            ArrayList MyArray = new ArrayList();
            foreach(var file in files)
            {
                MyArray.Add(Path.GetFileName(file));
            }
            comboBox1.DataSource = MyArray;
        }
    }
}
