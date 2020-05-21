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
    public partial class ChildModuleOf添加UUT : BaseModule
    {
        public ChildModuleOf添加UUT()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 每次载入界面时载入批次信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChildModuleOf添加UUT_Load(object sender, EventArgs e)
        {
            imageComboBoxEdit_生产状态.Properties.LargeImages = ViewModuleManager.ModuleOfUUT批次信息管理.svgImageCollection1;
            Load生产状态(imageComboBoxEdit_生产状态);
            LoadUUT编号(lookUpEdit_UUT编号);
            LoadUUT类型(comboBoxEdit_UUT类型);
            imageComboBoxEdit_生产状态.SelectedIndex = 0;
            imageComboBoxEdit_生产状态.Enabled = false;
        }

        /// <summary>
        /// 将用户输入的数据填入数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton_确认添加_Click(object sender, EventArgs e)
        {
            UUT状态信息 info = new UUT状态信息() {
                UUT类型 = comboBoxEdit_UUT类型.Text,
                UUT生产状态 = imageComboBoxEdit_生产状态.Text,
                UUT编号 = lookUpEdit_UUT编号.Text.Trim()
            };
            
           bool res =  ViewModuleManager.ModuleOfUUT状态信息.Add状态信息(info);
            if (res)
            {
                XtraMessageBox.Show("添加成功！");
                //刷新该界面
                ChildModuleOf添加UUT_Load(null,null);
                //刷新主视图
                ViewModuleManager.ModuleOfUUT批次信息管理.simpleButton_Batch刷新_Click(ViewModuleManager.ModuleOfUUT批次信息管理.simpleButton_UUT_刷新, null);
            }
            else
            {
                XtraMessageBox.Show("添加失败！可能原因：\r\n1.数据库连接失败\r\n2.使用了相同的UUT编号");
            }
        }

        private void simpleButton_退出_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
