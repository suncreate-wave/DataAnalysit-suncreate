namespace 数据管理模块.Modules
{
    partial class ChildModuleOf批次详细信息
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("合格率", new object[] {
            ((object)(60D))}, 0);
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("不合格率", new object[] {
            ((object)(40D))}, 1);
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            this.gridView_报表数据 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl_批次信息表 = new DevExpress.XtraGrid.GridControl();
            this.gridView_批次信息表 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_报表数据)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_批次信息表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_批次信息表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView_报表数据
            // 
            this.gridView_报表数据.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16});
            this.gridView_报表数据.GridControl = this.gridControl_批次信息表;
            this.gridView_报表数据.Name = "gridView_报表数据";
            this.gridView_报表数据.OptionsBehavior.Editable = false;
            this.gridView_报表数据.OptionsBehavior.ReadOnly = true;
            this.gridView_报表数据.OptionsView.ShowGroupPanel = false;
            this.gridView_报表数据.OptionsView.ShowIndicator = false;
            this.gridView_报表数据.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView_报表数据_SelectionChanged);
            this.gridView_报表数据.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_报表数据_FocusedRowChanged);
            // 
            // gridColumn11
            // 
            this.gridColumn11.ColumnEdit = this.repositoryItemImageEdit2;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            this.gridColumn11.Width = 50;
            // 
            // repositoryItemImageEdit2
            // 
            this.repositoryItemImageEdit2.AutoHeight = false;
            this.repositoryItemImageEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit2.ContextImageOptions.SvgImage = global::数据管理模块.Properties.Resources.xlsx;
            this.repositoryItemImageEdit2.ContextImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.repositoryItemImageEdit2.Name = "repositoryItemImageEdit2";
            this.repositoryItemImageEdit2.ReadOnly = true;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "报表名称";
            this.gridColumn12.FieldName = "TestReportName";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            this.gridColumn12.Width = 277;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "备注";
            this.gridColumn13.FieldName = "TestReport备注";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.ReadOnly = true;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 3;
            this.gridColumn13.Width = 172;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "创建时间";
            this.gridColumn14.FieldName = "TestReport创建时间";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.ReadOnly = true;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 5;
            this.gridColumn14.Width = 204;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "合格情况";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            this.gridColumn15.Width = 88;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "生产状态";
            this.gridColumn16.FieldName = "UUT生产状态";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 2;
            this.gridColumn16.Width = 198;
            // 
            // gridControl_批次信息表
            // 
            this.gridControl_批次信息表.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView_报表数据;
            gridLevelNode1.RelationName = "Detail";
            this.gridControl_批次信息表.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl_批次信息表.Location = new System.Drawing.Point(2, 33);
            this.gridControl_批次信息表.MainView = this.gridView_批次信息表;
            this.gridControl_批次信息表.Name = "gridControl_批次信息表";
            this.gridControl_批次信息表.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageEdit1,
            this.repositoryItemImageEdit2});
            this.gridControl_批次信息表.Size = new System.Drawing.Size(989, 549);
            this.gridControl_批次信息表.TabIndex = 3;
            this.gridControl_批次信息表.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_批次信息表,
            this.gridView_报表数据});
            // 
            // gridView_批次信息表
            // 
            this.gridView_批次信息表.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn7,
            this.gridColumn1,
            this.gridColumn9,
            this.gridColumn8,
            this.gridColumn6,
            this.gridColumn10});
            this.gridView_批次信息表.GridControl = this.gridControl_批次信息表;
            this.gridView_批次信息表.Name = "gridView_批次信息表";
            this.gridView_批次信息表.OptionsBehavior.Editable = false;
            this.gridView_批次信息表.OptionsBehavior.ReadOnly = true;
            this.gridView_批次信息表.OptionsView.ShowGroupPanel = false;
            this.gridView_批次信息表.RowHeight = 32;
            // 
            // gridColumn3
            // 
            this.gridColumn3.ColumnEdit = this.repositoryItemImageEdit1;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 65;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.ContextImageOptions.SvgImage = global::数据管理模块.Properties.Resources.huabanfuben2;
            this.repositoryItemImageEdit1.ContextImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID";
            this.gridColumn4.FieldName = "ID";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "UUT测试次数";
            this.gridColumn7.FieldName = "UUT测试次数";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 100;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "UUT生产状态";
            this.gridColumn1.FieldName = "UUT生产状态";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 216;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "合格情况";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 66;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "备注";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            this.gridColumn8.Width = 223;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "UUT编号";
            this.gridColumn6.FieldName = "UUT编号";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 300;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "测试数据";
            this.gridColumn10.FieldName = "Detail";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 906);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(1003, 906);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupControl2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(993, 584);
            this.panel5.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImageOptions.SvgImage = global::数据管理模块.Properties.Resources.m_reports;
            this.groupControl2.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.groupControl2.Controls.Add(this.gridControl_批次信息表);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(993, 584);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "批次-UUT 信息（The Batch Mapping UUT View）";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupControl8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 589);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(993, 312);
            this.panel4.TabIndex = 0;
            // 
            // groupControl8
            // 
            this.groupControl8.AppearanceCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl8.AppearanceCaption.Options.UseFont = true;
            this.groupControl8.CaptionImageOptions.SvgImage = global::数据管理模块.Properties.Resources.m_asm;
            this.groupControl8.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.groupControl8.Controls.Add(this.panel6);
            this.groupControl8.Controls.Add(this.panel2);
            this.groupControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl8.Location = new System.Drawing.Point(0, 0);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(993, 312);
            this.groupControl8.TabIndex = 9;
            this.groupControl8.Text = "批次测试概述（Batch Conclusion）";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chartControl1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(508, 33);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(483, 277);
            this.panel6.TabIndex = 1;
            // 
            // chartControl1
            // 
            this.chartControl1.BackColor = System.Drawing.Color.Transparent;
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            seriesPoint1.ColorSerializable = "#00B050";
            seriesPoint2.ColorSerializable = "#F00000";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2});
            seriesTitle1.Text = "批次合格率";
            pieSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(483, 277);
            this.chartControl1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.labelControl5);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(2, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 277);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(328, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(210, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "100%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(171, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "100%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(191, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "000";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(385, 39);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(14, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "次";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(248, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "次,累计测试";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 192);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(168, 19);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "③该批次一次测试合格率为";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(140, 19);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "②该批次当前合格率为";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(168, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "①该批次测试被测件数量为";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "UUT数量";
            this.gridColumn5.FieldName = "UUT数量";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 68;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "UUT类型";
            this.gridColumn2.FieldName = "UUT类型";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // ChildModuleOf批次详细信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 906);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChildModuleOf批次详细信息";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批次详细信息";
            this.Load += new System.EventHandler(this.ChildModuleOf批次详细信息_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_报表数据)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_批次信息表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_批次信息表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl_批次信息表;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_批次信息表;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.GroupControl groupControl8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_报表数据;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
    }
}