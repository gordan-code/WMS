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
        public bool flag = false;
        
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
        public bool queryUser(string id,string pwd)
        {
            myda = new SqlDataAdapter("SELECT * FROM UserTable WHERE id='" + id + "'", con);
            myds = new DataSet();
            myda.Fill(myds, "UserTable");
            return true;
        }

        public DataSet addUser(string id,string pwd,string role)
        {
            

            sql = "INSERT INTO UserTable VALUES('"+id+"','"+pwd+"','"+role+"'";
            SqlCommand sc = new SqlCommand(sql, mycon);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataSet ds = new DataSet();
            sda.Fill(ds, "UserTable");
            flag = true;
            mycon.Close();
            mycon.Dispose();

            return myds;
        }
        public bool delUser(string id)
        {
            myda = new SqlDataAdapter("DELETE FROM UserTable WHERE id='"+id+"'",con);
            myds = new DataSet();
            SqlConnection MyConnection = new SqlConnection(con);
            sql = "DELETE FROM UserTable WHERE id='" + id + "','";
            SqlCommand MyCommand = new SqlCommand(sql, MyConnection);
            try
            {
                MyConnection.Open();
                MyCommand.ExecuteNonQuery();
                MyConnection.Close();
                MyCommand = null;
                MyConnection.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
            return true;
        }
        public bool updateUserPwd(string id,string oldpwd,string newpwd)
        {
            myda = new SqlDataAdapter("SELECT * FROM UserTable WHERE id='"+id+"' AND pwd='"+oldpwd+"'",con);
            myds = new DataSet();
            myda.Fill(myds, "userinfo");

            SqlConnection MyConnection = new SqlConnection();
            string MyUpdate = "UPDATE UserTable set pwd='"+newpwd+"' WHERE id='"+id+"'";
            SqlCommand MyCommand = new SqlCommand(MyUpdate, MyConnection);
            try
            {
                MyConnection.Open();
                MyCommand.ExecuteNonQuery();
                MyConnection.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return true;
        }
        public DataSet selectUser(string id)
        {
            return myds;
        }
        public bool updateUserRole(string id,int role)
        {
            myda = new SqlDataAdapter("SELECT * FROM UserTable WHERE id='" + id + "' AND role='" + role + "'", con);
            myds = new DataSet();
            myda.Fill(myds, "userinfo");

            SqlConnection MyConnection = new SqlConnection();
            string MyUpdate = "UPDATE UserTable set role='" + role + "' WHERE id='" + id + "'";
            SqlCommand MyCommand = new SqlCommand(MyUpdate, MyConnection);
            try
            {
                MyConnection.Open();
                MyCommand.ExecuteNonQuery();
                MyConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return true;
        }
        public bool addCommodity(string sno,string sname,int number,double price,string inbookdate,string specification,string supplier)
        {
            return true;
        }
        public DataSet selectsqlByName(string id,string name)
        {
            sql = "SELECT * FROM stock WHERE sno='"+id+"'";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "商品信息");
            return myds;
        }
        public bool delCommodity(string sno,string sname)
        {
            return true;
        }
        public DataSet updateStock(string sno,string number,string inbookdate)
        {
            return myds;
        }
        public DataSet updateCommodity(string info)
        {
            return myds;
        }
        //@override
        public DataSet updateCommodity(int number)
        {
            return myds;
        }
        //@override
        public DataSet updateCommodity(double price)
        {
            return myds;
        }
        /*
        *出库核对订单
        */
        public String checkOutbook(string oid)
        {
            return "";
        }
        /*
         *设置订单 cmd为修改订单的sql语句
        */
        public void setOrder(String cmd)
        {

        }
        public DataSet selOrder(string oid)
        {
            return myds;
        }
        public DataSet selectStockByName(string name)
        {
            sql = "SELECT * FROM stock WHERE sname='"+name+"' ORDER BY intime DESC";
            SqlCommand sc = new SqlCommand(sql, mycon);
            myda = new SqlDataAdapter(sc);
            myds = new DataSet();
            myda.Fill(myds, "stock");
            return myds;
        }
        public DataSet selectStockBySno(string id)
        {
            sql = "SELECT * FROM stock WHERE sno='" + id + "' ORDER BY intime DESC";
            SqlCommand sc = new SqlCommand(sql, mycon);
            myda = new SqlDataAdapter(sc);
            myds = new DataSet();
            myda.Fill(myds, "stock");
            return myds;
        }
        public DataSet selectStockBySupplier(string supplier)
        {
            sql = "SELECT * FROM stock WHERE supplier='" + supplier + "' ORDER BY intime DESC";
            SqlCommand sc = new SqlCommand(sql, mycon);
            myda = new SqlDataAdapter(sc);
            myds = new DataSet();
            myda.Fill(myds, "stock");
            return myds;
        }
        public static string InsertStock(string sno, string[] b)
        {
            string s = "";
            SqlParameter p = new SqlParameter("@result", SqlDbType.NVarChar, 50);
            p.Direction = ParameterDirection.Output;
            string ssql = "jingdie.dbo.inbankinsert";
            SqlParameter[] param_St ={
                                         new SqlParameter("@sno",SqlDbType.Char,20),
                                         new SqlParameter("@sname",SqlDbType.Char,50),
                                         new SqlParameter("@snumber",SqlDbType.Int),
                                         new SqlParameter("@price",SqlDbType.Float),
                                         new SqlParameter("@supplier",SqlDbType.Char,40),
                                         new SqlParameter("@intime",SqlDbType.SmallDateTime),
                                         new SqlParameter("@specifican",SqlDbType.Char,20),
                                         new SqlParameter("@备注",SqlDbType.Char,40),
                                          p
                                                };
            param_St[0].Value = sno;
            param_St[1].Value = b[0];
            param_St[2].Value = b[1];
            param_St[3].Value = b[2];
            param_St[4].Value = b[3];
            param_St[5].Value = b[4];
            param_St[6].Value = b[5];
            param_St[7].Value = b[6];
            
            s = p.Value.ToString();
            return s;


        }
    }
}
