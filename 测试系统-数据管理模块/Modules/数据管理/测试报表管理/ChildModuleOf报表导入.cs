using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 数据管理模块.Managers;
using 数据管理模块.Models;
using 数据管理模块.Modules;

namespace 数据管理模块.Modules
{
    public partial class ChildModuleOf报表导入 : BaseModule
    {
        public ChildModuleOf报表导入()
        {
            InitializeComponent();
        }

        //Excel文件缓冲区
        private List<byte> ExcelBuffer = new List<byte>();
        //Excel名称
        private string ExcelName = "";
        private bool Inited = false;
        /// <summary>
        /// 每次载入界面时载入批次信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChildModuleOf报表导入_Load(object sender, EventArgs e)
        {
            imageComboBoxEdit_生产状态.Properties.LargeImages= ViewModuleManager.ModuleOf数据管理.svgImageCollection1;
            //comboBoxEdit_UUT类型.Properties.Items.AddRange(new );
            Load生产状态(imageComboBoxEdit_生产状态);
            LoadBatchInfo(searchLookUpEdit_UUT批次号);
            LoadUUT编号(lookUpEdit_UUT编号);
            if (Inited == false)
            {
                imageComboBoxEdit_生产状态.SelectedIndex = 0;
                Inited = true;
            }
            textEdit_导入报表.Text = "";
        }

        /// <summary>
        /// 上传Excel报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton_确认添加_Click(object sender, EventArgs e)
        {
            //DbContext dbContext = new DbContext();

            //检查有无对应产品的批次号，如果没有批次则拒绝添加
            //var batch = dbContext.UUT批次信息表.AsQueryable().Where(m=>m.UUT批次号 == searchLookUpEdit_UUT批次号.Text.Trim() && m.UUT类型 == comboBoxEdit_UUT类型.Text).First();
            //if (batch == null)
            //{
            //    XtraMessageBox.Show("批次号不存在，请选择正确批次");
            //    return;
            //}

            ////检查看是否有UUT编号信息，没有的话添加
            //var uutINFO = dbContext.UUT状态信息表.AsQueryable().Where(M=>M.UUT编号 == lookUpEdit_UUT编号.Text.Trim() && M.UUT类型 == comboBoxEdit_UUT类型.Text).First();
            //if (uutINFO==null )
            //{
            //    //UUT信息添加
            //    uutINFO = new UUT状态信息()
            //    {
            //        UUT生产状态 = imageComboBoxEdit_生产状态.Text,
            //        UUT类型 = comboBoxEdit_UUT类型.Text,
            //        UUT编号 = lookUpEdit_UUT编号.Text.Trim(),
            //    };
            //    int uutId = dbContext.UUT状态信息表.InsertReturnIdentity(uutINFO);         
            //}

            ////检查有无报表，有的话更新，没有的话添加
            //int res =  0;
            //bool isFinal = false;
            //var report = dbContext.TestReport测试报表信息.AsQueryable().Where(M => M.UUT批次号 == searchLookUpEdit_UUT批次号.Text && M.UUT生产状态 == imageComboBoxEdit_生产状态.Text && M.UUT类型 == comboBoxEdit_UUT类型.Text && M.UUT编号 == lookUpEdit_UUT编号.Text.Trim()).First();
            //if (report == null)
            //{
            //    isFinal = true;
            //}
            //else
            //{
            //    report.isFinalTest = false;
            //}
            //res = ViewModuleManager.ModuleOf数据管理.Add测试报表(new TestReport测试报表信息()
            //{
            //    TestReport创建时间 = DateTime.Now.ToShortDateString(),
            //    UUT批次号 = searchLookUpEdit_UUT批次号.Text,
            //    UUT生产状态 = imageComboBoxEdit_生产状态.Text,
            //    UUT类型 = comboBoxEdit_UUT类型.Text,
            //    UUT编号 = lookUpEdit_UUT编号.Text.Trim(),
            //    TestReportContent = ExcelBuffer.ToArray(),
            //    TestReportName = ExcelName,
            //    isFinalTest = isFinal
            //});

            //if (res != -1)
            //{
            //    XtraMessageBox.Show("添加成功！");
            //    ViewModuleManager.ModuleOf数据管理.RefreshTestReports();
            //}
            //else
            //{
            //    XtraMessageBox.Show("添加失败！可能原因：\r\n1.数据库连接失败\r\n2.使用了相同的UUT编号");
            //}
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton_退出_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 导入报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton_报表导入_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "xlsx（*.xlsx）|*.xlsx";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExcelName = Path.GetFileName(openFileDialog1.FileName);
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)fs.Length);
                fs.Close();
                ExcelBuffer = bytes.ToList();
                textEdit_导入报表.Text = ExcelName;
            }
        }
    }
}
