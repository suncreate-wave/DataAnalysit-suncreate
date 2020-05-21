using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 数据管理模块.Models;

namespace 数据管理模块.Modules
{
    public class DataCollectionModule
    {
        public virtual Dictionary<int, string> GetDictionary()
        {
            return new Dictionary<int, string>();
        }

        public virtual List<ReadResult> LoadExcelData(string path)
        {
            ConcurrentQueue<ReadResult> resultList = new ConcurrentQueue<ReadResult>();
            return resultList.ToList();
        }
    }
}
