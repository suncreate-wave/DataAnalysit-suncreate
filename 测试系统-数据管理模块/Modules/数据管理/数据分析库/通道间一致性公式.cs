using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 数据管理模块.Models;

namespace 数据管理模块.Modules.数据分析库
{
    public class 通道间一致性公式 : IAlgorithm
    {
        public string Go(List<TestResult测试结果信息> results)
        {
            List<TestResult测试结果信息> res = results.Where(m => m.频点 == "1000").ToList();
            List<double> datas = new List<double>();
            for (int i = 0; i < res.Count; i++)
            {
                datas.Add(res[i].测试结果);
            }
            double max = datas.Max();
            int maxIndex = datas.IndexOf(max);
            double min = datas.Min();
            int minIndex = datas.IndexOf(min);

            string content1 = "最大值数据为：\n" + "UUT类型：" + res[maxIndex].UUT类型 + "\n" + "UUT编号：" + res[maxIndex].UUT编号 + "\n" + "UUT生产状态：" + res[maxIndex].UUT生产状态 + "\n" + "UUT批次号：" + res[maxIndex].UUT批次号 + "\n" + "通道号：" + res[maxIndex].通道号 + "\n" + "测试数据：" + res[maxIndex].测试结果 + "\n";
            string content2 = "最小值数据为：\n" + "UUT类型：" + res[minIndex].UUT类型 + "\n" + "UUT编号：" + res[minIndex].UUT编号 + "\n" + "UUT生产状态：" + res[minIndex].UUT生产状态 + "\n" + "UUT批次号：" + res[minIndex].UUT批次号 + "\n" + "通道号：" + res[minIndex].通道号 + "\n" + "测试数据：" + res[minIndex].测试结果 + "\n";
            string haha = "最终结果为：" + (max - min) / 2;

            return content1 + content2 + haha;
        }
    }
}
