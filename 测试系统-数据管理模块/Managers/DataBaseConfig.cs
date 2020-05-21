//using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 数据管理模块.Models;

namespace 数据管理模块
{
    public class DataBaseConfig
    {
        public static string ConnectionString = "Data Source=" + @"DAM项目数据库.db" + ";Version=3;";
        /// <summary>
        /// 直接调用该函数即可完成建表
        /// </summary>
        public static void InitDataBase()
        {          
            //建立连接
            //SqlSugarClient db = new SqlSugarClient(
            //new ConnectionConfig()
            //{
            //    ConnectionString = ConnectionString,
            //    DbType = DbType.Sqlite,//设置数据库类型
            //    IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
            //    InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
            //});

            /**InitTables函数是将实体转换成数据库表生成表，并且修改类会备份 例如表A，备份表名为 A+时间
              * db.CodeFirst.BackupTable().InitTables(typeof(CodeTable), typeof(CodeTable2));
              * 生成表不会备份表
              * db.CodeFirst.InitTables(typeof(CodeTable), typeof(CodeTable2));
              * 给varchar设置默认长度
              * db.CodeFirst.SetStringDefaultLength(10).InitTables(typeof(CodeTable), typeof(CodeTable2));
              **/

            /** 修改列名
               *   如果实体属性名称为Name我要将Name改成NewName
               *   我们只需要修改实体
               *   [SugarColumn(Length = 21, OldColumnName = "Name")]
                *   public string NewName { get; set; }
                *   然后执行InitTables便可,注意如果不这样操作，会将原有列删除创建新列
                **/
            //db.CodeFirst.InitTables(new Type[] {
            //     typeof(UUT状态信息),
            //     typeof(UUT批次信息),
            //    typeof(TestResult测试结果信息),       
            //    typeof(TestReport测试报表信息),
            //    typeof(ReadResult)
            //});
        }
    }
}
