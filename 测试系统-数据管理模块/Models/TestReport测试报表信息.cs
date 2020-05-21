namespace 数据管理模块.Models
{
    //[SugarTable("测试报表信息")]
    public class TestReport测试报表信息
    {
        //[SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }//由数据管理模块控制，测试系统可以不填

        //[SugarColumn(ColumnName = "UUT类型")]
        public string UUT类型 { get; set; }

        //[SugarColumn(ColumnName = "UUT编号")]
        public string UUT编号 { get; set; }

        //[SugarColumn(ColumnName = "UUT批次号")]
        public string UUT批次号 { get; set; }

        //[SugarColumn(ColumnName = "UUT生产状态")]
        public string UUT生产状态 { get; set; }//由数据管理模块控制，测试系统可以不填

        //[SugarColumn(ColumnName = "是否是最终测试")]
        public bool isFinalTest { get; set; }

        //[SugarColumn(ColumnName = "报表名称")]
        public string TestReportName { get; set; }

        //[SugarColumn(ColumnName = "报表内容")]
        public byte[] TestReportContent { get; set; }

        //[SugarColumn(ColumnName = "备注",IsNullable =true)]
        public string TestReport备注 { get;set;}

        //[SugarColumn(ColumnName = "创建时间")]
        public string TestReport创建时间 { get; set; }//由数据管理模块控制，测试系统可以不填
    }
}
