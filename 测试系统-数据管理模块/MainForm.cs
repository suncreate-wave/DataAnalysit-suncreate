using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using 数据管理模块.Managers;
using 数据管理模块.Modules;

namespace 数据管理模块
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //ViewModuleManager.ShowModule(ViewModuleManager.ModuleOfUUT批次信息管理, panel_Module);
            ViewModuleManager.ShowModule(ViewModuleManager.ModuleOf数据管理, panel_Module);
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            switch (e.Item.Elements[0].ToString())
            {
                case "UUT管理":
                    ViewModuleManager.ShowModule(ViewModuleManager.ModuleOfUUT批次信息管理,panel_Module);
                    break;
                case "数据管理":
                    ViewModuleManager.ShowModule(ViewModuleManager.ModuleOf数据管理, panel_Module);
                    break;
                default:
                    break;
            }
        }

        private void tileControl3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
