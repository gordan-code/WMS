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
    public partial class FormChangePwdAdmin : Form
    {
        ClassMain cm;
        DataSet ds;
        bool ans = false;
        public FormChangePwdAdmin()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                
                String id = textBoxID.Text;
                String oldpwd = textBoxOldPwd.Text;
                String newpwd = textBoxNewPwd.Text;

                cm = new ClassMain();
                ds = cm.UpdateUserPwd(id, oldpwd, newpwd);
                if (ds!=null)
                {
                    //MessageBox.Show("修改成功");
                    ans = true;
                    this.Close();
                }
            }catch(SqlException ex)
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
