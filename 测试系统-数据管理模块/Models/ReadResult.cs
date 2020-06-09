using System.Collections.Generic;
using System;

namespace 数据管理模块.Models
{
    //[SugarTable("ReadResult")]
    public class ReadResult:IComparable<ReadResult>
    {
        //[SugarColumn(ColumnName = "UUT编号")]
        public string UUT编号 { get;set; }//Excel的名称，不含扩展名
        //[SugarColumn(ColumnName = "频点", IsNullable = true)]
        public string 频点 { get;set;}//第一列
        //[SugarColumn(ColumnName = "通道号")]
        public int 通道号 {get;set; }
        //[SugarColumn(ColumnName = "测试项目")]
        public string  测试项目 {get;set; }
        //[SugarColumn(ColumnName = "测试结果")]
        public decimal 测试结果 {get;set; }
        //[SugarColumn(ColumnName = "UUT批次号",IsNullable =true)]
        public string UUT批次号 { get; set; }
        public bool IsPassed { get;set;}

        public int CompareTo(ReadResult other)
        {
            if (测试结果 > other.测试结果)
            {
                return 1;
            }
            else if(测试结果  ==  other.测试结果)
            {
                return 0;
            }
            else
            {
                return -1;
            }      
        }
    }
}
