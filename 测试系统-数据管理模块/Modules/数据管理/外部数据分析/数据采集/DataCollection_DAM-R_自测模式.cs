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
    public class DataCollection_DAM_R_自测模式:DataCollectionModule
    {
        private Dictionary<int, string> MyDic = new Dictionary<int, string>()
            {
                { 1,"增益"},//增益
                { 2,"通道间幅度一致性(±)"},//通道间幅度一致性(±)
                { 3,"通道带内增益起伏(±)"},//通道带内增益起伏(±)
                { 4,"功耗"},//功耗
                { 5,"信噪比"},//信噪比
                { 6,"噪声系数"},//噪声系数
                { 7,"通道间隔离度"},//通道间隔离度 
                { 11,"衰减-10"},//衰减-10
                { 12,"衰减-20"},//衰减-20
                { 13,"衰减-32"}, //衰减-32             
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
                    Filltable_AGC(workbook.Worksheets[1], fileName, resultList);
                }
                if (workbook.Worksheets.Count>2)
                {
                    while (workbook.Worksheets.Count > 2)
                    {
                        workbook.Worksheets.RemoveAt(2);
                    }
                    //if (workbook.Worksheets.Count>=4)
                    //{
                    //    Filltable_通道幅度稳定性(workbook.Worksheets[3], fileName, resultList);
                    //}
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
                for (int columnInedx = 1; columnInedx <= 7; columnInedx++)
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
                    objReadResult.测试结果 = Math.Round(Convert.ToDouble(worksheet.Cells[rowIndex, 12].Value.ToString()), 2);
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
                    objReadResult.测试结果 = Math.Round(Convert.ToDouble(worksheet.Cells[rowIndex, 12].Value.ToString()), 2);
                    objReadResult.IsPassed = IsPassed(objReadResult);
                    //if (objReadResult.IsPassed == false)
                    //{
                        resultList.Enqueue(objReadResult);
                    //}
                }
                roadNumber2++;
            }
        }

        private void Filltable_AGC(Worksheet worksheet, string fileName, ConcurrentQueue<ReadResult> resultList)
        {
            int indexAddNumber = 10;
            //按通道循环
            for (int roadNumber = 1; roadNumber <= 192 / 6; roadNumber++)
            {
                //由通道号计算衰减10对应的行号
                int startRowIndex = 2 + 6 * (roadNumber - 1);
                for (int i = 1; i <= 3; i++)
                {
                    int rowIndex = startRowIndex + i;//跳过衰减0
                    if (new Regex(@"^-?\d+\.\d+$").IsMatch(worksheet.Cells[rowIndex, 2].Value.ToString()) || worksheet.Cells[rowIndex, 2].Value.ToString() == "0")
                    {
                        ReadResult objReadResult = new ReadResult();
                        objReadResult.测试结果 = Math.Round(Convert.ToDouble(worksheet.Cells[rowIndex, 2].Value.ToString()), 2);
                        objReadResult.测试项目 = MyDic[i + indexAddNumber];
                        objReadResult.UUT编号 = fileName;
                        objReadResult.通道号 = roadNumber;
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
                case "增益":
                    if (result.测试结果 > 65 && result.测试结果 < 73)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "通道间幅度一致性(±)":
                    if (result.测试结果 > 0 && result.测试结果 < 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "通道带内增益起伏(±)":
                    if (result.测试结果 > 0 && result.测试结果 < 1.5)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "功耗":
                //if (result.测试结果 > 120)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
                case "信噪比":
                    if (result.测试结果 > 23)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "噪声系数":
                    if (result.测试结果 < 1.3)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "通道间隔离度":
                    if (result.测试结果 > 23)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "衰减-10":
                    if (result.测试结果 > 8 && result.测试结果 < 12)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "衰减-20":
                    if (result.测试结果 > 18 && result.测试结果 < 22)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "衰减-32":
                    if (result.测试结果 > 30 && result.测试结果 < 34)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "通道幅度稳定性(±)":
                    if (result.测试结果 <= 0.75)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "通道间幅度一致性的稳定性(±)":
                    if (result.测试结果 <= 0.5)
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
