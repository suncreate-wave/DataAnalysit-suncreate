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
using System.IO;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;
namespace 数据管理模块.Modules
{
    public partial class ChildModuleOf统计分析 : BaseModule
    {
        public DataCollectionModule CurrentDataCollectionModule = new DataCollectionModule();

        public ChildModuleOf统计分析()
        {
            InitializeComponent();
        }

        private void ChildModuleOf查看报表_Load(object sender, EventArgs e)
        {
            CALC最劣值(ViewModuleManager.ModuleOf数据管理.TotalReadResults);
            CALC故障UUT统计(ViewModuleManager.ModuleOf数据管理.TotalReadResults);
        }

        private void CALC故障UUT统计(List<ReadResult> totalResults)
        {
            //正常故障统计
            int totalCounts = totalResults.GroupBy(x => x.UUT编号).Select(y => y.First()).Count();
            int errorCounts = totalResults.Where(m => m.IsPassed == false).GroupBy(x => x.UUT编号).Select(y => y.First()).Count();
            chartControl_正常_故障百分比.Series[0].Points.Clear();
            chartControl_正常_故障百分比.Series[0].Points.AddPoint("正常", totalCounts - errorCounts);
            chartControl_正常_故障百分比.Series[0].Points.AddPoint("故障", errorCounts);

            //故障原因百分比分布统计
            chartControl_故障原因综合.Series[0].Points.Clear();
            var errorTestProject =  totalResults.Where(m => m.IsPassed == false).GroupBy(x=>x.测试项目);
            foreach (IGrouping<string, ReadResult> group_testproject in errorTestProject)
            {
                var item = group_testproject.GroupBy(m => m.UUT编号).Select(y => y.First());
                chartControl_故障原因综合.Series[0].Points.AddPoint(item.First().测试项目, item.Count());
            }
        }
        private void CALC最劣值(List<ReadResult> totalResults)
        {
            List<ReadResult> readsults = new List<ReadResult>();
            Dictionary<int, string> testItemDictionary = new Dictionary<int, string>(CurrentDataCollectionModule.GetDictionary());

            foreach (var project in testItemDictionary)
            {
                ReadResult readresult = new ReadResult();
                var data = totalResults.Where(m => m.测试项目 == project.Value);
                if (data != null)
                {
                    switch (project.Value)
                    {
                        case "通道间幅度一致性(±)":
                            readresult = data.Max();
                            break;
                        case "通道带内增益起伏(±)":
                            readresult = data.Max();
                            break;
                        case "噪声系数":
                            readresult = data.Max();
                            break;
                        case "通道噪声系数":
                            readresult = data.Max();
                            break;
                        case "发射输出相噪-10":
                            readresult = data.Max();
                            break;
                        case "发射输出相噪-100":
                            readresult = data.Max();
                            break;
                        case "发射输出相噪-1K":
                            readresult = data.Max();
                            break;
                        case "发射输出相噪-10K":
                            readresult = data.Max();
                            break;
                        case "发射输出相噪-100K":
                            readresult = data.Max();
                            break;
                        case "通道间幅度一致性":
                            readresult = data.Max();
                            break;
                        case "输出功率带内起伏":
                            readresult = data.Max();
                            break;
                        default:
                            readresult = data.Min();
                            break;
                    }

                    readsults.Add(readresult);
                }
            }
            gridControl_最劣值.DataSource = readsults;
            gridView_最劣值.RefreshData();
        }

        

    }
}