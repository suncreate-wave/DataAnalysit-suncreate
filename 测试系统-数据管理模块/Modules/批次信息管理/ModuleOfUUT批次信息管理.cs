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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace 数据管理模块.Modules
{
    public partial class ModuleOfUUT批次信息管理 : BaseModule
    {
        public UUT批次信息 UUT批次信息Selected = new UUT批次信息();

        public ModuleOfUUT批次信息管理()
        {
            InitializeComponent();       
        }

        #region 数据库访问
        public List<UUT批次信息> GetList(string uut类型)
        {
            return null;
        }

        public List<UUT批次信息> GetList()
        {
            return null;
        }

        public bool UpdateUUT状态信息(UUT状态信息 uutInfo)
        {
            return false;
        }
        public bool UpdateUUT状态信息(List<UUT状态信息> uutInfo)
        {
            return false;
        }
        /// <summary>
        /// 添加批次信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool Add批次信息(UUT批次信息 info)
        {
            return  true;
        }
        #endregion

        private void ModuleOfUUT批次信息管理_Load(object sender, EventArgs e)
        {
            //载入时刷新一次
            simpleButton_Batch刷新_Click(simpleButton_UUT_刷新,null);
            simpleButton_Batch刷新_Click(simpleButton_Batch_Refresh,null);

            //载入生产状态
            repositoryItemImageComboBox1.Items.Clear();
            for (int i = 0; i < UUT生产状态.Count; i++)
            {
                imageComboBoxEdit_生产状态.Properties.Items.Add(new ImageComboBoxItem(UUT生产状态[i].ToString(), 0));
                repositoryItemImageComboBox1.Items.Add(new ImageComboBoxItem(UUT生产状态[i].ToString(), 0));
            }
            imageComboBoxEdit_生产状态.SelectedIndex = 0;

            //载入基本信息
            Load生产状态(imageComboBoxEdit_UUT生产状态_查询);
            Load生产状态(imageComboBoxEdit_生产状态);
            imageComboBoxEdit_生产状态.SelectedIndex = 0;
            imageComboBoxEdit_UUT生产状态_查询.SelectedIndex = 0;
            LoadUUT编号(searchLookUpEdit_UUT编号);
            LoadUUT类型(comboBoxEdit_UUT类型);
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void simpleButton_Batch刷新_Click(object sender, EventArgs e)
        {
            SimpleButton sb = sender as SimpleButton;
            string[] name = sb.Name.Split('_');
            switch (name[1])
            {
                case "Batch":
                    List<UUT批次信息> infos = GetList();
                    //统计被测件数量
                    for (int i = 0; i < infos.Count; i++)
                    {
                        //string uut类型 = infos[i].UUT类型;
                        //DbContext dbContext = new DbContext();
                        //int count = dbContext.TestReport测试报表信息.AsQueryable().Where(m => m.UUT类型 == uut类型  && m.isFinalTest == true && m.UUT批次号 == infos[i].UUT批次号).ToList().Count;
                        //infos[i].UUT数量 = count;
                    }
                    gridControl_批次信息表.DataSource = infos;
                    gridView_批次信息表.RefreshData();
                    break;
                case "UUT":
                    List<UUT状态信息> uut_infos = ViewModuleManager.ModuleOfUUT状态信息.GetList();
                    gridControl_UUT状态信息.DataSource = uut_infos;
                    gridView_UUT状态信息.RefreshData();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 添加批次信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton_添加批次信息_Click(object sender, EventArgs e)
        {
            SimpleButton sb = sender as SimpleButton;
            string[] name = sb.Name.Split('_');
            switch (name[1])
            {
                case "Batch":
                    ChildModuleOf添加批次信息 module = new ChildModuleOf添加批次信息();
                    module.ShowDialog();
                    break;
                case "UUT":
                    ChildModuleOf添加UUT module2 = new ChildModuleOf添加UUT();
                    module2.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void simpleButton_查询_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 生产状态变更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repositoryItemImageComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] rowHandles = gridView_UUT状态信息.GetSelectedRows();
            if (rowHandles.Length!=0)
            {
                for (int i = 0; i < rowHandles.Length; i++)
                {
                    UUT状态信息 uutInfo = gridView_UUT状态信息.GetRow(rowHandles[i]) as UUT状态信息;
                    UpdateUUT状态信息(uutInfo);
                }
            }       
        }

        /// <summary>
        /// 确认修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton_UUT信息_Click(object sender, EventArgs e)
        {
            int[] rowHandles = gridView_UUT状态信息.GetSelectedRows();
            List<UUT状态信息> infos = new List<UUT状态信息>();
            if (rowHandles.Length != 0)
            {
                for (int i = 0; i < rowHandles.Length; i++)
                {
                    UUT状态信息 info =  gridView_UUT状态信息.GetRow(rowHandles[i]) as UUT状态信息;
                    info.UUT生产状态 = imageComboBoxEdit_生产状态.Text;
                    infos.Add(info);
                }
            }
            UpdateUUT状态信息(infos);
            gridView_UUT状态信息.RefreshData();
        }

        #region GridControl右键菜单以及双击事件
        /// <summary>
        /// 右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridControl_批次信息表_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                GridHitInfo info = gridView_批次信息表.CalcHitInfo(e.Location);
                if (e.Button == MouseButtons.Right && info.InRowCell)
                {
                    popupMenu1.ShowPopup(gridControl_批次信息表.PointToScreen(e.Location));
                }
            }
            catch (Exception) { }
        }

        /// <summary>
        /// 双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridControl_批次信息表_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hInfo = gridView_批次信息表.CalcHitInfo(new Point(e.X, e.Y));
                if (e.Button == MouseButtons.Left && e.Clicks == 2)
                {
                    if (hInfo.InRow)
                    {
                        int rowHandle = hInfo.RowHandle;
                        //更新已选批次信息
                        UUT批次信息Selected = gridView_批次信息表.GetRow(rowHandle) as UUT批次信息;
                        new ChildModuleOf批次详细信息().Show();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 菜单按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Caption)
            {
                case "查看详细":
                    new ChildModuleOf批次详细信息().Show();
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<UUT状态信息> infos = new List<UUT状态信息>();
            for (int i = 1001; i < 2001; i++)
            {
                UUT状态信息 info = new UUT状态信息()
                {
                    UUT类型 = "DAM-T",
                    UUT生产状态 = "初测",
                    UUT编号 = i.ToString()
                };
                infos.Add(info);
            }
            ViewModuleManager.ModuleOfUUT状态信息.Add状态信息(infos);
            XtraMessageBox.Show("添加成功！");
        }
    }
}