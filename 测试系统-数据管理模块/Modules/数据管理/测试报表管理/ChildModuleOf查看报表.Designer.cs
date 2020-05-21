namespace 数据管理模块.Modules
{
    partial class ChildModuleOf查看报表
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildModuleOf查看报表));
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Import.Csv.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Csv.Encoding")));
            this.spreadsheetControl1.Options.Import.Txt.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Txt.Encoding")));
            this.spreadsheetControl1.Size = new System.Drawing.Size(838, 635);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // ChildModuleOf查看报表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 635);
            this.Controls.Add(this.spreadsheetControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChildModuleOf查看报表";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看报表";
            this.Load += new System.EventHandler(this.ChildModuleOf查看报表_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
    }
}