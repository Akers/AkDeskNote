namespace bianqian
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CMS_IconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MI_newPage = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_showAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_hideAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_closeAllPage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MI_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_IconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.CMS_IconMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Akers桌面便签";
            this.notifyIcon1.Visible = true;
            // 
            // CMS_IconMenu
            // 
            this.CMS_IconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_newPage,
            this.MI_showAll,
            this.MI_hideAll,
            this.MI_closeAllPage,
            this.toolStripSeparator1,
            this.MI_exit});
            this.CMS_IconMenu.Name = "CMS_IconMenu";
            this.CMS_IconMenu.Size = new System.Drawing.Size(153, 142);
            // 
            // MI_newPage
            // 
            this.MI_newPage.Name = "MI_newPage";
            this.MI_newPage.Size = new System.Drawing.Size(152, 22);
            this.MI_newPage.Text = "新建便签";
            this.MI_newPage.Click += new System.EventHandler(this.MI_newPage_Click);
            // 
            // MI_showAll
            // 
            this.MI_showAll.Name = "MI_showAll";
            this.MI_showAll.Size = new System.Drawing.Size(152, 22);
            this.MI_showAll.Text = "显示所有便条";
            this.MI_showAll.Click += new System.EventHandler(this.MI_showAll_Click);
            // 
            // MI_hideAll
            // 
            this.MI_hideAll.Name = "MI_hideAll";
            this.MI_hideAll.Size = new System.Drawing.Size(152, 22);
            this.MI_hideAll.Text = "隐藏所有便条";
            this.MI_hideAll.Click += new System.EventHandler(this.MI_hideAll_Click);
            // 
            // MI_closeAllPage
            // 
            this.MI_closeAllPage.Name = "MI_closeAllPage";
            this.MI_closeAllPage.Size = new System.Drawing.Size(152, 22);
            this.MI_closeAllPage.Text = "关闭所有便签";
            this.MI_closeAllPage.Click += new System.EventHandler(this.MI_closeAllPage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // MI_exit
            // 
            this.MI_exit.Name = "MI_exit";
            this.MI_exit.Size = new System.Drawing.Size(152, 22);
            this.MI_exit.Text = "退出";
            this.MI_exit.Click += new System.EventHandler(this.MI_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 249);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CMS_IconMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip CMS_IconMenu;
        private System.Windows.Forms.ToolStripMenuItem MI_newPage;
        private System.Windows.Forms.ToolStripMenuItem MI_closeAllPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MI_exit;
        private System.Windows.Forms.ToolStripMenuItem MI_showAll;
        private System.Windows.Forms.ToolStripMenuItem MI_hideAll;
    }
}

