namespace 数据管理模块.Models
{
    //[SugarTable("测试结果信息")]
    public class TestResult测试结果信息
    {
        //[SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }

        //[SugarColumn(ColumnName = "UUT类型")]
        public string UUT类型 { get; set; }

        //[SugarColumn(ColumnName = "UUT编号")]
        public string UUT编号 { get; set; }

        //[SugarColumn(ColumnName = "UUT批次号")]
        public string UUT批次号 { get; set; }//由数据管理模块控制，测试系统可以不填

        //[SugarColumn(ColumnName = "UUT生产状态")]
        public string UUT生产状态 { get;set; }//由数据管理模块控制，测试系统可以不填

        //[SugarColumn(ColumnName = "通道号")]
        public int 通道号 { get; set; }//不好填通道的测试项目可以填0

        //[SugarColumn(ColumnName = "频点(MHz)")]
        public string 频点 { get; set; }

        //[SugarColumn(ColumnName = "测试项目名称")]
        public string 测试项目名称 { get; set; }//可以填比如 指标A-原始数据 或 指标A-小指标名称 类似的举一反三

        //[SugarColumn(ColumnName = "测试报表标识")]
        public int TestReportID { get;set; }//由数据管理模块控制，测试系统可以不填

        //[SugarColumn(ColumnName = "测试结果")]
        public double 测试结果 { get; set; }
    }
}
