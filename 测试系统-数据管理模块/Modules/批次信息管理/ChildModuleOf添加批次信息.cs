using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 数据管理模块.Models;
using 数据管理模块.Modules;

namespace 数据管理模块.Modules
{
    public partial class ChildModuleOf添加批次信息 : BaseModule
    {
        public ChildModuleOf添加批次信息()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 每次载入界面时载入批次信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChildModuleOf添加批次信息_Load(object sender, EventArgs e)
        {
            LoadBatchInfo(comboBoxEdit_批次信息);
            LoadUUT类型(comboBoxEdit_UUT类型);
        }

        /// <summary>
        /// 将用户输入的数据填入数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton_确认添加_Click(object sender, EventArgs e)
        {
            UUT批次信息 info = new UUT批次信息() {
                UUT类型 = comboBoxEdit_UUT类型.Text,
                UUT批次号 = comboBoxEdit_批次信息.Text,
                UUT数量 = 0,
                创建时间 = DateTime.Now.ToShortDateString(),
            };
            
           bool res =  ViewModuleManager.ModuleOfUUT批次信息管理.Add批次信息(info);
            if (res)
            {
                XtraMessageBox.Show("添加成功！");
                //刷新该界面
                ChildModuleOf添加批次信息_Load(null,null);
                //刷新主视图
                ViewModuleManager.ModuleOfUUT批次信息管理.simpleButton_Batch刷新_Click(ViewModuleManager.ModuleOfUUT批次信息管理.simpleButton_Batch_Refresh, null);
            }
            else
            {
                XtraMessageBox.Show("添加失败！可能原因：\r\n1.数据库连接失败\r\n2.使用了相同的批次号");
            }
        }

        
        private void simpleButton_退出_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
