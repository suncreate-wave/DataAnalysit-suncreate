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
    public class DataCollection_DAM_T_自测模式:DataCollectionModule
    {
        private Dictionary<int, string> MyDic = new Dictionary<int, string>()
            {
                { 1,"功率"},
                { 2,"输出功率带内起伏"},
                { 3,"通道间幅度一致性"},
                { 4,"带内杂散"},
                { 5,"带外杂散抑制"},
                { 6,"功耗"},
                { 7,"二次谐波"},
                { 8,"三次谐波"},
                { 9,"通道间隔离度"},
                { 11,"发射输出相噪-10"},
                { 12,"发射输出相噪-100"},
                { 13,"发射输出相噪-1K"},
                { 14,"发射输出相噪-10K"},
                { 15,"发射输出相噪-100K"},
                { 21,"通道幅度稳定性(±)"},//通道间幅度一致性(±)
                { 22,"通道间幅度一致性的稳定性(±)"},//通道间幅度一致性的稳定性(±)  
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

                if (workbook.Worksheets.Count >1)
                {
                    Filltable_发射输出相噪(workbook.Worksheets[1], fileName, resultList);
                }
                if (workbook.Worksheets.Count>3)
                {
                    Filltable_通道幅度稳定性(workbook.Worksheets[3], fileName, resultList);
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
            int endRow = 1699;
            int rowRange = 53; //表行数（含表头）
            for (int rowIndex = startRow; rowIndex < endRow; rowIndex++)
            {
                //判断是不是为每张表的表头（占位2行）
                if (worksheet.Cells[rowIndex, 0].Value.ToString().Length == 0)
                {
                    rowIndex += 2;
                }
                //逐列读取测试项目和测试结果
                for (int columnInedx = 1; columnInedx <= 9; columnInedx++)
                {
                    if (new Regex(@"^-?\d+\.\d+$").IsMatch(worksheet.Cells[rowIndex, columnInedx].Value.ToString()) || worksheet.Cells[rowIndex, columnInedx].Value.ToString() == "0")
                    {
                        ReadResult objReadResult = new ReadResult();
                        if ((rowIndex - 3) % rowRange == 0 && rowIndex != 3)
                        {
                            objReadResult.通道号 = (rowIndex - 3) / rowRange;
                        }
                        else
                        {
                            objReadResult.通道号 = (rowIndex - 3) / rowRange + 1;
                        }
                        objReadResult.频点 = worksheet.Cells[rowIndex, 0].Value.ToString();
                        objReadResult.UUT编号 = fileName;
                        objReadResult.测试项目 = testItemDictionary[columnInedx];
                        objReadResult.测试结果 = Math.Round(Convert.ToDecimal(worksheet.Cells[rowIndex, columnInedx].Value.ToString()), 2,MidpointRounding.AwayFromZero);
                        objReadResult.IsPassed = IsPassed(objReadResult);
                        //if (objReadResult.IsPassed == false)
                        //{
                            resultList.Enqueue(objReadResult);
                        //}
                    }
                }
            }
        }

        private void Filltable_通道幅度稳定性(Worksheet worksheet, string fileName, ConcurrentQueue<ReadResult> resultList)
        {
            Worksheet worksheet1 = worksheet;
            int indexAddNumber = 20;
            int roadNumber1 = 1;
            for (int rowIndex = 3; rowIndex <= 34; rowIndex++)
            {
                if (new Regex(@"^-?\d+\.\d+$").IsMatch(worksheet.Cells[rowIndex, 12].Value.ToString()) || worksheet.Cells[rowIndex, 12].Value.ToString() == "0")
                {
                    ReadResult objReadResult = new ReadResult();
                    objReadResult.通道号 = roadNumber1;
                    objReadResult.频点 = "2252MHz";
                    objReadResult.UUT编号 = fileName;
                    objReadResult.测试项目 = GetDictionary()[1 + indexAddNumber];
                    objReadResult.测试结果 = Math.Round(Convert.ToDecimal(worksheet.Cells[rowIndex, 12].Value.ToString()), 2,MidpointRounding.AwayFromZero);
                    objReadResult.IsPassed = IsPassed(objReadResult);
                    //if (objReadResult.IsPassed == false)
                    //{
                        resultList.Enqueue(objReadResult);
                    //}
                }
                roadNumber1++;
            }

            int roadNumber2 = 2;
            for (int rowIndex = 38; rowIndex <= 68; rowIndex++)
            {
                if (new Regex(@"^-?\d+\.\d+$").IsMatch(worksheet.Cells[rowIndex, 12].Value.ToString()) || worksheet.Cells[rowIndex, 12].Value.ToString() == "0")
                {
                    ReadResult objReadResult = new ReadResult();
                    objReadResult.通道号 = roadNumber2;
                    objReadResult.频点 = "2252MHz";
                    objReadResult.UUT编号 = fileName;
                    objReadResult.测试项目 = GetDictionary()[2 + indexAddNumber];
                    objReadResult.测试结果 = Math.Round(Convert.ToDecimal(worksheet.Cells[rowIndex, 12].Value.ToString()), 2,MidpointRounding.AwayFromZero);
                    objReadResult.IsPassed = IsPassed(objReadResult);
                    //if (objReadResult.IsPassed == false)
                    //{
                        resultList.Enqueue(objReadResult);
                    //}
                }
                roadNumber2++;
            }
        }

        private void Filltable_发射输出相噪(Worksheet worksheet, string fileName, ConcurrentQueue<ReadResult> resultList)
        {
            int indexAddNumber = 10;
            int startRow = 1;
            int endRow = 3;
            int startColumn = 1;
            int endColumn = 5;
            for (int rowIndex = startRow; rowIndex <= endRow; rowIndex++)
            {
                for (int columnIndex = startColumn; columnIndex <=endColumn; columnIndex++)
                {
                    if (new Regex(@"^-?\d+\.\d+$").IsMatch(worksheet.Cells[rowIndex, columnIndex].Value.ToString()) || worksheet.Cells[rowIndex, columnIndex].Value.ToString() == "0")
                    {
                        ReadResult objReadResult = new ReadResult();
                        objReadResult.测试结果 = Math.Round(Convert.ToDecimal(worksheet.Cells[rowIndex, columnIndex].Value.ToString()), 2,MidpointRounding.AwayFromZero);
                        objReadResult.测试项目 = MyDic[columnIndex + indexAddNumber];
                        objReadResult.UUT编号 = fileName;
                        objReadResult.通道号 = 1;
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
                case "功率":
                    if (result.测试结果 >= 35)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "输出功率带内起伏":
                    if (result.测试结果 >= 0 && result.测试结果 <= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "通道间幅度一致性":
                    if (result.测试结果 >= 0 && result.测试结果 <= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "带内杂散":
                    if (result.测试结果 >= 55)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "带外杂散抑制":
                    if (result.测试结果 >= 60)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "二次谐波":
                    if (result.测试结果 >= 35)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "三次谐波":
                    if (result.测试结果 >= 20)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "通道间隔离度":
                    if (result.测试结果 >= 20)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "发射输出相噪-10":
                    if (result.测试结果 <= -60)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "发射输出相噪-100":
                    if (result.测试结果 <= -75)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "发射输出相噪-1K":
                    if (result.测试结果 <= -85)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "发射输出相噪-10K":
                    if (result.测试结果 <= -95)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "发射输出相噪-100K":
                    if (result.测试结果 <= -105)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "通道幅度稳定性(±)":
                    if (result.测试结果 <= 0.75m)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "通道间幅度一致性的稳定性(±)":
                    if (result.测试结果 <= 0.5m)
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
