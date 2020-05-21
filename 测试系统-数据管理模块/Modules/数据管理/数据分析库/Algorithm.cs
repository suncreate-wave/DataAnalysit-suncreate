using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using 数据管理模块.Models;

namespace 数据管理模块.Modules.数据分析库
{
    public interface IAlgorithm
    {
        string Go(List<TestResult测试结果信息> results);
    }

    public class Algorithm
    {
        private IAlgorithm _Algorithm;
        public Algorithm(IAlgorithm al)
        {
            _Algorithm = al;
        }

        public string Go(List<TestResult测试结果信息> results)
        {
            return _Algorithm.Go(results);
        }
    }

    public class AlgorithmManager
    {
        /// <summary>
        /// 载入算法库
        /// </summary>
        /// <returns></returns>
        public static List<string> LoadAllAlgorithm()
        {
            List<string> algorithmNames = new List<string>();
            Assembly _Assembyle = Assembly.GetAssembly(typeof(AlgorithmManager));
            Type[] _TypeList = _Assembyle.GetTypes();

            for (int i = 0; i != _TypeList.Length; i++)
            {
                if (_TypeList[i].Namespace == "数据管理模块.Modules.数据分析库" && _TypeList[i].Name!= "Algorithm" && _TypeList[i].Name != "IAlgorithm" && _TypeList[i].Name != "AlgorithmManager" && _TypeList[i].Name != "<>c")
                {
                    algorithmNames.Add(_TypeList[i].Name);
                }
            }
            return algorithmNames;
        }

        public static string Go(string algorithmName, List<TestResult测试结果信息> results)
        {
           Type t = Type.GetType("数据管理模块.Modules.数据分析库." +algorithmName);

            var obj = t.Assembly.CreateInstance("数据管理模块.Modules.数据分析库." + algorithmName);

            MethodInfo method = t.GetMethod("Go");
            string res = (string)method.Invoke(obj, new object[] { results });
            return res;
        }
    }

}
