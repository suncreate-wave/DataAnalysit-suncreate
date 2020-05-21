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
using 数据管理模块.Models;
using 数据管理模块.Managers;
using DevExpress.XtraEditors.Controls;

namespace 数据管理模块.Modules
{
    public partial class ModuleOfUUT状态信息 : BaseModule
    {
        public ModuleOfUUT状态信息()
        {
            InitializeComponent();
        }

        public List<UUT状态信息> GetList(string uut类型)
        {
            return null;
        }

        public List<UUT状态信息> GetList()
        {
            return null;
        }

        public bool Add状态信息(UUT状态信息 info)
        {
            //DbContext dbcontext = new DbContext();
            //检查有无重复
            return false;
        }

        public void Add状态信息(List<UUT状态信息> infos)
        {

        }
    }
}