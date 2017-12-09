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
    public partial class FormChangePwd : Form
    {
        ClassMain cm;
        DataSet ds;
        bool ans = false;
        private string id;
        public FormChangePwd()
        {
            InitializeComponent();
        }

        public void Setid(string id)
        {
            this.id = id;
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                String oldpwd = textBoxOldPwd.Text;
                String newpwd = textBoxNewPwd.Text;
                String newpwd2 = textBoxNewPwd2.Text;
                if (newpwd.Equals(newpwd2))
                {
                    cm = new ClassMain();
                    ds = cm.UpdateUserPwd(id, oldpwd, newpwd);
                    if (ds != null)
                    {
                        //MessageBox.Show("修改成功");
                        ans = true;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("两次密码输入不一致!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("修改成功");
                //MessageBox.Show(ex.Message);
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
