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
        ClassMain mainLogic = new ClassMain();
        private string userName = "sa";
        private string password = "123456";
        private string server = "(local)";
        private string connStr = "";
        private string sql = "";
        private SqlConnection conn = null;
        public FormMain()
        {
            InitializeComponent();
            init();
        }
        //设置tabControl1一开始不可见
        private void init()
        {
            this.tabControl1.Visible = false;
        }
        private void buttonInBank_Click(object sender, EventArgs e)
        {
            
            tabControl1.TabPages.Add(tabPageInBook);
            tabControl1.TabPages.Remove(tabPageOutBook);
            tabControl1.TabPages.Remove(tabPageInfo);
            tabControl1.TabPages.Remove(tabPageUser);
            tabControl1.TabPages.Remove(tabPagePurchase);
            tabControl1.TabPages.Remove(tabPageDistribution);
            tabControl1.Visible = true;

        }

        private void buttonOutBank_Click(object sender, EventArgs e)
        {
            
            tabControl1.TabPages.Add(tabPageOutBook);
            tabControl1.TabPages.Remove(tabPageInBook);
            tabControl1.TabPages.Remove(tabPageInfo);
            tabControl1.TabPages.Remove(tabPageUser);
            tabControl1.TabPages.Remove(tabPagePurchase);
            tabControl1.TabPages.Remove(tabPageDistribution);
            tabControl1.Visible = true;

        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            
            tabControl1.TabPages.Remove(tabPageInfo);
            tabControl1.TabPages.Remove(tabPageUser);
            tabControl1.TabPages.Remove(tabPageDistribution);
            tabControl1.TabPages.Remove(tabPageInBook);
            tabControl1.TabPages.Remove(tabPageOutBook);
            tabControl1.TabPages.Add(tabPagePurchase);
            tabControl1.Visible = true;
        }

        private void buttonDistribution_Click_1(object sender, EventArgs e)
        {
            
            tabControl1.TabPages.Remove(tabPageInfo);
            tabControl1.TabPages.Remove(tabPageUser);
            tabControl1.TabPages.Remove(tabPagePurchase);
            tabControl1.TabPages.Remove(tabPageInBook);
            tabControl1.TabPages.Remove(tabPageOutBook);
            tabControl1.TabPages.Add(tabPageDistribution);
            tabControl1.Visible = true;
        }

        private void buttonUser_Click_1(object sender, EventArgs e)
        {
            
            tabControl1.TabPages.Remove(tabPageInfo);
            tabControl1.TabPages.Remove(tabPageDistribution);
            tabControl1.TabPages.Remove(tabPagePurchase);
            tabControl1.TabPages.Remove(tabPageInBook);
            tabControl1.TabPages.Remove(tabPageOutBook);
            tabControl1.TabPages.Add(tabPageUser);
            tabControl1.Visible = true;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            
            tabControl1.TabPages.Remove(tabPagePurchase);
            tabControl1.TabPages.Remove(tabPageUser);
            tabControl1.TabPages.Remove(tabPageDistribution);
            tabControl1.TabPages.Remove(tabPageInBook);
            tabControl1.TabPages.Remove(tabPageOutBook);
            tabControl1.TabPages.Add(tabPageInfo);
            tabControl1.Visible = true;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string id = textBoxStockId.Text;
            string name = textBoxStockName.Text;
            string supplier = comboBoxSupplier.SelectedItem.ToString();
            //string datetime1 = comboBoxInbookTime1.SelectedItem.ToString();
            //string datetime2 = comboBoxInBookTime2.SelectedItem.ToString();
            try
            {
                connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
                conn = new SqlConnection(connStr);
                conn.Open();

                //sql = "SELECT * FROM stock ORDER BY intime ASC";
                //SqlCommand sc = new SqlCommand(sql, conn);
                //SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();
                ds = mainLogic.selectStockBySupplier(supplier);

                //sda.Fill(ds, "stock");

                dataGridView1.DataSource = ds;//数据绑定
                dataGridView1.DataMember = "stock";
                dataGridView1.Columns[0].HeaderText = "商品编号"; //改列名称
                dataGridView1.Columns[1].HeaderText = "商品名称"; //改列名称
                dataGridView1.Columns[2].HeaderText = "商品数量"; //改列名称
                dataGridView1.Columns[3].HeaderText = "商品单价"; //改列名称
                dataGridView1.Columns[4].HeaderText = "供应商"; //改列名称
                dataGridView1.Columns[5].HeaderText = "入库时间"; //改列名称
                dataGridView1.Columns[6].HeaderText = "规格"; //改列名称
                dataGridView1.Columns[7].HeaderText = "备注"; //改列名称
                conn.Close();
                conn.Dispose();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            
            
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
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
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            string uid = textBoxUser.Text;
            string pwd = textBoxPwd.Text;
            string role = comboBoxaRole.SelectedItem.ToString();
            try
                {
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
                    dataGridView2.DataSource = ds;//数据绑定
                    dataGridView2.DataMember = "UserTable";
                    dataGridView2.Columns[0].HeaderText = "账号"; //改列名称
                    dataGridView2.Columns[1].HeaderText = "密码"; //改列名称
                    dataGridView2.Columns[2].HeaderText = "权限"; //改列名称
                    conn.Close();
                    conn.Dispose();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            
        }

        private void buttonDelUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdatePwd_Click(object sender, EventArgs e)
        {

        }

        private void buttonModifyUserRight_Click(object sender, EventArgs e)
        {

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
            dataGridView3.DataSource = ds;//数据绑定
            dataGridView3.DataMember = "purchase";
         
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
                dataGridView3.DataSource = ds;//数据绑定
                dataGridView3.DataMember = "purchase";
                
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
            dataGridView4.DataSource = ds;//数据绑定
            dataGridView4.DataMember = "distribution";

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
                dataGridView3.DataSource = ds;//数据绑定
                dataGridView3.DataMember = "distribution";

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
            connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
            conn = new SqlConnection(connStr);
            conn.Open();

            sql = "SELECT * FROM inbank ORDER BY 入库单编号 ASC";
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds, "inbank");
            dataGridView5.DataSource = ds;//数据绑定
            dataGridView5.DataMember = "inbank";

            //添加checkbox
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "select";
            checkBoxColumn.HeaderText = "选择";
            dataGridView5.Columns.Insert(0, checkBoxColumn);

            conn.Close();
            conn.Dispose();
        }
       
        private void buttonInBook_Click(object sender, EventArgs e)
        {
            try
            {
                string[] b = new string[8];
                string s = "";
                int count = 0;
                for (int i = 0; i < dataGridView5.RowCount; i++)
                {
                    if (dataGridView5.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                    {
                        
                        b[0] = dataGridView5.Rows[i].Cells[1].Value.ToString();
                        b[1] = dataGridView5.Rows[i].Cells[2].Value.ToString();
                        b[2] = dataGridView5.Rows[i].Cells[3].Value.ToString();
                        b[3] = dataGridView5.Rows[i].Cells[4].Value.ToString();
                        b[4] = dataGridView5.Rows[i].Cells[5].Value.ToString();
                        b[5] = dataGridView5.Rows[i].Cells[6].Value.ToString();
                        b[6] = dataGridView5.Rows[i].Cells[7].Value.ToString();
                        b[7] = dataGridView5.Rows[i].Cells[8].Value.ToString();
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
                dataGridView5.DataSource = ds;//数据绑定
                dataGridView5.DataMember = "inbank";



                conn.Close();
                conn.Dispose();
            } 
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void buttonSelectOutBookOrder_Click(object sender, EventArgs e)
        {
            connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
            conn = new SqlConnection(connStr);
            conn.Open();

            sql = "SELECT * FROM outbank ORDER BY 出库单编号 ASC";
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds, "outbank");
            dataGridView6.DataSource = ds;//数据绑定
            dataGridView6.DataMember = "outbank";
            //添加checkbox
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "select";
            checkBoxColumn.HeaderText = "选择";
            dataGridView6.Columns.Insert(0, checkBoxColumn);

            conn.Close();
            conn.Dispose();
        }

        private void buttonOutBook_Click(object sender, EventArgs e)
        {
            try
            {
                string[] b = new string[8];
                string s = "";
                int count = 0;
                for (int i = 0; i < dataGridView6.RowCount; i++)
                {
                    if (dataGridView6.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                    {

                        b[0] = dataGridView6.Rows[i].Cells[1].Value.ToString();
                        b[1] = dataGridView6.Rows[i].Cells[2].Value.ToString();
                        b[2] = dataGridView6.Rows[i].Cells[3].Value.ToString();
                        b[3] = dataGridView6.Rows[i].Cells[4].Value.ToString();
                        b[4] = dataGridView6.Rows[i].Cells[5].Value.ToString();
                        b[5] = dataGridView6.Rows[i].Cells[6].Value.ToString();
                        b[6] = dataGridView6.Rows[i].Cells[7].Value.ToString();
                        b[7] = dataGridView6.Rows[i].Cells[8].Value.ToString();
                        
                        count++;
                    }
                }
                if (s == "成功")
                {
                    MessageBox.Show("添加成功");
                   
                }
                else
                {
                    MessageBox.Show("添加成功");
                }
                if (count == 0)
                    MessageBox.Show("请至少选择一条数据", "提示");
                
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

                //出库后查询并显示
                sql = "SELECT * FROM outbank ORDER BY 出库单编号 DESC";
                SqlCommand sc = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataSet ds = new DataSet();
                sda.Fill(ds, "outbank");
                dataGridView6.DataSource = ds;//数据绑定
                dataGridView6.DataMember = "outbank";



                conn.Close();
                conn.Dispose();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void buttonCheckStock_Click(object sender, EventArgs e)
        {
            connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
            conn = new SqlConnection(connStr);
            conn.Open();

            sql = "SELECT * FROM stock ORDER BY intime DESC";
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds, "stock");
            dataGridView5.DataSource = ds;//数据绑定
            dataGridView5.DataMember = "stock";

            ////添加checkbox
            //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            //checkBoxColumn.Name = "select";
            //checkBoxColumn.HeaderText = "选择";
            //dataGridView5.Columns.Insert(0, checkBoxColumn);

            conn.Close();
            conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connStr = "server=(local);database=jingdie;user=sa;pwd=123456";
            conn = new SqlConnection(connStr);
            conn.Open();

            sql = "SELECT * FROM stock ORDER BY intime DESC";
            SqlCommand sc = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds, "stock");
            dataGridView6.DataSource = ds;//数据绑定
            dataGridView6.DataMember = "stock";

            

            conn.Close();
            conn.Dispose();
        }
    }
}
