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
        private SqlCommand mycm;

        string role;
        public bool flag = false;
        
        public string GetRole()
        {
            return role;
        }
        public ClassMain()
        {
            con = "server=(local);database=jingdie;user=sa;pwd=123456";
            mycon = new SqlConnection(con);
            mycon.Open();

        }
        
        public void Closecon()
        {
            mycon.Close();
        }
        /**
         * 验证登录
         */
        public bool Checkin(string id,string pwd)
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

        }
        /**
         * 查询全部用户
         */
        public DataSet QueryAllUser()
        {
            myda = new SqlDataAdapter("SELECT * FROM UserTable", con);
            myds = new DataSet();
            myda.Fill(myds, "UserTable");
            return myds;
        }
        /***
         * 查询用户 通过id
         */
        public DataSet QueryUser(string id,string pwd)
        {
            myda = new SqlDataAdapter("SELECT * FROM UserTable WHERE id='" + id + "'", con);
            myds = new DataSet();
            myda.Fill(myds, "UserTable");
            return myds;
        }
        /***
         * AddUser:增加用户
         * @parameter id pwd role--权限
         * return DataSet
         * */
        public DataSet AddUser(string id,string pwd,string role)
        {
            

            sql = "INSERT INTO UserTable VALUES('"+id+"','"+pwd+"','"+role+"')";
            SqlDataAdapter sda = new SqlDataAdapter(sql,con);
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "UserTable");
            return myds;
        }
        /**
         * 删除用户
         */
        public DataSet DelUser(string id)
        {
            sql = "DELETE FROM UserTable WHERE id='" + id + "'";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "UserTable");
            return myds;
        }
        /**
         * 修改用户密码
         */
        public DataSet UpdateUserPwd(string id,string oldpwd,string newpwd)
        {
            /*
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
            */
            sql = "UPDATE UserTable set pwd='" + newpwd + "' WHERE id='" + id + "' AND pwd='"+oldpwd+"'";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "UserTable");
            return myds;
        }
       
        /**
         * 修改用户权限
         */
        public DataSet UpdateUserRole(string id, string role)
        {
            /*
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
            */
            sql = "UPDATE UserTable set role='" + role + "' WHERE id='" + id + "'";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "UserTable");
            return myds;
        }


        



        public bool AddCommodity(string sno,string sname,int number,double price,string inbookdate,string specification,string supplier)
        {
            return true;
        }

        public DataSet SelectsqlByName(string id,string name)
        {
            sql = "SELECT * FROM stock WHERE sno='"+id+"'";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "商品信息");
            return myds;
        }

        public bool DelCommodity(string sno,string sname)
        {
            return true;
        }

        public DataSet UpdateStock(string sno,string number,string inbookdate)
        {
            return myds;
        }

        
        /**
         * 查询入库单
         */
        public DataSet QueryInBank()
        {
            sql = "SELECT * FROM inbank ORDER BY 入库单编号 ASC";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "inbank");
            return myds;
        }
        /**
         * 查询出库单
         */
        public DataSet QueryOutBank()
        {
            sql = "SELECT * FROM outbank ORDER BY 出库单编号 ASC";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "outbank");
            return myds;
        }
        public bool CheckInBank()
        {
            return true;
        }

        public DataSet AddStock(string id, string sname, float price, string specifican, string supplier, int number,string intime)
        {
            //生成库存编号
            int idnum = Convert.ToInt32(id);
            idnum = idnum - 5000000;
            id = idnum.ToString();
            string 备注 = "数量及价格以斤算，干燥冷藏保质期15天";
            sql = "INSERT INTO stock VALUES('" + id + "','" + sname + "','" + number + "','" + price + "','" + supplier + "','" + intime + "','" + specifican + "','" + 备注 + "')";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "stock");
            return myds;
        }
        /**
         * 更新入库库存 --更新数量
         */
        public DataSet UpdateInBankCommodity(string id,string sname,float price,string specifican,string supplier,int number,string intime)
        {
            //查询名字 如果查询到就修改 查不到就插入
                /*
                myda = new SqlDataAdapter("SELECT * FROM stock WHERE sname='" + sname +"'", con);
                myds = new DataSet();
                myda.Fill(myds, "stock");
                */
                
                //SqlConnection myConnection = new SqlConnection(con);
               
                
                //string myUpdate = "Update stock set snumber=" + "snumber+"+number + " WHERE sname ='" + sname+"' AND sno='"+sno+"'";
                //SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
                try
                {
                    string myQuery = "SELECT sname FROM stock WHERE sname='" + sname + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(myQuery, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds,"stock");
                    //myConnection.Open();
                    //string result = myCommand.ExecuteScalar().ToString();
                    //myConnection.Close();
                    if (ds.Tables[0].Rows.Count!=0)
                    {

                        //MessageBox.Show("查询到sname=" + result);
                        //mycm =new SqlCommand(myUpdate,myConnection);
                        MessageBox.Show("表中查数据");
                        string myUpdate = "Update stock set snumber=" + "snumber+" + number + " WHERE sname ='" + sname + "'";
                        myda =new SqlDataAdapter(myUpdate,con);
                        myds=new DataSet();
                        myda.Fill(myds, "stock");
                        /*
                        myConnection.Open();
                        mycm.ExecuteNonQuery();
                        myConnection.Close();
                        */
                    }
                    else
                    {
                        //插入库存
                        MessageBox.Show("插入新数据");
                        int idnum = Convert.ToInt32(id);
                        idnum = idnum - 5000000;
                        id = idnum.ToString();
                        string 备注 = "数量及价格以斤算，干燥冷藏保质期15天";
                        sql = "INSERT INTO stock VALUES('" + id + "','" + sname + "','" + number + "','" + price + "','" + supplier + "','" + intime + "','" + specifican + "','" + 备注 + "')";
                        
                        myda = new SqlDataAdapter(sql, con);
                        myds = new DataSet();
                        myda.Fill(myds, "stock");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} Exception caught.", ex);
                }
            
            return myds;
        }

        public DataSet GetDataSet()
        {
            return this.myds;
        }
        
        /*
        *出库核对订单
        */
        public String CheckOutbook(string oid)
        {
            return "";
        }
        /*
         *设置订单 cmd为修改订单的sql语句
        */
        public void SetOrder(String cmd)
        {

        }
        public DataSet SelOrder(string oid)
        {
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
        /**
         * queryAllCommodity:查询全部商品
         * return DataSet
         * 
         * */
        public DataSet QueryAllCommodity()
        {
            sql = "SELECT * FROM stock ORDER BY intime DESC";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "stock");
            return myds;
        }
        public DataSet QueryStockByName(string name)
        {
            sql = "SELECT * FROM stock WHERE sname='" + name + "' ORDER BY intime DESC";
            SqlCommand sc = new SqlCommand(sql, mycon);
            myda = new SqlDataAdapter(sc);
            myds = new DataSet();
            myda.Fill(myds, "stock");
            return myds;
        }
        public DataSet QueryStockBySno(string id)
        {
            sql = "SELECT * FROM stock WHERE sno='" + id + "' ORDER BY intime DESC";
            SqlCommand sc = new SqlCommand(sql, mycon);
            myda = new SqlDataAdapter(sc);
            myds = new DataSet();
            myda.Fill(myds, "stock");
            return myds;
        }
        public DataSet QueryStockBySupplier(string supplier)
        {
            sql = "SELECT * FROM stock WHERE supplier='" + supplier + "' ORDER BY intime DESC";
            SqlCommand sc = new SqlCommand(sql, mycon);
            myda = new SqlDataAdapter(sc);
            myds = new DataSet();
            myda.Fill(myds, "stock");
            return myds;
        }
        public DataSet QueryStockByDate(string datetime1,string datetime2)
        {
            sql = "SELECT * FROM stock WHERE intime>'" + datetime1 + "' AND intime<'" + datetime2 + "'";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "stock");
            return myds;
        }



        /**
         * 修改商品信息
         */
        public DataSet UpdateCommodityNum(int number,string sname,string sno)
        {
            sql = "UPDATE stock SET snumber="+number+" WHERE sno='"+sno+"' AND sname='"+sname+"'";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "stock");
            return myds;
        }

        public DataSet UpdateCommodityPrice(float price, string sname, string sno)
        {
            sql = "UPDATE stock SET price=" + price + " WHERE sno='" + sno + "' AND sname='" + sname + "'";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "stock");
            return myds;
        }

        public DataSet UpdateCommoditySupplier(string supplier, string sname, string sno)
        {
            sql = "UPDATE stock SET supplier='" + supplier + "' WHERE sno='" + sno + "' AND sname='" + sname + "'";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "stock");
            return myds;
        }

        public DataSet UpdateCommoditySpecifican(string specifican, string sname, string sno)
        {
            sql = "UPDATE stock SET specifican='" + specifican + "' WHERE sno='" + sno + "' AND sname='" + sname + "'";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "stock");
            return myds;
        }

        public DataSet UpdateCommodityRemarks(string remark, string sname, string sno)
        {
            sql = "UPDATE stock SET 备注='" + remark + "' WHERE sno='" + sno + "' AND sname='" + sname + "'";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "stock");
            return myds;
        }

        public DataSet UpdateCommodityShelfName(int shelfnum, string sname, string sno)
        {
            sql = "UPDATE stock SET shelfnum=" + shelfnum + " WHERE sno='" + sno + "' AND sname='" + sname + "'";
            myda = new SqlDataAdapter(sql, con);
            myds = new DataSet();
            myda.Fill(myds, "stock");
            return myds;
        }


    }
}
