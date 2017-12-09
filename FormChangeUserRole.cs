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
    public partial class FormChangeUserRole : Form
    {
        ClassMain cm = new ClassMain();
        DataSet ds;
        bool ans = false;
        public FormChangeUserRole()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxID.Text;
                string role = comboBoxRole.SelectedItem.ToString();
                if(!id.Equals("") && !role.Equals(""))
                {
                    cm = new ClassMain();
                    ds = cm.UpdateUserRole(id, role);
                    if (ds != null)
                    {
                        //MessageBox.Show("修改成功");
                        ans = true;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("无效输入！请重新输入", "ERROR",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("修改成功");
                //MessageBox.Show(ex.Message);
            }
        }
        public bool getAns()
        {
            return this.ans;
        }
        public DataSet GetDataSet()
        {
            return this.ds;
        }
    }
}
