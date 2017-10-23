using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQLServerTest
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //声明自适应类实例
        AutoSizeFormClass asc = new AutoSizeFormClass();

        private void button1_Click(object sender, EventArgs e)
        {
            string userid = textBoxUserID.Text;
            string pwd = textBoxPwd.Text;
            //第一步 连接到数据库
            SqlConnection conn = new SqlConnection("server=(local);database=kingdee;user=sa;pwd=123456");
            conn.Open();
            //第二步 写执行语句
            SqlCommand cmd = conn.CreateCommand();//通过conn创建sqlcommand对象
            cmd.CommandText = "select * from UserTable where userid='" + userid + "' and pwd='" + pwd + "'";
            SqlDataReader dr = cmd.ExecuteReader();//执行查询，返回sqldatareader对象
            if (dr.Read())          
            {
                MF mf = new MF();
                this.Visible = false;
                mf.ShowDialog();
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("Password or Userid is incorrect ", "Prompt message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void Login_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
        }
    }
}
