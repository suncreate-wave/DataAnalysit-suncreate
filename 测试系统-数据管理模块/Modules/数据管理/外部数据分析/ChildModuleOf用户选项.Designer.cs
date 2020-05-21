namespace 数据管理模块.Modules
{
    partial class ChildModuleOf用户选项
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildModuleOf用户选项));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit_UUT类型 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit_测试模式 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_UUT类型.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_测试模式.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(60, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "UUT类型：";
            // 
            // comboBoxEdit_UUT类型
            // 
            this.comboBoxEdit_UUT类型.Location = new System.Drawing.Point(159, 55);
            this.comboBoxEdit_UUT类型.Name = "comboBoxEdit_UUT类型";
            this.comboBoxEdit_UUT类型.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit_UUT类型.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit_UUT类型.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_UUT类型.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit_UUT类型.Size = new System.Drawing.Size(159, 24);
            this.comboBoxEdit_UUT类型.TabIndex = 2;
            this.comboBoxEdit_UUT类型.TextChanged += new System.EventHandler(this.comboBoxEdit_UUT类型_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(60, 120);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "测试模式：";
            // 
            // comboBoxEdit_测试模式
            // 
            this.comboBoxEdit_测试模式.Location = new System.Drawing.Point(159, 117);
            this.comboBoxEdit_测试模式.Name = "comboBoxEdit_测试模式";
            this.comboBoxEdit_测试模式.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit_测试模式.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit_测试模式.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_测试模式.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit_测试模式.Size = new System.Drawing.Size(159, 24);
            this.comboBoxEdit_测试模式.TabIndex = 2;
            this.comboBoxEdit_测试模式.TextChanged += new System.EventHandler(this.comboBoxEdit_UUT类型_TextChanged);
            // 
            // ChildModuleOf用户选项
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 224);
            this.Controls.Add(this.comboBoxEdit_测试模式);
            this.Controls.Add(this.comboBoxEdit_UUT类型);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChildModuleOf用户选项";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户选项";
            this.Load += new System.EventHandler(this.ChildModuleOf查看报表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_UUT类型.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_测试模式.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_UUT类型;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_测试模式;
    }
}