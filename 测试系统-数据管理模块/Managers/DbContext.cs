//using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 数据管理模块.Models;

namespace 数据管理模块.Managers
{
    public class DbContext
    {
        public DbContext()
        {
            //Db = new SqlSugarClient(new ConnectionConfig()
            //{
            //    ConnectionString = DataBaseConfig.ConnectionString,
            //    DbType = DbType.Sqlite,
            //    InitKeyType = InitKeyType.Attribute,//从特性读取主键和自增列信息
            //    IsAutoCloseConnection = true,//开启自动释放模式和EF原理一样我就不多解释了
            //});
        }

        //注意：不能写成静态的，不能写成静态的
        //public SqlSugarClient Db;//用来处理事务多表查询和复杂的操作
        //public SimpleClient<UUT批次信息> UUT批次信息表 { get { return new SimpleClient<UUT批次信息>(Db); } }
        //public SimpleClient<UUT状态信息> UUT状态信息表 { get { return new SimpleClient<UUT状态信息>(Db); } }
        //public SimpleClient<TestResult测试结果信息> 测试结果信息表 { get { return new SimpleClient<TestResult测试结果信息>(Db); } }
        //public SimpleClient<ReadResult> ReadResults { get { return new SimpleClient<ReadResult>(Db); } }
        //public SimpleClient<TestReport测试报表信息> TestReport测试报表信息 { get { return new SimpleClient<TestReport测试报表信息>(Db); } }
    }
}
