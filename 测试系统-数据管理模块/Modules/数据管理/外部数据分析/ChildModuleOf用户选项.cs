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
    public partial class ChildModuleOf用户选项 : BaseModule
    {
        public string UUTName = "DAM-R";
        public string 测试模式 = "自测模式";

        public ChildModuleOf用户选项()
        {
            InitializeComponent();
            Init();
        }

        private void ChildModuleOf查看报表_Load(object sender, EventArgs e)
        {
        }
        private void Init()
        {
            comboBoxEdit_UUT类型.Properties.Items.Add("DAM-R");
            comboBoxEdit_UUT类型.Properties.Items.Add("DAM-T");
            comboBoxEdit_测试模式.Properties.Items.Add("自测模式");
            comboBoxEdit_测试模式.Properties.Items.Add("军检模式");
            comboBoxEdit_测试模式.Properties.Items.Add("环境试验模式");
            comboBoxEdit_UUT类型.SelectedIndex = 0;
            comboBoxEdit_测试模式.SelectedIndex = 0;
        }

        private void comboBoxEdit_UUT类型_TextChanged(object sender, EventArgs e)
        {
            ComboBoxEdit combo = sender as ComboBoxEdit;
            switch (comboBoxEdit_UUT类型.Text + "-" + comboBoxEdit_测试模式.Text)
            {
                case "DAM-R-自测模式":
                    ViewModuleManager.ChildModuleOf统计分析.CurrentDataCollectionModule = new DataCollection_DAM_R_自测模式();
                    break;
                case "DAM-R-军检模式":
                    ViewModuleManager.ChildModuleOf统计分析.CurrentDataCollectionModule = new DataCollection_DAM_R_军检模式();
                    break;
                case "DAM-R-环境试验模式":
                    ViewModuleManager.ChildModuleOf统计分析.CurrentDataCollectionModule = new DataCollection_DAM_R_环境试验模式();
                    break;
                case "DAM-T-自测模式":
                    ViewModuleManager.ChildModuleOf统计分析.CurrentDataCollectionModule = new DataCollection_DAM_T_自测模式();
                    break;
                case "DAM-T-军检模式":
                    ViewModuleManager.ChildModuleOf统计分析.CurrentDataCollectionModule = new DataCollection_DAM_T_军检模式();
                    break;
                case "DAM-T-环境试验模式":
                    ViewModuleManager.ChildModuleOf统计分析.CurrentDataCollectionModule = new DataCollection_DAM_T_环境试验模式();
                    break;
                default:
                    break;
            }
        }
    }
}