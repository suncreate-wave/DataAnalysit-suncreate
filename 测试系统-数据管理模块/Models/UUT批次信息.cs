//using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据管理模块.Models
{
    //[SugarTable("UUT批次信息")]
    public class UUT批次信息
    {
        //[SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }

        //[SugarColumn(ColumnName = "UUT类型")]
        public string UUT类型 { get; set; }

        //[SugarColumn(ColumnName = "UUT批次号")]
        public string UUT批次号 { get; set; }

        /// <summary>
        /// 测试软件不填
        /// </summary>
        //[SugarColumn(ColumnName = "创建时间")]
        public string 创建时间 { get; set; }

        /// <summary>
        /// 测试软件不填
        /// </summary>
        //[SugarColumn(ColumnName = "UUT数量")]
        public int UUT数量 { get; set; }
    }
}
