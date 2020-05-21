using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据管理模块.Models
{
    //[SugarTable("UUT类型信息")]
    public class UUT类型信息
    {
        public int ID { get; set; }

        //[SugarColumn(ColumnName = "UUT类型")]
        public string UUT类型 { get; set; }
    }
}
