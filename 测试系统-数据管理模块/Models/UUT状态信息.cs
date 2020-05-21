//using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据管理模块.Models
{
    //[SugarTable("UUT状态信息")]
    public class UUT状态信息
    {
        //[SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }

        //[SugarColumn(ColumnName = "UUT类型")]
        public string UUT类型 { get; set; }

        //[SugarColumn(ColumnName = "UUT编号")]
        public string UUT编号 { get; set; }

        //[SugarColumn(ColumnName = "UUT生产状态")]
        public string UUT生产状态 { get;set; }
    }
}
