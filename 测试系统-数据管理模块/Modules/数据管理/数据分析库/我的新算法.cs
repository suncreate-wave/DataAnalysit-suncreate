using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 数据管理模块.Models;

namespace 数据管理模块.Modules.数据分析库
{
    public class 我的新算法 : IAlgorithm
    {
        public string Go(List<TestResult测试结果信息> results)
        {
            List<TestResult测试结果信息> res = results.Where(m => m.频点 == "1000").ToList();
            List<double> datas = new List<double>();
            for (int i = 0; i < res.Count; i++)
            {
                datas.Add(res[i].测试结果);
            }
    


            return "nihao最大值为：" + datas.Max();
        }
    }
}
