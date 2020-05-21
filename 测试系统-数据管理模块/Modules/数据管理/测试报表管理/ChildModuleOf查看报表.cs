using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using 数据管理模块.Managers;
using 数据管理模块.Models;

namespace 数据管理模块.Modules
{
    public partial class ChildModuleOf查看报表 : BaseModule
    {
        public ChildModuleOf查看报表()
        {
            InitializeComponent();
        }

        //protected override void OnClosing(CancelEventArgs e)
        //{
        //    e.Cancel = true;
        //    Hide();
        //}

        public void LoadReport()
        {
            try
            {
                //DbContext dbContext = new DbContext();
                ////生成Excel
                //TestReport测试报表信息 report = dbContext.TestReport测试报表信息.AsQueryable().Single(m => m.ID == ViewModuleManager.ModuleOf数据管理.TestReportCurrentSelected.ID);
                //spreadsheetControl1.LoadDocument(report.TestReportContent);

                //this.Text = report.TestReportName;
            }
            catch (Exception)
            {
                XtraMessageBox.Show("无法正确加载，可能存储的Excel文件损坏");
            }
        }
        private void ChildModuleOf查看报表_Load(object sender, EventArgs e)
        {

            LoadReport();
        }
    }
}