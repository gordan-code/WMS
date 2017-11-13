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
            ClassMain mainTest = new ClassMain();
            if(mainTest.checkin(textBoxUserID.Text.ToString(),textBoxPwd.Text.ToString()))
            {
                string role = mainTest.getRole();
                if(role.Equals("管理员"))
                {
                    MF mf = new MF();
                    this.Visible = false;
                    mf.ShowDialog();
                    this.Dispose();
                    this.Close(); 
                }
                else if(role.Equals("采购员"))
                {
                    MessageBox.Show("采购员");
                }
                else if(role.Equals("配送员"))
                {
                    MessageBox.Show("配送员");
                }
                else if(role.Equals("客户"))
                {
                    MessageBox.Show("客户");
                }
            }


            mainTest.closecon();
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
            
            textBoxUserID.BackColor = Color.FromArgb(122, 191, 196);
            textBoxPwd.BackColor = Color.FromArgb(122, 191, 196);
        }

        private void buttonLogin_MouseMove(object sender, MouseEventArgs e)
        {
            //buttonLogin.BackgroundImage = new Bitmap("/image/工作界面_0000s_0000s_0000_login_press.png");
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            //buttonLogin.BackgroundImage = new Bitmap("/image/工作界面_0000s_0000s_0001_login_press.png");
        }
    }
}
