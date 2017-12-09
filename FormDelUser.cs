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
    public partial class FormDelUser : Form
    {
        ClassMain cm;
        DataSet ds;
        bool ans = false;
        public FormDelUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text;
            try
            {
                cm = new ClassMain();
                ds = cm.DelUser(id);
                
                if(ds!=null)
                {
                    //MessageBox.Show("删除成功");
                    ans = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("输入的账号不存在");
                }
                
            }catch(SqlException ex)
            {
                MessageBox.Show("删除成功");
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                cm.Closecon();
            }
        }
        public DataSet GetDataSet()
        {
            return this.ds;
        }
        public bool getAns()
        {
            return this.ans;
        }
    }
}
