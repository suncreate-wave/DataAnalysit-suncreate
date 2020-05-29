using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using 数据管理模块.Models;

namespace 数据管理模块.Modules
{
    public class DataCollection_DY_DAM_R_环境试验模式:DataCollectionModule
    {
        private Dictionary<int, string> MyDic = new Dictionary<int, string>()
            {
                { 1,"通道增益"},//增益
                { 2,"通道接收信噪比"},//信噪比
            };
        public override Dictionary<int, string> GetDictionary()
        {
            return MyDic;
        }

        /// <summary>
        /// 载入外部Excel数据
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public override List<ReadResult> LoadExcelData(string path)
        {
            DateTime startTime = DateTime.Now;

            string[] files = Directory.GetFiles(path);

            ConcurrentQueue<ReadResult> resultList = new ConcurrentQueue<ReadResult>();

            Parallel.ForEach(files, (file) =>
            {
                SpreadsheetControl spreadSheet = new SpreadsheetControl();
                spreadSheet.AllowDrop = false;
                IWorkbook workbook = spreadSheet.Document;
                workbook.LoadDocument(file);
                Worksheet worksheet = workbook.Worksheets[0];

                string fileName = Path.GetFileNameWithoutExtension(file);

                Filltable_测试结果(workbook.Worksheets[0], fileName, resultList);
                if (workbook.Worksheets.Count>1)
                {
                    while (workbook.Worksheets.Count > 1)
                    {
                        workbook.Worksheets.RemoveAt(1);
                    }
                    workbook.SaveDocument(file);
                }

                spreadSheet.Dispose();
            });


            DateTime endTime = DateTime.Now;
            TimeSpan totalTime = endTime - startTime;
            double time = totalTime.TotalSeconds;
            ViewModuleManager.ModuleOf数据管理.richTextBox_消息栏.AppendText("已导入数据：" + resultList.Count + "条" + "\n");
            ViewModuleManager.ModuleOf数据管理.richTextBox_消息栏.AppendText("共耗时：" + time + "秒" + "\n");

            return resultList.ToList();
        }

        private void Filltable_测试结果(Worksheet worksheet, string fileName, ConcurrentQueue<ReadResult> resultList)
        {
            Dictionary<int, string> testItemDictionary = new Dictionary<int, string>(GetDictionary());
            int startRow = 3;
            int endRow = 1731;
            for (int rowIndex = startRow; rowIndex < endRow; rowIndex++)
            {
                //判断是不是为每张表的表头（占位2行）
                if (worksheet.Cells[rowIndex, 0].Value.ToString().Length == 0)
                {
                    rowIndex += 2;
                }
                //逐列读取测试项目和测试结果
                for (int columnInedx = 1; columnInedx <= 2; columnInedx++)
                {
                    if (new Regex(@"^-?\d+\.\d+$").IsMatch(worksheet.Cells[rowIndex, columnInedx].Value.ToString()) || worksheet.Cells[rowIndex, columnInedx].Value.ToString() == "0")
                    {
                        ReadResult objReadResult = new ReadResult();
                        if ((rowIndex - 3) % 54 == 0 && rowIndex != 3)
                        {
                            objReadResult.通道号 = (rowIndex - 3) / 54;
                        }
                        else
                        {
                            objReadResult.通道号 = (rowIndex - 3) / 54 + 1;
                        }
                        objReadResult.频点 = worksheet.Cells[rowIndex, 0].Value.ToString();
                        objReadResult.UUT编号 = fileName;
                        objReadResult.测试项目 = testItemDictionary[columnInedx];
                        objReadResult.测试结果 = Math.Round(Convert.ToDouble(worksheet.Cells[rowIndex, columnInedx].Value.ToString()), 2);
                        objReadResult.IsPassed = IsPassed(objReadResult);
                        //if (objReadResult.IsPassed == false)
                        //{
                            resultList.Enqueue(objReadResult);
                        //}
                 
                    }
                }
            }
        }


        private bool IsPassed(ReadResult result)
        {
            switch (result.测试项目)
            {
                case "通道增益":
                    if (result.测试结果 > 65 && result.测试结果 < 73)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case "通道接收信噪比":
                    if (result.测试结果 > 23)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return true;
            }
        }
    }
}
