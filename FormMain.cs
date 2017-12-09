using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServerTest
{
    public partial class FormMain : Form
    {
        private ClassMain mainLogic ;
        private string userName = "sa";
        private string password = "123456";
        private string server = "(local)";
        private string connStr = "";
        private string sql = "";
        private SqlConnection conn = null;
        private DataSet ds;
        private bool InBank=false;
        private bool OutBank = false;
        public FormMain()
        {
            InitializeComponent();
            init();
        }
        //设置tabControl1一开始不可见
        private void init()
        {
            this.tabControl1.Visible = false;
            label1FunctionSelect.SendToBack();
        }
        private void buttonInBank_Click(object sender, EventArgs e)
        {
            tabPageInBook.Parent = tabControl1;

            tabPageDistribution.Parent = null;
            tabPageInfo.Parent = null;
            tabPageOutBook.Parent = null;
            tabPagePurchase.Parent = null;
            tabPageUser.Parent = null;
            tabPageModifyInfo.Parent = null;

            tabControl1.Visible = true;

        }

        private void buttonOutBank_Click(object sender, EventArgs e)
        {
            tabPageOutBook.Parent = tabControl1;

            tabPageDistribution.Parent = null;
            tabPageInBook.Parent = null;
            tabPageInfo.Parent = null;
            tabPagePurchase.Parent = null;
            tabPageUser.Parent = null;
            tabPageModifyInfo.Parent = null;

            tabControl1.Visible = true;
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {

            tabPagePurchase.Parent = tabControl1;

            tabPageOutBook.Parent = null;
            tabPageDistribution.Parent = null;
            tabPageInBook.Parent = null;
            tabPageInfo.Parent = null;
            tabPageUser.Parent = null;
            tabPageModifyInfo.Parent = null;

            tabControl1.Visible = true;
        }

        private void buttonDistribution_Click_1(object sender, EventArgs e)
        {

            tabPageDistribution.Parent = tabControl1;

            tabPagePurchase.Parent = null;
            tabPageOutBook.Parent = null;
            tabPageInBook.Parent = null;
            tabPageInfo.Parent = null;
            tabPageUser.Parent = null;
            tabPageModifyInfo.Parent = null;

            tabControl1.Visible = true;
        }

        private void buttonUser_Click_1(object sender, EventArgs e)
        {
            tabPageUser.Parent = tabControl1;

            tabPagePurchase.Parent = null;
            tabPageOutBook.Parent = null;
            tabPageInBook.Parent = null;
            tabPageInfo.Parent = null;
            tabPageDistribution.Parent = null;
            tabPageModifyInfo.Parent = null;

            tabControl1.Visible = true;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            tabPageInfo.Parent = tabControl1;

            tabPagePurchase.Parent = null;
            tabPageOutBook.Parent = null;
            tabPageInBook.Parent = null;
            tabPageDistribution.Parent = null;
            tabPageUser.Parent = null;
            tabPageModifyInfo.Parent = null;

            tabControl1.Visible = true;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            mainLogic = new ClassMain();
            
            //string id = textBoxStockId.Text;
            //string name = textBoxStockName.Text;
            //string supplier = comboBoxSupplier.SelectedItem.ToString();
            //string datetime1 = comboBoxInbookTime1.SelectedItem.ToString();
            //string datetime2 = comboBoxInBookTime2.SelectedItem.ToString();
            try
            {

                string id = textBoxStockId.Text;
                string name = textBoxStockName.Text;
                string supplier = comboBoxSupplier.SelectedItem.ToString();
                string datetime1 = comboBoxInbookTime1.SelectedItem.ToString();
                string datetime2 = comboBoxInBookTime2.SelectedItem.ToString();

                //根据输入判断查询条件
                bool result1 = id.Equals("");
                bool result2 = name.Equals("");
                bool result3 = supplier.Equals("");
                bool result4 = datetime1.Equals("");
                bool result5 = datetime2.Equals("");
                
                //如果id name supplier (datetim1 and datetime2)有任一不为空字符串
                if (!id.Equals("")||!name.Equals("")||!supplier.Equals("")||!(datetime1.Equals("")&&datetime2.Equals("")))
                {
                    //判断查询条件
                    if (!result1)//如果id不为空就用id查询
                    {
                        ds = mainLogic.QueryStockBySno(id);
                    }
                    else if (!result2)//如果id为空 名字不为空 就用名字查询
                    {
                        ds = mainLogic.QueryStockByName(name);
                    }
                    else if (!result3)//如果id name 为空 供应商不为空 用供应商查询
                    {
                        ds = mainLogic.QueryStockBySupplier(supplier);
                    }
                    else if(!result4 && !result5)//如果id name supplier为空 入库出库日期不为空 就用日期查询
                    {
                        ds = mainLogic.QueryStockByDate(datetime1, datetime2);
                    }
                }
                else
                {
                    MessageBox.Show("查询条件不足！请输入查询条件!", "ERROR");
                }
                /*
                connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
                conn = new SqlConnection(connStr);
                conn.Open();

                sql = "SELECT * FROM stock ORDER BY intime ASC";
                SqlCommand sc = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();
                //ds = mainLogic.selectStockBySupplier(supplier);

                sda.Fill(ds, "stock");

                dataGridViewInfo.DataSource = ds;//数据绑定
                dataGridViewInfo.DataMember = "stock";
                dataGridViewInfo.Columns[0].HeaderText = "商品编号"; //改列名称
                dataGridViewInfo.Columns[1].HeaderText = "商品名称"; //改列名称
                dataGridViewInfo.Columns[2].HeaderText = "商品数量"; //改列名称
                dataGridViewInfo.Columns[3].HeaderText = "商品单价"; //改列名称
                dataGridViewInfo.Columns[4].HeaderText = "供应商"; //改列名称
                dataGridViewInfo.Columns[5].HeaderText = "入库时间"; //改列名称
                dataGridViewInfo.Columns[6].HeaderText = "规格"; //改列名称
                dataGridViewInfo.Columns[7].HeaderText = "备注"; //改列名称
                conn.Close();
                conn.Dispose();
                */
                dataGridViewInfo.DataSource = ds;
                dataGridViewInfo.DataMember = "stock";
                dataGridViewInfo.Columns[0].HeaderText = "商品编号"; //改列名称
                dataGridViewInfo.Columns[1].HeaderText = "商品名称"; //改列名称
                dataGridViewInfo.Columns[2].HeaderText = "商品数量"; //改列名称
                dataGridViewInfo.Columns[3].HeaderText = "商品单价"; //改列名称
                dataGridViewInfo.Columns[4].HeaderText = "供应商"; //改列名称
                dataGridViewInfo.Columns[5].HeaderText = "入库时间"; //改列名称
                dataGridViewInfo.Columns[6].HeaderText = "规格"; //改列名称
                dataGridViewInfo.Columns[7].HeaderText = "备注"; //改列名称
                dataGridViewInfo.Columns[8].HeaderText = "货架号"; //改列名称
            }
            catch(Exception ee)
            {
                //MessageBox.Show(ee.Message);
                MessageBox.Show("查询条件不足!请输入查询条件!", "ERROR");
            }
            
            
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            /*
            connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
            conn = new SqlConnection(connStr);
            conn.Open();

            sql = "SELECT * FROM UserTable ORDER BY id ASC";
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds, "UserTable");
            dataGridView2.DataSource = ds;//数据绑定
            dataGridView2.DataMember = "UserTable";
            dataGridView2.Columns[0].HeaderText = "账号"; //改列名称
            dataGridView2.Columns[1].HeaderText = "密码"; //改列名称
            dataGridView2.Columns[2].HeaderText = "权限"; //改列名称
            conn.Close();
            conn.Dispose();
            */
            
            try
            {
                mainLogic = new ClassMain();
                ds = mainLogic.QueryAllUser();
                dataGridViewUser.DataSource = ds;
                dataGridViewUser.DataMember = "UserTable";
                dataGridViewUser.Columns[0].HeaderText = "账号"; //改列名称
                dataGridViewUser.Columns[0].DataPropertyName = ds.Tables[0].Columns[0].ToString();
                dataGridViewUser.Columns[1].HeaderText = "密码"; //改列名称
                dataGridViewUser.Columns[1].DataPropertyName = ds.Tables[0].Columns[1].ToString();
                dataGridViewUser.Columns[2].HeaderText = "权限"; //改列名称
                dataGridViewUser.Columns[2].DataPropertyName = ds.Tables[0].Columns[2].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            
            try
            {
                /*
                connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
                conn = new SqlConnection(connStr);
                sql = "insert into UserTable(id,pwd,role) values('" + uid + "','"+pwd+ "','"+role+ "')";
                conn.Open();
                SqlCommand sc = new SqlCommand(sql, conn);
                sc.ExecuteNonQuery();
                MessageBox.Show("添加成功", "", MessageBoxButtons.OK);
                sql = "SELECT * FROM UserTable ORDER BY id ASC";
                sc = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();

                sda.Fill(ds, "UserTable");
                dataGridViewUser.DataSource = ds;//数据绑定
                dataGridViewUser.DataMember = "UserTable";
                dataGridViewUser.Columns[0].HeaderText = "账号"; //改列名称
                dataGridViewUser.Columns[1].HeaderText = "密码"; //改列名称
                dataGridViewUser.Columns[2].HeaderText = "权限"; //改列名称
                conn.Close();
                conn.Dispose();
                */
                string uid = textBoxUser.Text;
                string pwd = textBoxPwd.Text;
                string role = comboBoxaRole.SelectedItem.ToString();
                mainLogic = new ClassMain();
                //检测输入是否为空
                bool result1 = uid.Equals("");
                bool result2 = pwd.Equals("");
                bool result3 = role.Equals("");
                if(!result1 && !result2 && !result3)//id pwd role 都不为空才能添加
                {
                    ds = mainLogic.AddUser(uid, pwd, role);
                    dataGridViewUser.DataSource = ds;
                    dataGridViewUser.DataMember = "UserTable";
                    dataGridViewUser.Columns[0].HeaderText = "账号"; //改列名称
                    dataGridViewUser.Columns[1].HeaderText = "密码"; //改列名称
                    dataGridViewUser.Columns[2].HeaderText = "权限"; //改列名称
                }
                else
                {
                    MessageBox.Show("输入不足！请输入全部属性！", "ERROR");
                }

            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                //MessageBox.Show("添加成功");
                MessageBox.Show(ex.Message);
            }  
        }

        private void buttonDelUser_Click(object sender, EventArgs e)
        {
            try
            {
                FormDelUser fdu = new FormDelUser();
                fdu.ShowDialog();
                if(fdu.getAns())//删除成功 刷新数据
                {
                    //重新绑定
                    ds = fdu.GetDataSet();
                    dataGridViewUser.DataSource = ds;
                    dataGridViewUser.DataMember = "UserTable";
                    dataGridViewUser.Columns[0].HeaderText = "账号"; //改列名称
                    dataGridViewUser.Columns[1].HeaderText = "密码"; //改列名称
                    dataGridViewUser.Columns[2].HeaderText = "权限"; //改列名称
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("删除成功");
                //MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdatePwd_Click(object sender, EventArgs e)
        {
            try
            {
                mainLogic = new ClassMain();
                FormChangePwdAdmin fcpa = new FormChangePwdAdmin();
                fcpa.ShowDialog();
                if(fcpa.getAns())//修改成功 刷新数据
                {
                    //重新绑定
                    ds = fcpa.GetDataSet();
                    dataGridViewUser.DataSource = ds;
                    dataGridViewUser.DataMember = "UserTable";
                    dataGridViewUser.Columns[0].HeaderText = "账号"; //改列名称
                    dataGridViewUser.Columns[1].HeaderText = "密码"; //改列名称
                    dataGridViewUser.Columns[2].HeaderText = "权限"; //改列名称   
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("修改成功");
                //MessageBox.Show(ex.Message);
            }
        }

        private void buttonModifyUserRight_Click(object sender, EventArgs e)
        {
            try
            {
                FormChangeUserRole fcur = new FormChangeUserRole();
                fcur.ShowDialog();
                if(fcur.getAns())//修改成功 刷新数据
                {
                    //重新绑定
                    ds = fcur.GetDataSet();
                    dataGridViewUser.DataSource = ds;
                    dataGridViewUser.DataMember = "UserTable";
                    dataGridViewUser.Columns[0].HeaderText = "账号"; //改列名称
                    dataGridViewUser.Columns[1].HeaderText = "密码"; //改列名称
                    dataGridViewUser.Columns[2].HeaderText = "权限"; //改列名称  
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除成功");
                //MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelectOrder_Click(object sender, EventArgs e)
        {
            connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
            conn = new SqlConnection(connStr);
            conn.Open();

            sql = "SELECT * FROM purchase ORDER BY 订单编号 ASC";
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds, "purchase");
            dataGridViewBuy.DataSource = ds;//数据绑定
            dataGridViewBuy.DataMember = "purchase";
         
            conn.Close();
            conn.Dispose();
        }

        private void buttonGenerateOrder_Click(object sender, EventArgs e)
        {
            string pno = textBoxPno.Text;
            string pname = textBoxPname.Text;
            string 规格 = textBoxPspecification.Text;
            double 单价 = Convert.ToDouble(textBoxPprice.Text);
            string 供应商 = comboBoxPSupplier.SelectedItem.ToString();
            string 采购员 = comboBoxPBuyer.SelectedItem.ToString();
            int 购买数量 = Convert.ToInt32(textBoxPamount.Text);
            try
            {
                connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
                conn = new SqlConnection(connStr);
                sql = "insert into purchase values('" + pno + "','" + pname + "','" + 规格 + "','"+供应商+ "','"+单价+"','" +购买数量+ "','"+采购员+"')";
                conn.Open();
                SqlCommand sc = new SqlCommand(sql, conn);
                sc.ExecuteNonQuery();
                MessageBox.Show("添加成功", "", MessageBoxButtons.OK);
                //插入后查询并显示
                sql = "SELECT * FROM purchase ORDER BY 订单编号 DESC";
                sc = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();

                sda.Fill(ds, "purchase");
                dataGridViewBuy.DataSource = ds;//数据绑定
                dataGridViewBuy.DataMember = "purchase";
                
                conn.Close();
                conn.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCheckDistributionOrder_Click(object sender, EventArgs e)
        {
            connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
            conn = new SqlConnection(connStr);
            conn.Open();

            sql = "SELECT * FROM distribution ORDER BY 订单编号 ASC";
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds, "distribution");
            dataGridViewDeliver.DataSource = ds;//数据绑定
            dataGridViewDeliver.DataMember = "distribution";

            conn.Close();
            conn.Dispose();
        }

        private void buttonEditOrder_Click(object sender, EventArgs e)
        {
            string 订单编号 = textBox订单编号.Text;
            string 货物名称 = textBox货物名称.Text;
            int 货物数量 = Convert.ToInt32(textBox货物数量.Text);
            string 规格 = textBox规格.Text;
            double 货物单价 = Convert.ToDouble(textBox货物单价.Text);
            string 送货地址 = textBox送货地址.Text;
            string 出库验收人 = comboBox出库验收人.SelectedItem.ToString();
            string 收货人 = textBox收货人.Text;
            string 收货人电话 = textBox收货人电话.Text;
            double 货物总价 = 货物数量 * 货物单价;
            try
            {
                connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
                conn = new SqlConnection(connStr);
                sql = "insert into distribution values('" + 订单编号 + "','" + 货物名称 + "','" + 货物数量 + "','" + 规格 + "','" + 货物单价 + "','" + 货物总价 + "','" + 出库验收人 + "','" +送货地址+ "','"+收货人+ "','"+收货人电话+ "')";
                conn.Open();
                SqlCommand sc = new SqlCommand(sql, conn);
                sc.ExecuteNonQuery();
                MessageBox.Show("添加成功", "", MessageBoxButtons.OK);
                //插入后查询并显示
                sql = "SELECT * FROM distribution ORDER BY 订单编号 DESC";
                sc = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();

                sda.Fill(ds, "distribution");
                dataGridViewBuy.DataSource = ds;//数据绑定
                dataGridViewBuy.DataMember = "distribution";

                conn.Close();
                conn.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelectInBookOrder_Click(object sender, EventArgs e)
        {
            /*
            connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
            conn = new SqlConnection(connStr);
            conn.Open();

            sql = "SELECT * FROM inbank ORDER BY 入库单编号 ASC";
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds, "inbank");
            dataGridViewInStorge.DataSource = ds;//数据绑定
            dataGridViewInStorge.DataMember = "inbank";

            //添加checkbox
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "select";
            checkBoxColumn.HeaderText = "选择";
            dataGridViewInStorge.Columns.Insert(0, checkBoxColumn);

            conn.Close();
            conn.Dispose();
            */
            mainLogic = new ClassMain();
            try
            {
                ds = mainLogic.QueryInBank();
                dataGridViewInStorge.DataSource = ds;
                dataGridViewInStorge.DataMember = "inbank";

                //添加checkbox
                while (InBank == false)
                {
                    DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                    checkBoxColumn.Name = "select";
                    checkBoxColumn.HeaderText = "选择";
                    dataGridViewInStorge.Columns.Insert(0, checkBoxColumn);
                    InBank = true;
                }
                

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void buttonInBook_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                string[] b = new string[8];
                string s = "";
                int count = 0;
                for (int i = 0; i < dataGridViewInStorge.RowCount; i++)
                {
                    if (dataGridViewInStorge.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                    {
                        
                        b[0] = dataGridViewInStorge.Rows[i].Cells[1].Value.ToString();
                        b[1] = dataGridViewInStorge.Rows[i].Cells[2].Value.ToString();
                        b[2] = dataGridViewInStorge.Rows[i].Cells[3].Value.ToString();
                        b[3] = dataGridViewInStorge.Rows[i].Cells[4].Value.ToString();
                        b[4] = dataGridViewInStorge.Rows[i].Cells[5].Value.ToString();
                        b[5] = dataGridViewInStorge.Rows[i].Cells[6].Value.ToString();
                        b[6] = dataGridViewInStorge.Rows[i].Cells[7].Value.ToString();
                        b[7] = dataGridViewInStorge.Rows[i].Cells[8].Value.ToString();
                        //s = mainLogic.InsertStock(sno, b);
                        count++;
                    }
                }
                if (s == "成功")
                {
                    MessageBox.Show("添加成功");
                    //AddBind(sReport);
                }
                else
                {
                    MessageBox.Show("添加成功");
                }
                if (count == 0)
                    MessageBox.Show("请至少选择一条数据", "提示");
                //
                string ssql = "inbankinsert";//要调用的存储过程名
                connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
                conn = new SqlConnection(connStr);
                conn.Open();

                SqlCommand comStr = new SqlCommand(ssql, conn);
                comStr.CommandType = CommandType.StoredProcedure;
                //依次设定存储过程的参数
                comStr.Parameters.Add("@sno", SqlDbType.Char, 20).Value = b[0];
                comStr.Parameters.Add("@sname", SqlDbType.Char, 50).Value = b[1];
                comStr.Parameters.Add("@price", SqlDbType.Float).Value = b[2];
                comStr.Parameters.Add("@specifican", SqlDbType.Char, 20).Value = b[3];
                comStr.Parameters.Add("@supplier", SqlDbType.Char, 40).Value = b[4];
                comStr.Parameters.Add("@snumber", SqlDbType.Int).Value = b[5];
                comStr.Parameters.Add("@intime", SqlDbType.SmallDateTime).Value = b[6];
                comStr.Parameters.Add("@备注", SqlDbType.Char, 40).Value = b[7];

                //入库后查询并显示
                sql = "SELECT * FROM inbank ORDER BY 入库单编号 ASC";
                SqlCommand sc = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();
                sda.Fill(ds, "inbank");
                dataGridViewInStorge.DataSource = ds;//数据绑定
                dataGridViewInStorge.DataMember = "inbank";


                connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
                conn = new SqlConnection(connStr);
                conn.Open();
                conn.Close();
                conn.Dispose();
            } 
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            */
            string sno;
            string sname;
            float price;
            int snumber;
            string supplier;
            string intime;
            string specifican;
            
            mainLogic = new ClassMain();
            try
            {
                for (int i = 0; i < dataGridViewInStorge.RowCount; i++)
                {
                    if (dataGridViewInStorge.Rows[i].Cells[0].Selected == true)
                    {
                        sno = dataGridViewInStorge.Rows[i].Cells[1].Value.ToString();
                        sname = dataGridViewInStorge.Rows[i].Cells[2].Value.ToString();
                        price = Convert.ToSingle(dataGridViewInStorge.Rows[i].Cells[3].Value);
                        specifican = dataGridViewInStorge.Rows[i].Cells[4].Value.ToString();
                        supplier = dataGridViewInStorge.Rows[i].Cells[5].Value.ToString();
                        snumber = Convert.ToInt32(dataGridViewInStorge.Rows[i].Cells[6].Value);
                        intime = DateTime.Parse(dataGridViewInStorge.Rows[i].Cells[7].Value.ToString()).ToString("yyyy/MM/dd");
                        
                        MessageBox.Show("sno=" + sno + " sname= " + sname + " price= "+price+" specifican= "+specifican
                            +" supplier="+supplier+" snumber="+snumber+" intime="+intime);
                        //////////////////////////////
                        connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
                        conn = new SqlConnection(connStr);
                        conn.Open();

                        string myQuery = "SELECT sname FROM stock WHERE sname='" + sname + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(myQuery, connStr);
                        DataSet ds = new DataSet();
                        SqlDataAdapter myda;
                        DataSet myds;
                        sda.Fill(ds, "stock");
                        //myConnection.Open();
                        //string result = myCommand.ExecuteScalar().ToString();
                        //myConnection.Close();
                        if (ds.Tables[0].Rows.Count != 0)
                        {
                            //MessageBox.Show("表中查数据");
                            string myUpdate = "Update stock set snumber=" + "snumber+" + snumber + " WHERE sname ='" + sname + "'";
                            myda = new SqlDataAdapter(myUpdate, connStr);
                            myds = new DataSet();
                            myda.Fill(myds, "stock");


                            dataGridViewShowStock.DataSource = myds;
                            dataGridViewShowStock.DataMember = "stock";
                            dataGridViewShowStock.Columns[0].HeaderText = "商品编号"; //改列名称
                            dataGridViewShowStock.Columns[1].HeaderText = "商品名称"; //改列名称
                            dataGridViewShowStock.Columns[2].HeaderText = "商品数量"; //改列名称
                            dataGridViewShowStock.Columns[3].HeaderText = "商品单价"; //改列名称
                            dataGridViewShowStock.Columns[4].HeaderText = "供应商"; //改列名称
                            dataGridViewShowStock.Columns[5].HeaderText = "入库时间"; //改列名称
                            dataGridViewShowStock.Columns[6].HeaderText = "规格"; //改列名称
                            dataGridViewShowStock.Columns[7].HeaderText = "备注"; //改列名称
                            dataGridViewShowStock.Columns[8].HeaderText = "货架号"; //改列名称
                        }
                        else
                        {
                            //插入库存
                            //MessageBox.Show("插入新数据");
                            //计算库存编号
                            int idnum = Convert.ToInt32(sno);
                            idnum = idnum - 5000000;
                            sno = idnum.ToString();
                            //随机数生成货架号
                            Random num = new Random(); 
                            int shelfnum=num.Next(1, 100); ;
                            string 备注 = "数量及价格以斤算，干燥冷藏保质期15天";
                            sql = "INSERT INTO stock VALUES('" + sno + "','" + sname + "','" + snumber + "','" + price + "','" + supplier + "','"+intime+"','" + specifican + "','" + 备注 + "','" +shelfnum+ "')";

                            myda = new SqlDataAdapter(sql, connStr);
                            myds = new DataSet();
                            myda.Fill(myds, "stock");


                            dataGridViewShowStock.DataSource = myds;
                            dataGridViewShowStock.DataMember = "stock";
                            dataGridViewShowStock.Columns[0].HeaderText = "商品编号"; //改列名称
                            dataGridViewShowStock.Columns[1].HeaderText = "商品名称"; //改列名称
                            dataGridViewShowStock.Columns[2].HeaderText = "商品数量"; //改列名称
                            dataGridViewShowStock.Columns[3].HeaderText = "商品单价"; //改列名称
                            dataGridViewShowStock.Columns[4].HeaderText = "供应商"; //改列名称
                            dataGridViewShowStock.Columns[5].HeaderText = "入库时间"; //改列名称
                            dataGridViewShowStock.Columns[6].HeaderText = "规格"; //改列名称
                            dataGridViewShowStock.Columns[7].HeaderText = "备注"; //改列名称
                            dataGridViewShowStock.Columns[8].HeaderText = "货架号"; //改列名称
                        }

                        conn.Close();
                        conn.Dispose();
                        ////////////////////////////////////
                        /*
                        ds = mainLogic.UpdateInBankCommodity(sno, sname, price, specifican, supplier, snumber, intime);

                        dataGridViewShowStock.DataSource = ds;
                        dataGridViewShowStock.DataMember = "stock";
                        dataGridViewShowStock.Columns[0].HeaderText = "商品编号"; //改列名称
                        dataGridViewShowStock.Columns[1].HeaderText = "商品名称"; //改列名称
                        dataGridViewShowStock.Columns[2].HeaderText = "商品数量"; //改列名称
                        dataGridViewShowStock.Columns[3].HeaderText = "商品单价"; //改列名称
                        dataGridViewShowStock.Columns[4].HeaderText = "供应商"; //改列名称
                        dataGridViewShowStock.Columns[5].HeaderText = "入库时间"; //改列名称
                        dataGridViewShowStock.Columns[6].HeaderText = "规格"; //改列名称
                        dataGridViewShowStock.Columns[7].HeaderText = "备注"; //改列名称
                        */

                    }

                    //String str = this.dataGridViewInStorge.CurrentRow.Cell[i].Value.ToString();
                }
                /*
                foreach (DataGridViewRow dgvr in dataGridViewInStorge.Rows)
                {

                    //dgvr.Selected = true;
                }
                */
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("已入库");
                //MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("已入库");
                //MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelectOutBookOrder_Click(object sender, EventArgs e)
        {
            /*
            connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
            conn = new SqlConnection(connStr);
            conn.Open();

            sql = "SELECT * FROM outbank ORDER BY 出库单编号 ASC";
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds, "outbank");
            dataGridViewOutStorge.DataSource = ds;//数据绑定
            dataGridViewOutStorge.DataMember = "outbank";
            //添加checkbox
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "select";
            checkBoxColumn.HeaderText = "选择";
            dataGridViewOutStorge.Columns.Insert(0, checkBoxColumn);

            conn.Close();
            conn.Dispose();
            */
            mainLogic = new ClassMain();
            try
            {
                ds = mainLogic.QueryOutBank();
                dataGridViewOutStorge.DataSource = ds;
                dataGridViewOutStorge.DataMember = "outbank";

                //添加checkbox
                while (OutBank == false)
                {
                    DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                    checkBoxColumn.Name = "select";
                    checkBoxColumn.HeaderText = "选择";
                    dataGridViewOutStorge.Columns.Insert(0, checkBoxColumn);
                    OutBank = true;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonOutBook_Click(object sender, EventArgs e)
        {
            string sno;
            string sname;
            float price;
            int snumber;
            string supplier;
            string outtime;
            string specifican;

            mainLogic = new ClassMain();
            try
            {
                for (int i = 0; i < dataGridViewOutStorge.RowCount; i++)
                {
                    if (dataGridViewOutStorge.Rows[i].Cells[0].Selected)
                    {
                        sno = dataGridViewOutStorge.Rows[i].Cells[1].Value.ToString();
                        sname = dataGridViewOutStorge.Rows[i].Cells[2].Value.ToString();
                        price = Convert.ToSingle(dataGridViewOutStorge.Rows[i].Cells[3].Value);
                        specifican = dataGridViewOutStorge.Rows[i].Cells[4].Value.ToString();
                        outtime = DateTime.Parse(dataGridViewOutStorge.Rows[i].Cells[5].Value.ToString()).ToString("yyyy/MM/dd");
                        snumber = Convert.ToInt32(dataGridViewOutStorge.Rows[i].Cells[6].Value);
                        
                        /*
                        MessageBox.Show("sno=" + sno + " sname= " + sname + " price= " + price + " specifican= " + specifican
                            +" snumber=" + snumber + " outtime=" + outtime);
                            */
                        //////////////////////////////
                        connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
                        conn = new SqlConnection(connStr);
                        conn.Open();

                        string myQuery = "SELECT snumber FROM stock WHERE sname='" + sname + "' AND snumber>="+snumber;
                        SqlDataAdapter sda = new SqlDataAdapter(myQuery, connStr);
                        DataSet ds = new DataSet();
                        SqlDataAdapter myda;
                        DataSet myds;
                        sda.Fill(ds, "stock");
                        //myConnection.Open();
                        SqlCommand myCommand = new SqlCommand(myQuery, conn);
                        int result = Convert.ToInt32(myCommand.ExecuteScalar());
                        //myCommand.ExecuteScalar();
                        //myConnection.Close();
                        if (/*ds.Tables[0].Rows.Count != 0*/result>0)
                        {
                            //MessageBox.Show("表中查数据");
                            string myUpdate = "Update stock set snumber=" + "snumber-" + snumber + " WHERE sname ='" + sname + "'";
                            myda = new SqlDataAdapter(myUpdate, connStr);
                            myds = new DataSet();
                            myda.Fill(myds, "stock");


                            dataGridViewShowStock2.DataSource = myds;
                            dataGridViewShowStock2.DataMember = "stock";
                            dataGridViewShowStock2.Columns[0].HeaderText = "商品编号"; //改列名称
                            dataGridViewShowStock2.Columns[1].HeaderText = "商品名称"; //改列名称
                            dataGridViewShowStock2.Columns[2].HeaderText = "商品数量"; //改列名称
                            dataGridViewShowStock2.Columns[3].HeaderText = "商品单价"; //改列名称
                            dataGridViewShowStock2.Columns[4].HeaderText = "供应商"; //改列名称
                            dataGridViewShowStock2.Columns[5].HeaderText = "出库时间"; //改列名称
                            dataGridViewShowStock2.Columns[6].HeaderText = "规格"; //改列名称
                            dataGridViewShowStock2.Columns[7].HeaderText = "备注"; //改列名称
                            dataGridViewShowStock2.Columns[8].HeaderText = "货架号"; //改列名称
                        }
                        else if (result == 0)
                        {
                            //插入到出库表
                            //MessageBox.Show("删除旧数据");
    
                            sql = "DELETE FROM stock WHERE sno='" + sno + "' AND sname='" + sname + "' AND snumber='" +
                                  snumber + "'";

                            myda = new SqlDataAdapter(sql, connStr);
                            myds = new DataSet();
                            myda.Fill(myds, "stock");

                            //重新绑定
                            dataGridViewShowStock2.DataSource = myds;
                            dataGridViewShowStock2.DataMember = "stock";
                            dataGridViewShowStock2.Columns[0].HeaderText = "商品编号"; //改列名称
                            dataGridViewShowStock2.Columns[1].HeaderText = "商品名称"; //改列名称
                            dataGridViewShowStock2.Columns[2].HeaderText = "商品数量"; //改列名称
                            dataGridViewShowStock2.Columns[3].HeaderText = "商品单价"; //改列名称
                            dataGridViewShowStock2.Columns[4].HeaderText = "供应商"; //改列名称
                            dataGridViewShowStock2.Columns[5].HeaderText = "入库时间"; //改列名称
                            dataGridViewShowStock2.Columns[6].HeaderText = "规格"; //改列名称
                            dataGridViewShowStock2.Columns[7].HeaderText = "备注"; //改列名称
                            dataGridViewShowStock2.Columns[8].HeaderText = "货架号"; //改列名称
                        }
                        else
                        {
                            MessageBox.Show("货物数量不足!无法出库");
                        }

                        conn.Close();
                        conn.Dispose();
                        ////////////////////////////////////
                        /*
                        ds = mainLogic.UpdateInBankCommodity(sno, sname, price, specifican, supplier, snumber, intime);

                        dataGridViewShowStock.DataSource = ds;
                        dataGridViewShowStock.DataMember = "stock";
                        dataGridViewShowStock.Columns[0].HeaderText = "商品编号"; //改列名称
                        dataGridViewShowStock.Columns[1].HeaderText = "商品名称"; //改列名称
                        dataGridViewShowStock.Columns[2].HeaderText = "商品数量"; //改列名称
                        dataGridViewShowStock.Columns[3].HeaderText = "商品单价"; //改列名称
                        dataGridViewShowStock.Columns[4].HeaderText = "供应商"; //改列名称
                        dataGridViewShowStock.Columns[5].HeaderText = "入库时间"; //改列名称
                        dataGridViewShowStock.Columns[6].HeaderText = "规格"; //改列名称
                        dataGridViewShowStock.Columns[7].HeaderText = "备注"; //改列名称
                        */

                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("已出库");
                //MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("已出库");
                //MessageBox.Show(ex.Message);
            }

        }

        private void buttonCheckStock_Click(object sender, EventArgs e)
        {
            /*
            connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
            conn = new SqlConnection(connStr);
            conn.Open();

            sql = "SELECT * FROM stock ORDER BY intime DESC";
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds, "stock");
            dataGridViewInStorge.DataSource = ds;//数据绑定
            dataGridViewInStorge.DataMember = "stock";

            ////添加checkbox
            //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            //checkBoxColumn.Name = "select";
            //checkBoxColumn.HeaderText = "选择";
            //dataGridView5.Columns.Insert(0, checkBoxColumn);

            conn.Close();
            conn.Dispose();
            */
            mainLogic = new ClassMain();
            try
            {
                ds = mainLogic.QueryAllCommodity();
                dataGridViewShowStock.DataSource = ds;
                dataGridViewShowStock.DataMember = "stock";
                dataGridViewShowStock.Columns[0].HeaderText = "商品编号"; //改列名称
                dataGridViewShowStock.Columns[1].HeaderText = "商品名称"; //改列名称
                dataGridViewShowStock.Columns[2].HeaderText = "商品数量"; //改列名称
                dataGridViewShowStock.Columns[3].HeaderText = "商品单价"; //改列名称
                dataGridViewShowStock.Columns[4].HeaderText = "供应商"; //改列名称
                dataGridViewShowStock.Columns[5].HeaderText = "入库时间"; //改列名称
                dataGridViewShowStock.Columns[6].HeaderText = "规格"; //改列名称
                dataGridViewShowStock.Columns[7].HeaderText = "备注"; //改列名称
                dataGridViewShowStock.Columns[8].HeaderText = "货架号"; //改列名称
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainLogic = new ClassMain();
            try
            {
                ds = mainLogic.QueryAllCommodity();
                dataGridViewShowStock2.DataSource = ds;
                dataGridViewShowStock2.DataMember = "stock";
                dataGridViewShowStock2.Columns[0].HeaderText = "商品编号"; //改列名称
                dataGridViewShowStock2.Columns[1].HeaderText = "商品名称"; //改列名称
                dataGridViewShowStock2.Columns[2].HeaderText = "商品数量"; //改列名称
                dataGridViewShowStock2.Columns[3].HeaderText = "商品单价"; //改列名称
                dataGridViewShowStock2.Columns[4].HeaderText = "供应商"; //改列名称
                dataGridViewShowStock2.Columns[5].HeaderText = "入库时间"; //改列名称
                dataGridViewShowStock2.Columns[6].HeaderText = "规格"; //改列名称
                dataGridViewShowStock2.Columns[7].HeaderText = "备注"; //改列名称
                dataGridViewShowStock2.Columns[8].HeaderText = "货架号"; //改列名称
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonQueryAll_Click(object sender, EventArgs e)
        {
            mainLogic = new ClassMain();
            try
            {
                ds = mainLogic.QueryAllCommodity();
                dataGridViewInfo.DataSource = ds;
                dataGridViewInfo.DataMember = "stock";
                dataGridViewInfo.Columns[0].HeaderText = "商品编号"; //改列名称
                dataGridViewInfo.Columns[1].HeaderText = "商品名称"; //改列名称
                dataGridViewInfo.Columns[2].HeaderText = "商品数量"; //改列名称
                dataGridViewInfo.Columns[3].HeaderText = "商品单价"; //改列名称
                dataGridViewInfo.Columns[4].HeaderText = "供应商"; //改列名称
                dataGridViewInfo.Columns[5].HeaderText = "入库时间"; //改列名称
                dataGridViewInfo.Columns[6].HeaderText = "规格"; //改列名称
                dataGridViewInfo.Columns[7].HeaderText = "备注"; //改列名称
                dataGridViewInfo.Columns[8].HeaderText = "货架号"; //改列名称
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridViewInStorge_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateNum_Click(object sender, EventArgs e)
        {
            try
            {
                int snumber = Convert.ToInt32(textBoxNum.Text.ToString());
                string sno = textBoxSno.Text;
                string sname = textBoxSname.Text;
                mainLogic = new ClassMain();
                
                //重新绑定
                ds = mainLogic.UpdateCommodityNum(snumber,sname,sno);
                dataGridViewUpdStock.DataSource = ds;
                dataGridViewUpdStock.DataMember = "stock";
                dataGridViewUpdStock.Columns[0].HeaderText = "商品编号"; //改列名称
                dataGridViewUpdStock.Columns[1].HeaderText = "商品名称"; //改列名称
                dataGridViewUpdStock.Columns[2].HeaderText = "商品数量"; //改列名称
                dataGridViewUpdStock.Columns[3].HeaderText = "商品单价"; //改列名称
                dataGridViewUpdStock.Columns[4].HeaderText = "供应商"; //改列名称
                dataGridViewUpdStock.Columns[5].HeaderText = "入库时间"; //改列名称
                dataGridViewUpdStock.Columns[6].HeaderText = "规格"; //改列名称
                dataGridViewUpdStock.Columns[7].HeaderText = "备注"; //改列名称 
                dataGridViewUpdStock.Columns[8].HeaderText = "货架号"; //改列名称 
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改成功");
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            try
            {
                float price = Convert.ToSingle(textBoxPrice.Text);
                string sno = textBoxSno.Text;
                string sname = textBoxSname.Text;
                mainLogic = new ClassMain();

                //重新绑定
                ds = mainLogic.UpdateCommodityPrice(price, sname, sno);
                dataGridViewUpdStock.DataSource = ds;
                dataGridViewUpdStock.DataMember = "stock";
                dataGridViewUpdStock.Columns[0].HeaderText = "商品编号"; //改列名称
                dataGridViewUpdStock.Columns[1].HeaderText = "商品名称"; //改列名称
                dataGridViewUpdStock.Columns[2].HeaderText = "商品数量"; //改列名称
                dataGridViewUpdStock.Columns[3].HeaderText = "商品单价"; //改列名称
                dataGridViewUpdStock.Columns[4].HeaderText = "供应商"; //改列名称
                dataGridViewUpdStock.Columns[5].HeaderText = "入库时间"; //改列名称
                dataGridViewUpdStock.Columns[6].HeaderText = "规格"; //改列名称
                dataGridViewUpdStock.Columns[7].HeaderText = "备注"; //改列名称 
                dataGridViewUpdStock.Columns[8].HeaderText = "货架号"; //改列名称 
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改成功");
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                string supplier = textBoxSupplier.Text;
                string sno = textBoxSno.Text;
                string sname = textBoxSname.Text;
                mainLogic = new ClassMain();

                //重新绑定
                ds = mainLogic.UpdateCommoditySupplier(supplier, sname, sno);
                dataGridViewUpdStock.DataSource = ds;
                dataGridViewUpdStock.DataMember = "stock";
                dataGridViewUpdStock.Columns[0].HeaderText = "商品编号"; //改列名称
                dataGridViewUpdStock.Columns[1].HeaderText = "商品名称"; //改列名称
                dataGridViewUpdStock.Columns[2].HeaderText = "商品数量"; //改列名称
                dataGridViewUpdStock.Columns[3].HeaderText = "商品单价"; //改列名称
                dataGridViewUpdStock.Columns[4].HeaderText = "供应商"; //改列名称
                dataGridViewUpdStock.Columns[5].HeaderText = "入库时间"; //改列名称
                dataGridViewUpdStock.Columns[6].HeaderText = "规格"; //改列名称
                dataGridViewUpdStock.Columns[7].HeaderText = "备注"; //改列名称 
                dataGridViewUpdStock.Columns[8].HeaderText = "货架号"; //改列名称 
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改成功");
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateSpec_Click(object sender, EventArgs e)
        {
            try
            {
                string specifican = textBoxSpecifican.Text;
                string sno = textBoxSno.Text;
                string sname = textBoxSname.Text;
                mainLogic = new ClassMain();

                //重新绑定
                ds = mainLogic.UpdateCommoditySpecifican(specifican, sname, sno);
                dataGridViewUpdStock.DataSource = ds;
                dataGridViewUpdStock.DataMember = "stock";
                dataGridViewUpdStock.Columns[0].HeaderText = "商品编号"; //改列名称
                dataGridViewUpdStock.Columns[1].HeaderText = "商品名称"; //改列名称
                dataGridViewUpdStock.Columns[2].HeaderText = "商品数量"; //改列名称
                dataGridViewUpdStock.Columns[3].HeaderText = "商品单价"; //改列名称
                dataGridViewUpdStock.Columns[4].HeaderText = "供应商"; //改列名称
                dataGridViewUpdStock.Columns[5].HeaderText = "入库时间"; //改列名称
                dataGridViewUpdStock.Columns[6].HeaderText = "规格"; //改列名称
                dataGridViewUpdStock.Columns[7].HeaderText = "备注"; //改列名称 
                dataGridViewUpdStock.Columns[8].HeaderText = "货架号"; //改列名称 
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改成功");
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate备注_Click(object sender, EventArgs e)
        {
            try
            {
                string remarks = textBox备注.Text;
                string sno = textBoxSno.Text;
                string sname = textBoxSname.Text;
                mainLogic = new ClassMain();

                //重新绑定
                ds = mainLogic.UpdateCommodityRemarks(remarks, sname, sno);
                dataGridViewUpdStock.DataSource = ds;
                dataGridViewUpdStock.DataMember = "stock";
                dataGridViewUpdStock.Columns[0].HeaderText = "商品编号"; //改列名称
                dataGridViewUpdStock.Columns[1].HeaderText = "商品名称"; //改列名称
                dataGridViewUpdStock.Columns[2].HeaderText = "商品数量"; //改列名称
                dataGridViewUpdStock.Columns[3].HeaderText = "商品单价"; //改列名称
                dataGridViewUpdStock.Columns[4].HeaderText = "供应商"; //改列名称
                dataGridViewUpdStock.Columns[5].HeaderText = "入库时间"; //改列名称
                dataGridViewUpdStock.Columns[6].HeaderText = "规格"; //改列名称
                dataGridViewUpdStock.Columns[7].HeaderText = "备注"; //改列名称 
                dataGridViewUpdStock.Columns[8].HeaderText = "货架号"; //改列名称 
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改成功");
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateShelfNum_Click(object sender, EventArgs e)
        {
            try
            {
                int shelfnum = Convert.ToInt32(comboBoxShelfnum.SelectedItem.ToString());
                string sno = textBoxSno.Text;
                string sname = textBoxSname.Text;
                mainLogic = new ClassMain();

                //重新绑定
                ds = mainLogic.UpdateCommodityShelfName(shelfnum, sname, sno);
                dataGridViewUpdStock.DataSource = ds;
                dataGridViewUpdStock.DataMember = "stock";
                dataGridViewUpdStock.Columns[0].HeaderText = "商品编号"; //改列名称
                dataGridViewUpdStock.Columns[1].HeaderText = "商品名称"; //改列名称
                dataGridViewUpdStock.Columns[2].HeaderText = "商品数量"; //改列名称
                dataGridViewUpdStock.Columns[3].HeaderText = "商品单价"; //改列名称
                dataGridViewUpdStock.Columns[4].HeaderText = "供应商"; //改列名称
                dataGridViewUpdStock.Columns[5].HeaderText = "入库时间"; //改列名称
                dataGridViewUpdStock.Columns[6].HeaderText = "规格"; //改列名称
                dataGridViewUpdStock.Columns[7].HeaderText = "备注"; //改列名称 
                dataGridViewUpdStock.Columns[8].HeaderText = "货架号"; //改列名称 
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改成功");
                //MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabPageModifyInfo.Parent = tabControl1;
            //
            tabPagePurchase.Parent = null;
            tabPageOutBook.Parent = null;
            tabPageInBook.Parent = null;
            tabPageDistribution.Parent = null;
            tabPageUser.Parent = null;
            tabPageInfo.Parent = null;

            tabControl1.Visible = true;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }
    }
}
