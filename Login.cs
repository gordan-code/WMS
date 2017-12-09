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
            if(mainTest.Checkin(textBoxUserID.Text,textBoxPwd.Text))
            {
                string role = mainTest.GetRole();
                if(role.Equals("管理员"))
                {
                    /*
                    MF mf = new MF();
                    this.Visible = false;
                    mf.ShowDialog();
                    this.Dispose();
                    this.Close(); 
                    */
                    FormMain fm = new FormMain();
                    this.Visible = false;
                    fm.ShowDialog();
                    this.Dispose();
                    this.Close();
                }
                else if(role.Equals("采购员"))
                {

                    FormBuyer fb = new FormBuyer();
                    this.Visible = false;
                    fb.Setid(textBoxUserID.Text);
                    fb.ShowDialog();
                    
                    this.Dispose();
                    this.Close();
                }
                else if(role.Equals("配送员"))
                {
                    FormDeliveryStaff fds = new FormDeliveryStaff();
                    this.Visible = false;
                    fds.Setid(textBoxUserID.Text);
                    fds.ShowDialog();
                    this.Dispose();
                    this.Close();
                }
                /*
                else if(role.Equals("客户"))
                {
                    FormUser fu=new FormUser();
                    this.Visible = false;
                    fu.Setid(textBoxUserID.Text);
                    fu.ShowDialog();
                    this.Dispose();
                    this.Close();
                }
                */
            }


            mainTest.Closecon();
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
