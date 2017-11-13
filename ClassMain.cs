using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServerTest
{
    class ClassMain
    {
        string con, sql;
        public SqlConnection mycon;
        private DataSet myds;
        private SqlDataAdapter myda;
        string role;
        public string getRole()
        {
            return this.role;
        }
        public ClassMain()
        {
            con = "server=(local);database=jingdie;user=sa;pwd=123456";
            mycon = new SqlConnection(con);
            mycon.Open();
        }
        public DataSet selectsqlByName(string id,string name)
        {
            sql = "SELECT * FROM stock WHERE sname='"+name+"' and sno='"+id+"'";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "商品信息");
            return myds;
        }
        public void closecon()
        {
            mycon.Close();
        }
        public bool checkin(string id,string pwd)
        {
            myda = new SqlDataAdapter("SELECT * FROM UserTable WHERE id='"+id+"'",con);
            myds = new DataSet();
            myda.Fill(myds, "UserTable");
            string truepwd;
            try
            {
                truepwd = myds.Tables[0].Rows[0]["pwd"].ToString().Trim();
                role = myds.Tables[0].Rows[0]["role"].ToString().Trim();
            }
            catch(Exception e)
            {
                MessageBox.Show("不存在该账号");
                return false;
            }
            if(truepwd.Equals(pwd))
            {
                return true;
            }
            else
            {
                Console.Write(truepwd + ".");
                MessageBox.Show("密码输入错误");
                return false;
            }
            return true;
        }
        public bool AddUser(string id,string pwd,string role)
        {
            myda = new SqlDataAdapter("INSERT INTO UserTable VALUES('"+id+"','"+pwd+"','"+role+"'",con);
            myds = new DataSet();
            myda.Fill(myds, "UserTable");
            MessageBox.Show("添加成功");
            return true;
        }
    }
}
