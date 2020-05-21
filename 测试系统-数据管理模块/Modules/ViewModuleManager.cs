using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数据管理模块.Modules
{
    public class ViewModuleManager
    {
        private static List<Form> CreatedModules = new List<Form>();
        public static Dictionary<Panel,List<Form>> Modules= new Dictionary<Panel, List<Form>>();

        public static ModuleOfUUT批次信息管理 ModuleOfUUT批次信息管理 = new ModuleOfUUT批次信息管理();
        public static ModuleOfUUT状态信息 ModuleOfUUT状态信息 = new ModuleOfUUT状态信息();
        public static ModuleOf数据管理 ModuleOf数据管理 = new ModuleOf数据管理();

        public static ChildModuleOf查看报表 ChildModuleOf查看报表 = new ChildModuleOf查看报表();
        public static ChildModuleOf数据分析 ChildModuleOf查看原始数据 = new ChildModuleOf数据分析();
        public static ChildModuleOf报表导入 ChildModuleOf报表导入 = new ChildModuleOf报表导入();
        public static ChildModuleOf批次详细信息 ChildModuleOf批次详细信息 = new ChildModuleOf批次详细信息();
        public static ChildModuleOf统计分析 ChildModuleOf统计分析 = new ChildModuleOf统计分析();
        public static ChildModuleOf用户选项 ChildModuleOf用户选项 = new ChildModuleOf用户选项();
        public static ChildModuleOf数据入库 ChildModuleOf数据入库 = new ChildModuleOf数据入库();

        public static void ShowModule(Form module, Panel panel)
        {
            var thePanel = Modules.Keys.Where(m=>m == panel).FirstOrDefault();
            if (thePanel == null)
            {
                Modules.Add(panel,new List<Form>());
                thePanel = panel;
            }
            int index = panel.Controls.IndexOf(module);

            Modules[panel].ForEach(m => { m.Visible = false; });
            if (index < 0)
            {
                module.Dock = DockStyle.Fill;
                module.TopLevel = false;
                module.FormBorderStyle = FormBorderStyle.None;
                Modules[panel].Add(module);
                panel.Controls.Add(module);
                module.Show();
            }
            else
            {
                int indexOfModule = Modules[panel].IndexOf(module);
                Modules[panel][indexOfModule].Show();
            }
        }
        public static void Init()
        {
           
        }
        public static DialogResult ShowDialog(Form form)
        {
            return form.ShowDialog();
        }

        public static void Show(Form form)
        {
            form.Show();
        }
    }
}
