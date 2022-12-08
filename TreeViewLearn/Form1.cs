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

namespace TreeViewLearn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*LoadData();*/
            string hardWareD = @"D:\";
            if (Directory.Exists(hardWareD))
            {
                TreeNode tns = new TreeNode();
                tns.Text = hardWareD;
                treeView1.Nodes.Add(tns);
                CrowDriveD(tns);
            }
        }

        void CrowDriveD(TreeNode root)
        {
        
            if (root == null) return;
            try
            {
                var folderList = new DirectoryInfo(root.Text).GetDirectories();
                if (folderList.Count() == 0) return;
                foreach(DirectoryInfo foder in folderList)
                {
                    if (Directory.Exists(foder.FullName))
                    {
                        TreeNode node = new TreeNode();
                        node.Text = foder.FullName;
                        root.Nodes.Add(node);
                        CrowDriveD(node);
                    }
                  

                }
            }
            catch 
            {
                return;
            }
        }
        /*       void LoadData()
               {
                   TreeNode tn = new TreeNode();
                   tn.Text = "Node 1";
                   tn.Nodes.Add("subnode");

                   treeView1.Nodes.Add(tn);
               }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
