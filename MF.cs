using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace SQLServerTest
{
    public partial class MF : DevExpress.XtraEditors.XtraForm
    {
        public MF()
        {
            InitializeComponent();
        }

        private void buttonRuku_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("入库管理","入库管理",MessageBoxButtons.OK);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage1);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage2);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage3);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage4);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage6);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage7);
            xtraTabControlSelect.TabPages.Add(xtraTabPage5);
        }

        private void buttonChuku_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("出库管理", "出库管理", MessageBoxButtons.OK);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage1);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage2);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage3);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage4);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage5);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage7);
            xtraTabControlSelect.TabPages.Add(xtraTabPage6);
        }

        private void buttonShouZhi_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("收支管理", "收支管理", MessageBoxButtons.OK);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage1);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage2);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage3);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage4);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage5);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage6);
            xtraTabControlSelect.TabPages.Add(xtraTabPage7);
        }

        private void buttonCheckOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("查看订单", "查看订单", MessageBoxButtons.OK);
        }

        private void buttonEditOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("编辑订单", "编辑订单", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("出库核对", "出库核对", MessageBoxButtons.OK);
        }

        public void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("捡货", "捡货", MessageBoxButtons.OK);
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("添加用户", "添加用户", MessageBoxButtons.OK);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage1);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage3);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage4);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage5);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage6);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage7);
            xtraTabControlSelect.TabPages.Add(xtraTabPage2);
        }

        private void buttonUpdatePwd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("修改密码", "修改密码", MessageBoxButtons.OK);
        }

        private void buttonDelUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("删除用户", "删除用户", MessageBoxButtons.OK);
        }

        private void buttonModifyUserRight_Click(object sender, EventArgs e)
        {
            MessageBox.Show("修改用户权限", "修改用户权限", MessageBoxButtons.OK);
        }

        public void buttonSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("查询完成", "查询结果", MessageBoxButtons.OK);
            string sql = "select * from stock where sname ='"+ textBoxStockName +"'";
            SqlConnection conn = new SqlConnection("server=(local);database=jingdie;user=sa;pwd=123456");
            conn.Open();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void buttonInfoSelect_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("信息查询", "信息查询", MessageBoxButtons.OK);
            //xtraTabControlSelect.SelectedTabPage = xtraTabPage1;
            xtraTabControlSelect.TabPages.Remove(xtraTabPage2);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage3);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage4);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage5);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage6);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage7);
            xtraTabControlSelect.TabPages.Add(xtraTabPage1);
        }

        private void buttonDistrubition_Click(object sender, EventArgs e)
        {
            xtraTabControlSelect.TabPages.Remove(xtraTabPage1);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage2);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage4);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage5);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage6);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage7);
            xtraTabControlSelect.TabPages.Add(xtraTabPage3);
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            xtraTabControlSelect.TabPages.Remove(xtraTabPage1);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage2);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage3);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage5);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage6);
            xtraTabControlSelect.TabPages.Remove(xtraTabPage7);
            xtraTabControlSelect.TabPages.Add(xtraTabPage4);
        }
    }
}