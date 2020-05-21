using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 数据管理模块.Managers;
using 数据管理模块.Models;
using 数据管理模块.Modules;

namespace 数据管理模块.Interface
{
    public class DataManagerModule
    {
        /// <summary>
        /// 插入测试数据，大致逻辑如下：
        /// 
        /// 1. 测试数据完成填表工作+上传（调用InsertTestReport）工作，得到TestReportID，用于标识该次测试。
        /// 2. 对于传入的UUT编号不存在的，自动创建该UUT，并将其初始状态设置为默认的生产状态。
        ///     对于传入的UUT编号已经存在的，则不继续处理。
        /// 3. 从UUT状态表中读取UUT状态信息情况，并将其当前的生产状态设置到TestResult的对应属性上。
        /// 4. 对于UUT类型不存在的直接报错。
        /// 5. （需由测试软件配合实现）对于UUT批次号不存在的，测试软件检查到该问题后，提示用户是否要创建新的批次号，选择是，则调用InsertBatchNumber函数。
        /// 6. 
        /// </summary>
        /// <param name="results"></param>
        /// <returns>结果信息</returns>
        public static string InsertRangeTestResults(List<TestResult测试结果信息> results)
        {
            return "";
            //DbContext dbcontext = new DbContext();

            ////判断reportID是否重复
            ////if (dbcontext.TestReport测试报表信息.AsQueryable().Where(m => m.ID == results.First().TestReportID).Count() != 1)
            ////{
            ////    return "报表ID已经存在";
            ////}
           
            //string uutNumber = results.First().UUT编号;
            //string batchNumber = results.First().UUT批次号;
            //string uutStyle = results.First().UUT类型;
            ////判断UUT类型
            //if (ViewModuleManager.ModuleOfUUT状态信息.UUT类型_Base.Where(m => m == uutStyle).Count() == 0)
            //{
            //    return "不存在该UUT类型信息，请先添加UUT类型信息";
            //}
            ////判断批次信息
            //if (ViewModuleManager.ModuleOfUUT批次信息管理.GetList(uutStyle).Count == 0)
            //{
            //    return "不存在该UUT批次信息，请先添加UUT批次信息";
            //}
            ////插入新的编号状态信息，保证数据库中一定有UUT状态信息
            //ViewModuleManager.ModuleOfUUT状态信息.Add状态信息(new UUT状态信息() {
            //    UUT生产状态 = ViewModuleManager.ModuleOfUUT状态信息.UUT生产状态.First(),
            //    UUT类型 = uutStyle,
            //    UUT编号 = uutNumber
            //});
            ////读取UUT生产状态
            //string uutState = dbcontext.UUT状态信息表.AsQueryable().Where(M => M.UUT类型 == uutStyle && M.UUT编号 == uutNumber).First().UUT生产状态;

            //for (int i = 0; i < results.Count; i++)
            //{
            //    results[i].UUT生产状态 = uutState;
            //}
            //if (dbcontext.测试结果信息表.InsertRange(results))
            //{
            //    return "数据存储成功";
            //}
            //else
            //{
            //    return "数据存储失败";
            //}         
        }

        /// <summary>
        /// 插入测试报表
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        public static int InsertTestReport(TestReport测试报表信息 report)
        {
            return ViewModuleManager.ModuleOf数据管理.Add测试报表(report);
        }
        /// <summary>
        /// 创建新的批次号
        /// </summary>
        /// <param name="uutBatch"></param>
        /// <returns></returns>
        public static bool InsertBatchNumber(UUT批次信息 uutBatch)
        {
              return ViewModuleManager.ModuleOfUUT批次信息管理.Add批次信息(uutBatch);
        }
    }
}
