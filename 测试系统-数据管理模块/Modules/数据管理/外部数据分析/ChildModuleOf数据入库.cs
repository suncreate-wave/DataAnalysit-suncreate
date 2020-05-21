using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using 数据管理模块.Managers;
using 数据管理模块.Models;

namespace 数据管理模块.Modules
{
    public partial class ChildModuleOf数据入库 : BaseModule
    {
        public ChildModuleOf数据入库()
        {
            InitializeComponent();
        }

        private void comboBoxEdit_UUT类型_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChildModuleOf数据入库_Load(object sender, EventArgs e)
        {
            LoadBatchInfo(comboBoxEdit_批次信息);
            LoadUUT类型(comboBoxEdit_UUT类型);
        }

        private void simpleButton_确认添加_Click(object sender, EventArgs e)
        {
            try
            {
                ViewModuleManager.ModuleOf数据管理.TotalReadResults.ForEach(m => m.UUT批次号 = comboBoxEdit_批次信息.Text);
                DbContext dbcontext = new DbContext();

                int count = ViewModuleManager.ModuleOf数据管理.TotalReadResults.Count;

                int insertCount = 10;
                int startIndex = 0;
                int endIndex = count/ insertCount;
                int groupCount = count / insertCount - 0;
                //for (int i = 0; i < insertCount; i++)
                //{
                //    dbcontext.ReadResults.InsertRange(ViewModuleManager.ModuleOf数据管理.ReadResults.GetRange(startIndex,endIndex));
                //    startIndex = endIndex;
                //    if (i == insertCount-1)
                //    {
                //        endIndex += count -1;
                //    }
                //    else
                //    {
                //        endIndex += groupCount;
                //    }
                //}
         
                XtraMessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}