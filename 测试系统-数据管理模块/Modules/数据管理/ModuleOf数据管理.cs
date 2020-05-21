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
using 数据管理模块.Managers;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

namespace 数据管理模块.Modules
{
    public partial class ModuleOf数据管理 : BaseModule
    {
        public List<TestReport测试报表信息> TestReportsSelected = new List<TestReport测试报表信息>();
        //当前选择的测试报表
        public TestReport测试报表信息 TestReportCurrentSelected = new TestReport测试报表信息();
        //载入Excel数据的集合
        public List<ReadResult> TotalReadResults = new List<ReadResult>();
        public List<ReadResult> ErrorReadResults = new List<ReadResult>();
        public ModuleOf数据管理()
        {
            InitializeComponent();
        }

        #region 数据库访问相关
        public int Add测试报表(TestReport测试报表信息 report)
        {
            //DbContext dbContext = new DbContext();
            //修改IsFinalTest位
            
            return 1;
        }

        public bool Update测试报表(TestReport测试报表信息 report)
        {
            //DbContext dbContext = new DbContext();
            return true;
        }

        public List<TestReport测试报表信息> GetList(string uut类型)
        {
                return  null;
        }

        public List<TestReport测试报表信息> GetList()
        {
            return null;
        }
        #endregion

        private void ModuleOf报表管理_Load(object sender, EventArgs e)
        {
            //生产状态
            //repositoryItemImageComboBox1.Items.Clear();
            //for (int i = 0; i < UUT生产状态.Count; i++)
            //{
            //    repositoryItemImageComboBox1.Items.Add(new ImageComboBoxItem(UUT生产状态[i].ToString(), 0));
            //}

            ////UUT类型
            //comboBoxEdit_UUT类型.Properties.Items.Clear();
            //comboBoxEdit_UUT类型.Properties.Items.AddRange(UUT类型_Base);
            //comboBoxEdit_UUT类型.SelectedIndex = 0;

            //LoadUUT编号(searchLookUpEdit_UUT编号);
            //LoadBatchInfo(searchLookUpEdit_UUT批次号);
            //Load报表名称(searchLookUpEdit_报表名称);

            //Load生产状态(imageComboBoxEdit_生产状态);
            //imageComboBoxEdit_生产状态.Properties.Items.Insert(0,new ImageComboBoxItem(""));
            //imageComboBoxEdit_生产状态.SelectedIndex = 0;

            //List<TestReport测试报表信息>  reports = GetList();
            //List<string> res = new List<string>();
            //foreach (var item in reports)
            //{
            //    res.Add(item.TestReportName);
            //}
            //searchLookUpEdit_报表名称.Properties.DataSource = res;
        }

        /// <summary>
        /// 操作栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton_操作栏_Click(object sender, EventArgs e)
        {
            SimpleButton sb = sender as SimpleButton;
            switch (sb.Text)
            {
                case "报表导入":                  
                    ViewModuleManager.ShowDialog(ViewModuleManager.ChildModuleOf报表导入);
                    break;

                case "报表导出":
                    break;

                case "批量导入":
                    break;

                case "批量导出":
                    break;

                case "刷新信息":
                    RefreshTestReports();
                    break;
                default:
                    break;
            }
        }
        public void RefreshTestReports()
        {
            List<TestReport测试报表信息> infos = GetList();
            gridControl_报表管理.DataSource = infos;
            gridView_报表管理.RefreshData();
            gridView_报表管理.ExpandAllGroups();
        }
        /// <summary>
        /// 右键弹出菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void gridControl_报表管理_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                GridHitInfo info = view.CalcHitInfo(e.Location);
                if (e.Button == MouseButtons.Right && info.InRowCell)
                {
                    popupMenu1.ShowPopup(view.GridControl.PointToScreen(e.Location));
                }
            }
            catch (Exception) { }
        }

        /// <summary>
        /// 右键菜单内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Caption)
            {
                case "查看报表":
                    new ChildModuleOf查看报表().Show();
                    break;
                case "数据分析":
                    ViewModuleManager.ChildModuleOf查看原始数据.LoadReport();
                    ViewModuleManager.Show(ViewModuleManager.ChildModuleOf查看原始数据);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView_报表管理_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hInfo = gridView_报表管理.CalcHitInfo(new Point(e.X, e.Y));
                if (e.Button == MouseButtons.Left && e.Clicks == 2)
                {     
                    if (hInfo.InRow)
                    {
                        int rowHandle = hInfo.RowHandle;
                        //更新当前已选中报表
                        TestReportCurrentSelected =  gridView_报表管理.GetRow(rowHandle) as TestReport测试报表信息;
                        new ChildModuleOf查看报表().Show();
                    }
                }
            }
            catch (Exception) {

            }
        }

        private void gridView_报表管理_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TestReportCurrentSelected = gridView_报表管理.GetFocusedRow() as TestReport测试报表信息;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SimpleButton sb = sender as SimpleButton;
            switch (sb.Text)
            {
                case "统计分析":
                    ViewModuleManager.ShowDialog(ViewModuleManager.ChildModuleOf统计分析);
                    break;

                case "导出报表":
                    saveFileDialog1.Filter = "xlsx（*.xlsx）|*.xlsx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        gridControl_快速数据分析.ExportToXlsx(saveFileDialog1.FileName);
                    }           
                    break;

                case "导入数据":
                    ViewModuleManager.ShowDialog(ViewModuleManager.ChildModuleOf用户选项);
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                         splashScreenManager1.ShowWaitForm();
                        TotalReadResults = new List<ReadResult>(ViewModuleManager.ChildModuleOf统计分析.CurrentDataCollectionModule.LoadExcelData(folderBrowserDialog1.SelectedPath));
                        ErrorReadResults = new List<ReadResult>(TotalReadResults.Where(m => m.IsPassed == false).ToList());
                        gridControl_快速数据分析.DataSource = ErrorReadResults;
                        gridView_快速数据分析.RefreshData();
                        splashScreenManager1.CloseWaitForm();

                        ViewModuleManager.ShowDialog(ViewModuleManager.ChildModuleOf统计分析);
                    }
                    break;
                case "用户选项":
                        ViewModuleManager.ShowDialog(ViewModuleManager.ChildModuleOf用户选项);                
                    break;
                case "数据入库":
                    ViewModuleManager.ShowDialog(ViewModuleManager.ChildModuleOf数据入库);
                    break;
                default:
                    break;
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }
    }
}