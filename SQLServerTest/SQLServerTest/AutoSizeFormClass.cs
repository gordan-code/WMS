using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServerTest
{
    class AutoSizeFormClass
    {
        //(1).声明结构,只记录窗体和其控件的初始位置和大小。  
        public struct controlRect
        {
            public int Left;
            public int Top;
            public int Width;
            public int Height;
            public float SizeFont;
        }

        //(2).声明 1个对象  
        //注意这里不能使用控件列表记录 List nCtrl;，因为控件的关联性，记录的始终是当前的大小。  
        //这里将西文的大于小于号都过滤掉了，只能改为中文的，使用中要改回西文  
        public List<controlRect> oldCtrl = new List<controlRect>();
        int ctrlNo = 0;//1;  
                       //(3). 创建两个函数  
                       //(3.1)记录窗体和其控件的初始位置和大小,  
        public void controllInitializeSize(Control mForm)
        {
            controlRect cR;
            cR.Left = mForm.Left; cR.Top = mForm.Top; cR.Width = mForm.Width; cR.Height = mForm.Height; cR.SizeFont = mForm.Font.Size;
            oldCtrl.Add(cR);//第一个为"窗体本身",只加入一次即可  
            AddControl(mForm);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用  
        }

        /// <summary>  
        /// 递归添加控件  
        /// </summary>  
        /// <param name="ctl">控件</param>  
        private void AddControl(Control ctl)
        {
            foreach (Control c in ctl.Controls)
            {  //**放在这里，是先记录控件的子控件，后记录控件本身  
                controlRect objCtrl;
                objCtrl.Left = c.Left; objCtrl.Top = c.Top; objCtrl.Width = c.Width; objCtrl.Height = c.Height; objCtrl.SizeFont = c.Font.Size;
                oldCtrl.Add(objCtrl);
                //**放在这里，是先记录控件本身，后记录控件的子控件  
                if (c.Controls.Count > 0)
                {
                    AddControl(c);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用  
                }
            }
        }

        /// <summary>  
        /// (3.2)控件自适应大小,  
        /// </summary>  
        /// <param name="mForm">主窗体</param>  
        public void controlAutoSize(Control mForm)
        {
            if (ctrlNo == 0)
            { //*如果在窗体的Form1_Load中，记录控件原始的大小和位置，正常没有问题，但要加入皮肤就会出现问题，因为有些控件如dataGridView的的子控件还没有完成，个数少  
              //*要在窗体的Form1_SizeChanged中，第一次改变大小时，记录控件原始的大小和位置,这里所有控件的子控件都已经形成  
                controlRect cR;
                cR.Left = 0; cR.Top = 0; cR.Width = mForm.Width; cR.Height = mForm.Height; cR.SizeFont = mForm.Font.Size;
                //cR.Left = 0; cR.Top = 0; cR.Width = mForm.PreferredSize.Width; cR.Height = mForm.PreferredSize.Height;  

                oldCtrl.Add(cR);//第一个为"窗体本身",只加入一次即可  
                AddControl(mForm);//窗体内其余控件可能嵌套其它控件(比如panel),故单独抽出以便递归调用  
            }

            float wScale = (float)mForm.Width / (float)oldCtrl[0].Width;//新旧窗体之间的比例，与最早的旧窗体  
            float hScale = (float)mForm.Height / (float)oldCtrl[0].Height;//.Height;  
            ctrlNo = 1;//进入=1，第0个为窗体本身,窗体内的控件,从序号1开始  
            AutoScaleControl(mForm, wScale, hScale);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用  
        }

        /// <summary>  
        /// 改变控件位置、大小、字体大小  
        /// </summary>  
        /// <param name="ctl"></param>  
        /// <param name="wScale">新旧窗体宽度的比例</param>  
        /// <param name="hScale">新旧窗体的比例</param>  
        private void AutoScaleControl(Control ctl, float wScale, float hScale)
        {

            float sizeFont = wScale > hScale ? wScale : hScale;//字体变化倍数  
            int ctrLeft0, ctrTop0, ctrWidth0, ctrHeight0;
            float ctrSizeFont0;
            foreach (Control c in ctl.Controls)
            {
                //**放在这里，是先缩放控件的子控件，后缩放控件本身  
                ctrLeft0 = oldCtrl[ctrlNo].Left;
                ctrTop0 = oldCtrl[ctrlNo].Top;
                ctrWidth0 = oldCtrl[ctrlNo].Width;
                ctrHeight0 = oldCtrl[ctrlNo].Height;
                ctrSizeFont0 = oldCtrl[ctrlNo].SizeFont;

                c.Left = (int)((ctrLeft0) * wScale);//新旧控件之间的线性比例。控件位置只相对于窗体，所以不能加 + wLeft1  
                c.Top = (int)((ctrTop0) * hScale);//  
                c.Width = (int)(ctrWidth0 * wScale);//只与最初的大小相关，所以不能与现在的宽度相乘 (int)(c.Width * w);  
                c.Height = (int)(ctrHeight0 * hScale);
                c.Font = new Font(c.Font.FontFamily, ctrSizeFont0 * sizeFont);
                ctrlNo++;//累加序号  
                         //**放在这里，是先缩放控件本身，后缩放控件的子控件  
                if (c.Controls.Count > 0)
                {
                    AutoScaleControl(c, wScale, hScale);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用  
                }

                //不同控件自适应修改  
                if (ctl.GetType() == typeof(DataGridView))
                {
                    DataGridView dgv = ctl as DataGridView;
                    Cursor.Current = Cursors.WaitCursor;

                    int widths = 0;
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        dgv.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);  // 自动调整列宽    
                        widths += dgv.Columns[i].Width;   // 计算调整列后单元列的宽度和                         
                    }
                    if (widths >= ctl.Size.Width)  // 如果调整列的宽度大于设定列宽    
                    {
                        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;  // 调整列的模式 自动  
                    }
                    else
                    {
                        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  // 如果小于 则填充  
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
        }


    }
}
