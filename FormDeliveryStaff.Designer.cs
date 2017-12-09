namespace SQLServerTest
{
    partial class FormDeliveryStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeliveryStaff));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDelivery = new System.Windows.Forms.TabPage();
            this.dataGridViewDeliver = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.comboBox出库验收人 = new System.Windows.Forms.ComboBox();
            this.textBox收货人电话 = new System.Windows.Forms.TextBox();
            this.textBox收货人 = new System.Windows.Forms.TextBox();
            this.textBox送货地址 = new System.Windows.Forms.TextBox();
            this.textBox货物单价 = new System.Windows.Forms.TextBox();
            this.textBox规格 = new System.Windows.Forms.TextBox();
            this.textBox货物数量 = new System.Windows.Forms.TextBox();
            this.textBox货物名称 = new System.Windows.Forms.TextBox();
            this.textBox订单编号 = new System.Windows.Forms.TextBox();
            this.buttonEditOrder = new System.Windows.Forms.Button();
            this.buttonCheckDistributionOrder = new System.Windows.Forms.Button();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTopic = new System.Windows.Forms.PictureBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeliver)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopic)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDelivery);
            this.tabControl1.Controls.Add(this.tabPageInfo);
            this.tabControl1.Location = new System.Drawing.Point(171, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(994, 510);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPageDelivery
            // 
            this.tabPageDelivery.Controls.Add(this.dataGridViewDeliver);
            this.tabPageDelivery.Controls.Add(this.panel4);
            this.tabPageDelivery.Location = new System.Drawing.Point(4, 25);
            this.tabPageDelivery.Name = "tabPageDelivery";
            this.tabPageDelivery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDelivery.Size = new System.Drawing.Size(986, 481);
            this.tabPageDelivery.TabIndex = 0;
            this.tabPageDelivery.Text = "配送管理";
            this.tabPageDelivery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDeliver
            // 
            this.dataGridViewDeliver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeliver.Location = new System.Drawing.Point(3, 200);
            this.dataGridViewDeliver.Name = "dataGridViewDeliver";
            this.dataGridViewDeliver.RowTemplate.Height = 27;
            this.dataGridViewDeliver.Size = new System.Drawing.Size(980, 272);
            this.dataGridViewDeliver.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label);
            this.panel4.Controls.Add(this.comboBox出库验收人);
            this.panel4.Controls.Add(this.textBox收货人电话);
            this.panel4.Controls.Add(this.textBox收货人);
            this.panel4.Controls.Add(this.textBox送货地址);
            this.panel4.Controls.Add(this.textBox货物单价);
            this.panel4.Controls.Add(this.textBox规格);
            this.panel4.Controls.Add(this.textBox货物数量);
            this.panel4.Controls.Add(this.textBox货物名称);
            this.panel4.Controls.Add(this.textBox订单编号);
            this.panel4.Controls.Add(this.buttonEditOrder);
            this.panel4.Controls.Add(this.buttonCheckDistributionOrder);
            this.panel4.Location = new System.Drawing.Point(3, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(981, 190);
            this.panel4.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(274, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 19;
            this.label14.Text = "收货人电话";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(304, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "收货人";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "送货地址";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(566, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "出库验收人";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "货物单价";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "规格";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "货物数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "货物名称";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(5, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 15);
            this.label.TabIndex = 11;
            this.label.Text = "订单编号";
            // 
            // comboBox出库验收人
            // 
            this.comboBox出库验收人.FormattingEnabled = true;
            this.comboBox出库验收人.Items.AddRange(new object[] {
            "张洪隆",
            "张国栋",
            "赵晓彤",
            "刘子楠",
            "温俊楠"});
            this.comboBox出库验收人.Location = new System.Drawing.Point(654, 5);
            this.comboBox出库验收人.Name = "comboBox出库验收人";
            this.comboBox出库验收人.Size = new System.Drawing.Size(121, 23);
            this.comboBox出库验收人.TabIndex = 10;
            // 
            // textBox收货人电话
            // 
            this.textBox收货人电话.Location = new System.Drawing.Point(362, 160);
            this.textBox收货人电话.Name = "textBox收货人电话";
            this.textBox收货人电话.Size = new System.Drawing.Size(185, 25);
            this.textBox收货人电话.TabIndex = 9;
            // 
            // textBox收货人
            // 
            this.textBox收货人.Location = new System.Drawing.Point(362, 111);
            this.textBox收货人.Name = "textBox收货人";
            this.textBox收货人.Size = new System.Drawing.Size(185, 25);
            this.textBox收货人.TabIndex = 8;
            // 
            // textBox送货地址
            // 
            this.textBox送货地址.Location = new System.Drawing.Point(362, 61);
            this.textBox送货地址.Name = "textBox送货地址";
            this.textBox送货地址.Size = new System.Drawing.Size(185, 25);
            this.textBox送货地址.TabIndex = 7;
            // 
            // textBox货物单价
            // 
            this.textBox货物单价.Location = new System.Drawing.Point(362, 9);
            this.textBox货物单价.Name = "textBox货物单价";
            this.textBox货物单价.Size = new System.Drawing.Size(185, 25);
            this.textBox货物单价.TabIndex = 6;
            // 
            // textBox规格
            // 
            this.textBox规格.Location = new System.Drawing.Point(78, 160);
            this.textBox规格.Name = "textBox规格";
            this.textBox规格.Size = new System.Drawing.Size(185, 25);
            this.textBox规格.TabIndex = 5;
            // 
            // textBox货物数量
            // 
            this.textBox货物数量.Location = new System.Drawing.Point(78, 114);
            this.textBox货物数量.Name = "textBox货物数量";
            this.textBox货物数量.Size = new System.Drawing.Size(185, 25);
            this.textBox货物数量.TabIndex = 4;
            // 
            // textBox货物名称
            // 
            this.textBox货物名称.Location = new System.Drawing.Point(78, 64);
            this.textBox货物名称.Name = "textBox货物名称";
            this.textBox货物名称.Size = new System.Drawing.Size(185, 25);
            this.textBox货物名称.TabIndex = 3;
            // 
            // textBox订单编号
            // 
            this.textBox订单编号.Location = new System.Drawing.Point(78, 6);
            this.textBox订单编号.Name = "textBox订单编号";
            this.textBox订单编号.Size = new System.Drawing.Size(185, 25);
            this.textBox订单编号.TabIndex = 2;
            // 
            // buttonEditOrder
            // 
            this.buttonEditOrder.Location = new System.Drawing.Point(805, 114);
            this.buttonEditOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditOrder.Name = "buttonEditOrder";
            this.buttonEditOrder.Size = new System.Drawing.Size(107, 33);
            this.buttonEditOrder.TabIndex = 1;
            this.buttonEditOrder.Text = "加入订单";
            this.buttonEditOrder.UseVisualStyleBackColor = true;
            // 
            // buttonCheckDistributionOrder
            // 
            this.buttonCheckDistributionOrder.Location = new System.Drawing.Point(805, 39);
            this.buttonCheckDistributionOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCheckDistributionOrder.Name = "buttonCheckDistributionOrder";
            this.buttonCheckDistributionOrder.Size = new System.Drawing.Size(108, 32);
            this.buttonCheckDistributionOrder.TabIndex = 0;
            this.buttonCheckDistributionOrder.Text = "查看配送订单";
            this.buttonCheckDistributionOrder.UseVisualStyleBackColor = true;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.dataGridViewInfo);
            this.tabPageInfo.Controls.Add(this.panel1);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(986, 481);
            this.tabPageInfo.TabIndex = 1;
            this.tabPageInfo.Text = "信息查询";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(1, 197);
            this.dataGridViewInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.RowTemplate.Height = 27;
            this.dataGridViewInfo.Size = new System.Drawing.Size(985, 241);
            this.dataGridViewInfo.TabIndex = 54;
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
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 191);
            this.panel1.TabIndex = 18;
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
            // button1
            // 
            this.button1.Image = global::SQLServerTest.Properties.Resources.配送24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "配送管理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = global::SQLServerTest.Properties.Resources.password_24px_1169936_easyicon_net;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 48);
            this.button3.TabIndex = 6;
            this.button3.Text = "修改密码";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Image = global::SQLServerTest.Properties.Resources.查询24;
            this.buttonCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheck.Location = new System.Drawing.Point(1, 194);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(164, 48);
            this.buttonCheck.TabIndex = 5;
            this.buttonCheck.Text = "信息查询";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // label1
            // 
            this.label1.Image = global::SQLServerTest.Properties.Resources.工作界面_0000s_0003_功能选择面板;
            this.label1.Location = new System.Drawing.Point(-2, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 510);
            this.label1.TabIndex = 2;
            // 
            // pictureBoxTopic
            // 
            this.pictureBoxTopic.Image = global::SQLServerTest.Properties.Resources.工作界面_0002s_0001_标题栏;
            this.pictureBoxTopic.Location = new System.Drawing.Point(1, 0);
            this.pictureBoxTopic.Name = "pictureBoxTopic";
            this.pictureBoxTopic.Size = new System.Drawing.Size(1164, 50);
            this.pictureBoxTopic.TabIndex = 1;
            this.pictureBoxTopic.TabStop = false;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Image = global::SQLServerTest.Properties.Resources.关于__1_;
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.Location = new System.Drawing.Point(1, 416);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(164, 43);
            this.buttonAbout.TabIndex = 55;
            this.buttonAbout.Text = "关于";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // FormDeliveryStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 562);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxTopic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDeliveryStaff";
            this.Text = "仓库管理系统";
            this.tabControl1.ResumeLayout(false);
            this.tabPageDelivery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeliver)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPageInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDelivery;
        private System.Windows.Forms.TabPage tabPageInfo;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBox出库验收人;
        private System.Windows.Forms.TextBox textBox收货人电话;
        private System.Windows.Forms.TextBox textBox收货人;
        private System.Windows.Forms.TextBox textBox送货地址;
        private System.Windows.Forms.TextBox textBox货物单价;
        private System.Windows.Forms.TextBox textBox规格;
        private System.Windows.Forms.TextBox textBox货物数量;
        private System.Windows.Forms.TextBox textBox货物名称;
        private System.Windows.Forms.TextBox textBox订单编号;
        private System.Windows.Forms.Button buttonEditOrder;
        private System.Windows.Forms.Button buttonCheckDistributionOrder;
        private System.Windows.Forms.DataGridView dataGridViewDeliver;
        private System.Windows.Forms.Button buttonAbout;
    }
}