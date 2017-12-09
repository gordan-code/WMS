using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServerTest
{
    public partial class FormDeliveryStaff : Form
    {
        private ClassMain mainLogic;
        private string id;
        public FormDeliveryStaff()
        {
            InitializeComponent();
            tabControl1.Visible = false;
        }

        public string Getid()
        {
            return id;
        }
        public void Setid(string id)
        {
            this.id = id;
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            tabPageInfo.Parent = tabControl1;
            tabPageDelivery.Parent = null;
            tabControl1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                mainLogic = new ClassMain();
                FormChangePwd fcp = new FormChangePwd();
                fcp.Setid(Getid());
                fcp.ShowDialog();
                if (fcp.getAns())//修改成功 刷新数据
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改成功");
                //MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabPageDelivery.Parent = tabControl1;
            tabPageInfo.Parent = null;
            tabControl1.Visible = true;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }
    }
}
