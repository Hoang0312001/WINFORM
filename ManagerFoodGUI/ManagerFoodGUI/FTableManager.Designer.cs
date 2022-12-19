namespace ManagerFoodGUI
{
    partial class FTableManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.fpanelTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numcount = new System.Windows.Forms.NumericUpDown();
            this.btnorder = new System.Windows.Forms.Button();
            this.cbfood = new System.Windows.Forms.ComboBox();
            this.txtcategory = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsale = new System.Windows.Forms.Button();
            this.numricsale = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lvbillinfor = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFILEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numcount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numricsale)).BeginInit();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fpanelTable);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(7, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 623);
            this.panel1.TabIndex = 0;
            // 
            // fpanelTable
            // 
            this.fpanelTable.Location = new System.Drawing.Point(5, 2);
            this.fpanelTable.Name = "fpanelTable";
            this.fpanelTable.Size = new System.Drawing.Size(611, 617);
            this.fpanelTable.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(622, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numcount);
            this.panel3.Controls.Add(this.btnorder);
            this.panel3.Controls.Add(this.cbfood);
            this.panel3.Controls.Add(this.txtcategory);
            this.panel3.Location = new System.Drawing.Point(632, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 60);
            this.panel3.TabIndex = 1;
            // 
            // numcount
            // 
            this.numcount.Location = new System.Drawing.Point(248, 18);
            this.numcount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numcount.Name = "numcount";
            this.numcount.Size = new System.Drawing.Size(57, 20);
            this.numcount.TabIndex = 3;
            this.numcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnorder
            // 
            this.btnorder.Enabled = false;
            this.btnorder.Location = new System.Drawing.Point(339, 6);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(87, 48);
            this.btnorder.TabIndex = 2;
            this.btnorder.Text = "ORDER";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // cbfood
            // 
            this.cbfood.FormattingEnabled = true;
            this.cbfood.Location = new System.Drawing.Point(3, 30);
            this.cbfood.Name = "cbfood";
            this.cbfood.Size = new System.Drawing.Size(231, 21);
            this.cbfood.TabIndex = 1;
            // 
            // txtcategory
            // 
            this.txtcategory.FormattingEnabled = true;
            this.txtcategory.Location = new System.Drawing.Point(3, 3);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(231, 21);
            this.txtcategory.TabIndex = 0;
            this.txtcategory.SelectedIndexChanged += new System.EventHandler(this.txtcategory_SelectedIndexChanged);
            this.txtcategory.SelectedValueChanged += new System.EventHandler(this.txtcategory_SelectedValueChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txttotalprice);
            this.panel4.Controls.Add(this.comboBox3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btnsale);
            this.panel4.Controls.Add(this.numricsale);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(629, 552);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(432, 88);
            this.panel4.TabIndex = 2;
            // 
            // txttotalprice
            // 
            this.txttotalprice.Location = new System.Drawing.Point(208, 34);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Size = new System.Drawing.Size(128, 20);
            this.txttotalprice.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(23, 47);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(103, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 22);
            this.button2.TabIndex = 7;
            this.button2.Text = "TRANFER TABLE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnsale
            // 
            this.btnsale.Location = new System.Drawing.Point(132, 19);
            this.btnsale.Name = "btnsale";
            this.btnsale.Size = new System.Drawing.Size(70, 22);
            this.btnsale.TabIndex = 6;
            this.btnsale.Text = "SALE";
            this.btnsale.UseVisualStyleBackColor = true;
            this.btnsale.Click += new System.EventHandler(this.btnsale_Click);
            // 
            // numricsale
            // 
            this.numricsale.Location = new System.Drawing.Point(135, 47);
            this.numricsale.Name = "numricsale";
            this.numricsale.Size = new System.Drawing.Size(67, 20);
            this.numricsale.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Checkout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lvbillinfor);
            this.panel5.Location = new System.Drawing.Point(633, 96);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(428, 450);
            this.panel5.TabIndex = 3;
            // 
            // lvbillinfor
            // 
            this.lvbillinfor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lvbillinfor.FullRowSelect = true;
            this.lvbillinfor.GridLines = true;
            this.lvbillinfor.HideSelection = false;
            this.lvbillinfor.Location = new System.Drawing.Point(0, 3);
            this.lvbillinfor.Name = "lvbillinfor";
            this.lvbillinfor.Size = new System.Drawing.Size(425, 447);
            this.lvbillinfor.TabIndex = 0;
            this.lvbillinfor.UseCompatibleStateImageBehavior = false;
            this.lvbillinfor.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Món ";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 3;
            this.columnHeader1.Text = "Đơn Gía";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Số Lượng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 107;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINToolStripMenuItem,
            this.pROFILEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aDMINToolStripMenuItem
            // 
            this.aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            this.aDMINToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aDMINToolStripMenuItem.Text = "ADMIN";
            this.aDMINToolStripMenuItem.Click += new System.EventHandler(this.aDMINToolStripMenuItem_Click);
            // 
            // pROFILEToolStripMenuItem
            // 
            this.pROFILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROFILEToolStripMenuItem1,
            this.lOGOUTToolStripMenuItem});
            this.pROFILEToolStripMenuItem.Name = "pROFILEToolStripMenuItem";
            this.pROFILEToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.pROFILEToolStripMenuItem.Text = "ACCOUNT";
            // 
            // pROFILEToolStripMenuItem1
            // 
            this.pROFILEToolStripMenuItem1.Name = "pROFILEToolStripMenuItem1";
            this.pROFILEToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.pROFILEToolStripMenuItem1.Text = "PROFILE";
            this.pROFILEToolStripMenuItem1.Click += new System.EventHandler(this.pROFILEToolStripMenuItem1_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            // 
            // FTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 648);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FTableManager";
            this.Text = "FTableManager";
            this.Load += new System.EventHandler(this.FTableManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numcount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numricsale)).EndInit();
            this.panel5.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROFILEToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numcount;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.ComboBox cbfood;
        private System.Windows.Forms.ComboBox txtcategory;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsale;
        private System.Windows.Forms.NumericUpDown numricsale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvbillinfor;
        private System.Windows.Forms.ToolStripMenuItem pROFILEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel fpanelTable;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txttotalprice;
    }
}