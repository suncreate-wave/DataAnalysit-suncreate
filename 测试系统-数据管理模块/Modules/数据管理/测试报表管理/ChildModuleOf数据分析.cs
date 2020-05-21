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
using DevExpress.XtraCharts;
using 数据管理模块.Modules.数据分析库;
using DevExpress.XtraPivotGrid;

namespace 数据管理模块.Modules
{
    public partial class ChildModuleOf数据分析 : BaseModule
    {
        //待处理数据
        private List<TestResult测试结果信息> WaitProcessTestResults = new List<TestResult测试结果信息>();

        public ChildModuleOf数据分析()
        {
            InitializeComponent();
        }

        bool canTrigger = false;
        private void ChildModuleOf查看原始数据_Load(object sender, EventArgs e)
        {
            LoadReport();
            LoadChartViewType();
            LoadAlgorithmLibrary();
            canTrigger = true;
            
        }
        
        /// <summary>
        /// 载入测试报表信息
        /// </summary>
        public void LoadReport()
        {
            try
            {
                //DbContext dbContext = new DbContext();

                ////通过测试报表ID查询出报表
                //TestReport测试报表信息 report = dbContext.TestReport测试报表信息.AsQueryable().Single(m => m.ID == ViewModuleManager.ModuleOf数据管理.TestReportCurrentSelected.ID);

                ////通过报表ID搜索所有的测试结果数据
                //List<TestResult测试结果信息> testResults = dbContext.测试结果信息表.AsQueryable().Where(m => m.TestReportID == report.ID).ToList();
                //WaitProcessTestResults = new List<TestResult测试结果信息>(testResults);
                //pivotGridControl_原始结果.DataSource = testResults;
                //pivotGridControl_原始结果.RefreshData();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("无法正确加载");
            }
        }

        /// <summary>
        /// 载入图表信息
        /// </summary>
        private void LoadChartViewType()
        {
            comboBoxEdit_图表类型.Properties.Items.AddRange(Enum.GetNames(typeof(DevExpress.XtraCharts.ViewType)));
            comboBoxEdit_图表类型.SelectedIndex = 0;
        }

        /// <summary>
        /// 载入公式选择算法库
        /// </summary>
        private void LoadAlgorithmLibrary()
        {
            comboBoxEdit_公式选择.Properties.Items.Clear();
            comboBoxEdit_公式选择.Properties.Items.AddRange(AlgorithmManager.LoadAllAlgorithm());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            chartControl1.Series[0].ChangeView(DevExpress.XtraCharts.ViewType.Spline);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void comboBoxEdit_图表类型_TextChanged(object sender, EventArgs e)
        {
            if (canTrigger)
            {
                chartControl1.Series[0].ChangeView((DevExpress.XtraCharts.ViewType)Enum.Parse(typeof(DevExpress.XtraCharts.ViewType), comboBoxEdit_图表类型.Text.ToString()));
            }
        }

        private void simpleButton_GO_Click(object sender, EventArgs e)
        {
            ChildModuleOf计算结果 mo = new ChildModuleOf计算结果();
            //选择数据源

            //执行选中的算法
            string header = "=========="+ comboBoxEdit_公式选择.Text + "==========\n";               
            string res = AlgorithmManager.Go(comboBoxEdit_公式选择.Text,new List<TestResult测试结果信息>(WaitProcessTestResults));
            //打印执行结果
            mo.richTextBox1.AppendText(header + res);
            mo.ShowDialog();
        }
    }
}