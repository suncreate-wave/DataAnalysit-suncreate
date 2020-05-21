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
using 数据管理模块.Models;

namespace 数据管理模块.Modules
{

    public partial class ChildModuleOf批次详细信息 : DevExpress.XtraEditors.XtraForm
    {   
        public ChildModuleOf批次详细信息()
        {
            InitializeComponent();
        }

        private void ChildModuleOf批次详细信息_Load(object sender, EventArgs e)
        {        
            string batch = ViewModuleManager.ModuleOfUUT批次信息管理.UUT批次信息Selected.UUT批次号;
            string uutStyle = ViewModuleManager.ModuleOfUUT批次信息管理.UUT批次信息Selected.UUT类型;

            List<BatchAndUUT> batchs = new List<BatchAndUUT>();
            List<TestReport测试报表信息> testReports = ViewModuleManager.ModuleOf数据管理.GetList();
            List<UUT状态信息>  uuts = ViewModuleManager.ModuleOfUUT状态信息.GetList();
            List<TestReport测试报表信息> allReports = testReports.Where(m => m.UUT批次号 == batch && m.UUT类型 == uutStyle && m.isFinalTest ==  true).ToList();
            
            foreach (var report in allReports)
            {
                //统计测试次数
                List<TestReport测试报表信息> uutReports = testReports.Where(m => m.UUT批次号 == batch && m.UUT类型 == uutStyle && m.UUT编号 == report.UUT编号).ToList();
                int count = uutReports.Count;

                //读取生产状态
                string state = uuts.Where(m=>m.UUT类型 == uutStyle && m.UUT编号 == report.UUT编号).First().UUT生产状态;
                batchs.Add(new BatchAndUUT() {
                    UUT编号 = report.UUT编号,
                    UUT测试次数 = count.ToString(),
                    UUT生产状态 = state,
                    Detail = uutReports
                });          
            }
            gridView_报表数据.MouseUp += new System.Windows.Forms.MouseEventHandler(ViewModuleManager.ModuleOf数据管理.gridControl_报表管理_MouseUp);
            gridControl_批次信息表.DataSource = batchs;
            gridView_批次信息表.RefreshData();
            gridView_报表数据.RefreshData();
        }

        private void gridView_报表数据_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            BatchAndUUT batchAndUUT = gridView_批次信息表.GetFocusedRow() as BatchAndUUT;
            TestReport测试报表信息 report = batchAndUUT.Detail[e.FocusedRowHandle];
           
            ViewModuleManager.ModuleOf数据管理.TestReportCurrentSelected = report;
        }

        private void gridView_报表数据_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }
    }

    public class BatchAndUUT
    {
        public string UUT编号 { get; set; }
        public string UUT测试次数 { get; set; }
        public string UUT生产状态 { get; set; }
        public string 合格情况 { get;set;}
        public string 备注 { get;set;}
        public List<TestReport测试报表信息> Detail { get;set;}
    }


}