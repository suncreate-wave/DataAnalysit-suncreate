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
using DevExpress.XtraEditors.Controls;

namespace 数据管理模块.Modules
{
    public partial class BaseModule : DevExpress.XtraEditors.XtraForm
    {

        public BaseModule()
        {
            InitializeComponent();
        }
        public List<string> UUT生产状态 = new List<string>() {
            "初测",
            "封盖",
            "哈哈",
            };

        public List<string> UUT类型_Base = new List<string>() {
                "DAM-T",
                "DAM-R",
            };
        /// <summary>
        /// 载入批次信息
        /// </summary>
        /// <param name="combo"></param>
        protected void LoadBatchInfo(ComboBoxEdit combo)
        {
            //载入批次信息
            List<UUT批次信息> batchLists = ViewModuleManager.ModuleOfUUT批次信息管理.GetList();
            combo.Properties.Items.Clear();
            List<string> batchNames = new List<string>();
            for (int i = 0; i < batchLists.Count; i++)
            {
                batchNames.Add(batchLists[i].UUT批次号);
            }
            combo.Properties.Items.AddRange(batchNames);
        }

        protected void LoadUUT类型(ComboBoxEdit combo)
        {
            combo.Properties.Items.Clear();
            List<string> batchNames = new List<string>();
            for (int i = 0; i < UUT类型_Base.Count; i++)
            {
                batchNames.Add(UUT类型_Base[i]);
            }
            combo.Properties.Items.AddRange(batchNames);
            combo.SelectedIndex = 0;
        }

        protected void LoadBatchInfo(LookUpEditBase combo)
        {
            List<UUT批次信息> batchLists = ViewModuleManager.ModuleOfUUT批次信息管理.GetList();
            List<string> batchNames = new List<string>();
            batchNames.Add(null);
            for (int i = 0; i < batchLists.Count; i++)
            {
                batchNames.Add(batchLists[i].UUT批次号);
            }
            combo.Properties.DataSource = batchNames;
        }

        protected void Load生产状态(ImageComboBoxEdit combo)
        {
            combo.Properties.Items.Clear();
            List<string> states = new List<string>();
            for (int i = 0; i < UUT生产状态.Count; i++)
            {
                combo.Properties.Items.Add(new ImageComboBoxItem(UUT生产状态[i].ToString(), 0));
            }
            combo.Properties.Items.AddRange(states);
        }

        protected void LoadUUT编号(LookUpEditBase lookupEdit)
        {
            List<string> names = new List<string>();
            names.Add(null);
            for (int i = 0; i < UUT类型_Base.Count; i++)
            {
                 List<UUT状态信息> uutInfos = ViewModuleManager.ModuleOfUUT状态信息.GetList(UUT类型_Base[i]);
                for (int j = 0; j < uutInfos.Count; j++)
                {
                    names.Add(uutInfos[j].UUT编号);
                }
            }
            lookupEdit.Properties.DataSource = names;
        }

        protected void Load报表名称(LookUpEditBase lookupEdit)
        {
            List<string> names = new List<string>();
            names.Add(null);

            List<TestReport测试报表信息> uutInfos = ViewModuleManager.ModuleOf数据管理.GetList();
            for (int j = 0; j < uutInfos.Count; j++)
            {
                names.Add(uutInfos[j].TestReportName);
            }
            //删除重名信息
            HashSet<string> hs = new HashSet<string>(names); //此时已经去掉重复的数据保存在hashset中
            List<string> reports = new List<string>();
            foreach (var item in hs)
            {
                reports.Add(item);
            }
            lookupEdit.Properties.DataSource = reports;
        }
    }
}