namespace SQLServerTest
{
    partial class FormBuyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuyer));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBuy = new System.Windows.Forms.TabPage();
            this.dataGridViewBuy = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxPSupplier = new System.Windows.Forms.ComboBox();
            this.comboBoxPBuyer = new System.Windows.Forms.ComboBox();
            this.labelPbuyer = new System.Windows.Forms.Label();
            this.labelPamount = new System.Windows.Forms.Label();
            this.labelPprice = new System.Windows.Forms.Label();
            this.labelPsupplier = new System.Windows.Forms.Label();
            this.labelPspecification = new System.Windows.Forms.Label();
            this.labelPname = new System.Windows.Forms.Label();
            this.labelPno = new System.Windows.Forms.Label();
            this.textBoxPamount = new System.Windows.Forms.TextBox();
            this.textBoxPprice = new System.Windows.Forms.TextBox();
            this.textBoxPspecification = new System.Windows.Forms.TextBox();
            this.textBoxPname = new System.Windows.Forms.TextBox();
            this.textBoxPno = new System.Windows.Forms.TextBox();
            this.buttonGenerateOrder = new System.Windows.Forms.Button();
            this.buttonSelectOrder = new System.Windows.Forms.Button();
            this.tabPageCheck = new System.Windows.Forms.TabPage();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonQueryAll = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxInBookTime2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxInbookTime1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStockName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStockId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.buttonUpdatePwd = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTopic = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPageBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuy)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPageCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopic)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBuy);
            this.tabControl1.Controls.Add(this.tabPageCheck);
            this.tabControl1.Location = new System.Drawing.Point(174, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(993, 503);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageBuy
            // 
            this.tabPageBuy.Controls.Add(this.dataGridViewBuy);
            this.tabPageBuy.Controls.Add(this.panel3);
            this.tabPageBuy.Location = new System.Drawing.Point(4, 25);
            this.tabPageBuy.Name = "tabPageBuy";
            this.tabPageBuy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuy.Size = new System.Drawing.Size(985, 474);
            this.tabPageBuy.TabIndex = 0;
            this.tabPageBuy.Text = "采购管理";
            this.tabPageBuy.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBuy
            // 
            this.dataGridViewBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuy.Location = new System.Drawing.Point(0, 241);
            this.dataGridViewBuy.Name = "dataGridViewBuy";
            this.dataGridViewBuy.RowTemplate.Height = 27;
            this.dataGridViewBuy.Size = new System.Drawing.Size(985, 230);
            this.dataGridViewBuy.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBoxPSupplier);
            this.panel3.Controls.Add(this.comboBoxPBuyer);
            this.panel3.Controls.Add(this.labelPbuyer);
            this.panel3.Controls.Add(this.labelPamount);
            this.panel3.Controls.Add(this.labelPprice);
            this.panel3.Controls.Add(this.labelPsupplier);
            this.panel3.Controls.Add(this.labelPspecification);
            this.panel3.Controls.Add(this.labelPname);
            this.panel3.Controls.Add(this.labelPno);
            this.panel3.Controls.Add(this.textBoxPamount);
            this.panel3.Controls.Add(this.textBoxPprice);
            this.panel3.Controls.Add(this.textBoxPspecification);
            this.panel3.Controls.Add(this.textBoxPname);
            this.panel3.Controls.Add(this.textBoxPno);
            this.panel3.Controls.Add(this.buttonGenerateOrder);
            this.panel3.Controls.Add(this.buttonSelectOrder);
            this.panel3.Location = new System.Drawing.Point(6, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 231);
            this.panel3.TabIndex = 3;
            // 
            // comboBoxPSupplier
            // 
            this.comboBoxPSupplier.FormattingEnabled = true;
            this.comboBoxPSupplier.Items.AddRange(new object[] {
            "鑫鑫水果园",
            "洪田蔬菜园",
            "新发地禽类养殖基地"});
            this.comboBoxPSupplier.Location = new System.Drawing.Point(433, 31);
            this.comboBoxPSupplier.Name = "comboBoxPSupplier";
            this.comboBoxPSupplier.Size = new System.Drawing.Size(162, 23);
            this.comboBoxPSupplier.TabIndex = 17;
            // 
            // comboBoxPBuyer
            // 
            this.comboBoxPBuyer.FormattingEnabled = true;
            this.comboBoxPBuyer.Items.AddRange(new object[] {
            "张洪隆",
            "赵晓彤",
            "温俊楠",
            "刘子楠",
            "张国栋",
            "海贼王"});
            this.comboBoxPBuyer.Location = new System.Drawing.Point(127, 165);
            this.comboBoxPBuyer.Name = "comboBoxPBuyer";
            this.comboBoxPBuyer.Size = new System.Drawing.Size(158, 23);
            this.comboBoxPBuyer.TabIndex = 16;
            // 
            // labelPbuyer
            // 
            this.labelPbuyer.AutoSize = true;
            this.labelPbuyer.Location = new System.Drawing.Point(55, 169);
            this.labelPbuyer.Name = "labelPbuyer";
            this.labelPbuyer.Size = new System.Drawing.Size(52, 15);
            this.labelPbuyer.TabIndex = 15;
            this.labelPbuyer.Text = "采购员";
            // 
            // labelPamount
            // 
            this.labelPamount.AutoSize = true;
            this.labelPamount.Location = new System.Drawing.Point(345, 130);
            this.labelPamount.Name = "labelPamount";
            this.labelPamount.Size = new System.Drawing.Size(67, 15);
            this.labelPamount.TabIndex = 14;
            this.labelPamount.Text = "购买数量";
            // 
            // labelPprice
            // 
            this.labelPprice.AutoSize = true;
            this.labelPprice.Location = new System.Drawing.Point(375, 84);
            this.labelPprice.Name = "labelPprice";
            this.labelPprice.Size = new System.Drawing.Size(37, 15);
            this.labelPprice.TabIndex = 13;
            this.labelPprice.Text = "单价";
            // 
            // labelPsupplier
            // 
            this.labelPsupplier.AutoSize = true;
            this.labelPsupplier.Location = new System.Drawing.Point(360, 38);
            this.labelPsupplier.Name = "labelPsupplier";
            this.labelPsupplier.Size = new System.Drawing.Size(52, 15);
            this.labelPsupplier.TabIndex = 12;
            this.labelPsupplier.Text = "供应商";
            // 
            // labelPspecification
            // 
            this.labelPspecification.AutoSize = true;
            this.labelPspecification.Location = new System.Drawing.Point(75, 123);
            this.labelPspecification.Name = "labelPspecification";
            this.labelPspecification.Size = new System.Drawing.Size(37, 15);
            this.labelPspecification.TabIndex = 11;
            this.labelPspecification.Text = "规格";
            // 
            // labelPname
            // 
            this.labelPname.AutoSize = true;
            this.labelPname.Location = new System.Drawing.Point(54, 77);
            this.labelPname.Name = "labelPname";
            this.labelPname.Size = new System.Drawing.Size(67, 15);
            this.labelPname.TabIndex = 10;
            this.labelPname.Text = "货物名称";
            // 
            // labelPno
            // 
            this.labelPno.AutoSize = true;
            this.labelPno.Location = new System.Drawing.Point(54, 34);
            this.labelPno.Name = "labelPno";
            this.labelPno.Size = new System.Drawing.Size(67, 15);
            this.labelPno.TabIndex = 9;
            this.labelPno.Text = "订单编号";
            // 
            // textBoxPamount
            // 
            this.textBoxPamount.Location = new System.Drawing.Point(433, 120);
            this.textBoxPamount.Name = "textBoxPamount";
            this.textBoxPamount.Size = new System.Drawing.Size(163, 25);
            this.textBoxPamount.TabIndex = 7;
            // 
            // textBoxPprice
            // 
            this.textBoxPprice.Location = new System.Drawing.Point(433, 74);
            this.textBoxPprice.Name = "textBoxPprice";
            this.textBoxPprice.Size = new System.Drawing.Size(163, 25);
            this.textBoxPprice.TabIndex = 6;
            // 
            // textBoxPspecification
            // 
            this.textBoxPspecification.Location = new System.Drawing.Point(127, 120);
            this.textBoxPspecification.Name = "textBoxPspecification";
            this.textBoxPspecification.Size = new System.Drawing.Size(158, 25);
            this.textBoxPspecification.TabIndex = 4;
            // 
            // textBoxPname
            // 
            this.textBoxPname.Location = new System.Drawing.Point(127, 74);
            this.textBoxPname.Name = "textBoxPname";
            this.textBoxPname.Size = new System.Drawing.Size(158, 25);
            this.textBoxPname.TabIndex = 3;
            // 
            // textBoxPno
            // 
            this.textBoxPno.Location = new System.Drawing.Point(127, 28);
            this.textBoxPno.Name = "textBoxPno";
            this.textBoxPno.Size = new System.Drawing.Size(158, 25);
            this.textBoxPno.TabIndex = 2;
            // 
            // buttonGenerateOrder
            // 
            this.buttonGenerateOrder.Location = new System.Drawing.Point(782, 104);
            this.buttonGenerateOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGenerateOrder.Name = "buttonGenerateOrder";
            this.buttonGenerateOrder.Size = new System.Drawing.Size(120, 34);
            this.buttonGenerateOrder.TabIndex = 1;
            this.buttonGenerateOrder.Text = "加入订单";
            this.buttonGenerateOrder.UseVisualStyleBackColor = true;
            // 
            // buttonSelectOrder
            // 
            this.buttonSelectOrder.Location = new System.Drawing.Point(782, 34);
            this.buttonSelectOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelectOrder.Name = "buttonSelectOrder";
            this.buttonSelectOrder.Size = new System.Drawing.Size(120, 30);
            this.buttonSelectOrder.TabIndex = 0;
            this.buttonSelectOrder.Text = "查询采购订单";
            this.buttonSelectOrder.UseVisualStyleBackColor = true;
            // 
            // tabPageCheck
            // 
            this.tabPageCheck.Controls.Add(this.dataGridViewInfo);
            this.tabPageCheck.Controls.Add(this.panel1);
            this.tabPageCheck.Location = new System.Drawing.Point(4, 25);
            this.tabPageCheck.Name = "tabPageCheck";
            this.tabPageCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheck.Size = new System.Drawing.Size(985, 474);
            this.tabPageCheck.TabIndex = 1;
            this.tabPageCheck.Text = "信息查询";
            this.tabPageCheck.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(0, 200);
            this.dataGridViewInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.RowTemplate.Height = 27;
            this.dataGridViewInfo.Size = new System.Drawing.Size(985, 241);
            this.dataGridViewInfo.TabIndex = 53;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonQueryAll);
            this.panel1.Controls.Add(this.buttonSelect);
            this.panel1.Controls.Add(this.comboBoxSupplier);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBoxInBookTime2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBoxInbookTime1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxStockName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxStockId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 191);
            this.panel1.TabIndex = 17;
            // 
            // buttonQueryAll
            // 
            this.buttonQueryAll.Location = new System.Drawing.Point(555, 88);
            this.buttonQueryAll.Name = "buttonQueryAll";
            this.buttonQueryAll.Size = new System.Drawing.Size(129, 31);
            this.buttonQueryAll.TabIndex = 11;
            this.buttonQueryAll.Text = "查询所有商品";
            this.buttonQueryAll.UseVisualStyleBackColor = true;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(408, 88);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(132, 31);
            this.buttonSelect.TabIndex = 10;
            this.buttonSelect.Text = "查询";
            this.buttonSelect.UseVisualStyleBackColor = true;
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Items.AddRange(new object[] {
            "鑫鑫水果园",
            "洪田蔬菜园 ",
            "新发地禽类养殖基地"});
            this.comboBoxSupplier.Location = new System.Drawing.Point(408, 13);
            this.comboBoxSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(132, 23);
            this.comboBoxSupplier.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "供货商";
            // 
            // comboBoxInBookTime2
            // 
            this.comboBoxInBookTime2.FormattingEnabled = true;
            this.comboBoxInBookTime2.Items.AddRange(new object[] {
            "2017-01",
            "2017-02",
            "2017-03",
            "2017-04",
            "2017-05",
            "2017-06",
            "2017-07",
            "2017-08",
            "2017-09",
            "2017-10",
            "2017-11",
            "2017-12"});
            this.comboBoxInBookTime2.Location = new System.Drawing.Point(213, 96);
            this.comboBoxInBookTime2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxInBookTime2.Name = "comboBoxInBookTime2";
            this.comboBoxInBookTime2.Size = new System.Drawing.Size(91, 23);
            this.comboBoxInBookTime2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "至";
            // 
            // comboBoxInbookTime1
            // 
            this.comboBoxInbookTime1.FormattingEnabled = true;
            this.comboBoxInbookTime1.Items.AddRange(new object[] {
            "2017-01",
            "2017-02",
            "2017-03",
            "2017-04",
            "2017-05",
            "2017-06",
            "2017-07",
            "2017-08",
            "2017-09",
            "2017-10",
            "2017-11",
            "2017-12"});
            this.comboBoxInbookTime1.Location = new System.Drawing.Point(102, 96);
            this.comboBoxInbookTime1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxInbookTime1.Name = "comboBoxInbookTime1";
            this.comboBoxInbookTime1.Size = new System.Drawing.Size(76, 23);
            this.comboBoxInbookTime1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "入库时间";
            // 
            // textBoxStockName
            // 
            this.textBoxStockName.Location = new System.Drawing.Point(102, 56);
            this.textBoxStockName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStockName.Name = "textBoxStockName";
            this.textBoxStockName.Size = new System.Drawing.Size(202, 25);
            this.textBoxStockName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "商品名称";
            // 
            // textBoxStockId
            // 
            this.textBoxStockId.Location = new System.Drawing.Point(102, 13);
            this.textBoxStockId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStockId.Name = "textBoxStockId";
            this.textBoxStockId.Size = new System.Drawing.Size(202, 25);
            this.textBoxStockId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "商品编号";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Image = global::SQLServerTest.Properties.Resources.关于__1_;
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.Location = new System.Drawing.Point(3, 418);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(169, 43);
            this.buttonAbout.TabIndex = 54;
            this.buttonAbout.Text = "关于";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Image = global::SQLServerTest.Properties.Resources.采购24;
            this.buttonPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPurchase.Location = new System.Drawing.Point(3, 85);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(169, 48);
            this.buttonPurchase.TabIndex = 3;
            this.buttonPurchase.Text = "采购管理";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // buttonUpdatePwd
            // 
            this.buttonUpdatePwd.Image = global::SQLServerTest.Properties.Resources.password_24px_1169936_easyicon_net;
            this.buttonUpdatePwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdatePwd.Location = new System.Drawing.Point(3, 311);
            this.buttonUpdatePwd.Name = "buttonUpdatePwd";
            this.buttonUpdatePwd.Size = new System.Drawing.Size(169, 48);
            this.buttonUpdatePwd.TabIndex = 5;
            this.buttonUpdatePwd.Text = "修改密码";
            this.buttonUpdatePwd.UseVisualStyleBackColor = true;
            this.buttonUpdatePwd.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Image = global::SQLServerTest.Properties.Resources.查询24;
            this.buttonCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheck.Location = new System.Drawing.Point(3, 204);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(169, 48);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "信息查询";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // label1
            // 
            this.label1.Image = global::SQLServerTest.Properties.Resources.工作界面_0000s_0003_功能选择面板;
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 509);
            this.label1.TabIndex = 1;
            // 
            // pictureBoxTopic
            // 
            this.pictureBoxTopic.Image = global::SQLServerTest.Properties.Resources.工作界面_0002s_0001_标题栏;
            this.pictureBoxTopic.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxTopic.Name = "pictureBoxTopic";
            this.pictureBoxTopic.Size = new System.Drawing.Size(1164, 50);
            this.pictureBoxTopic.TabIndex = 0;
            this.pictureBoxTopic.TabStop = false;
            // 
            // FormBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 562);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonPurchase);
            this.Controls.Add(this.buttonUpdatePwd);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxTopic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBuyer";
            this.Text = "仓库管理系统";
            this.tabControl1.ResumeLayout(false);
            this.tabPageBuy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuy)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPageCheck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBuy;
        private System.Windows.Forms.TabPage tabPageCheck;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonUpdatePwd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxPSupplier;
        private System.Windows.Forms.ComboBox comboBoxPBuyer;
        private System.Windows.Forms.Label labelPbuyer;
        private System.Windows.Forms.Label labelPamount;
        private System.Windows.Forms.Label labelPprice;
        private System.Windows.Forms.Label labelPsupplier;
        private System.Windows.Forms.Label labelPspecification;
        private System.Windows.Forms.Label labelPname;
        private System.Windows.Forms.Label labelPno;
        private System.Windows.Forms.TextBox textBoxPamount;
        private System.Windows.Forms.TextBox textBoxPprice;
        private System.Windows.Forms.TextBox textBoxPspecification;
        private System.Windows.Forms.TextBox textBoxPname;
        private System.Windows.Forms.TextBox textBoxPno;
        private System.Windows.Forms.Button buttonGenerateOrder;
        private System.Windows.Forms.Button buttonSelectOrder;
        private System.Windows.Forms.DataGridView dataGridViewBuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQueryAll;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxInBookTime2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxInbookTime1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStockName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStockId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.Button buttonAbout;
    }
}