using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace bianqian
{
    public partial class Form1 : Form
    {
        public List<Page> pages;
        private XmlDocument xmlDoc;
        public delegate void RefrshPages();
        public RefrshPages frshPages;
        public Form1()
        {
            InitializeComponent();
            frshPages = new RefrshPages(freshPages);
            pages = new List<Page>();
            //读取XML文件
            xmlDoc = new XmlDocument();//xml文档对象
            if (!File.Exists("Configs.xml"))//Xml配置文件不存在时生成新的空白配置文件
            {
                xmlDoc.AppendChild(xmlDoc.CreateNode(XmlNodeType.XmlDeclaration, "", ""));
                xmlDoc.AppendChild(xmlDoc.CreateElement("Papers"));
                xmlDoc.Save("Configs.xml");
            }
            xmlDoc.Load("Configs.xml");
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("Papers").ChildNodes;//取得Papers节点下的所有子节点
            //遍历根节点下的子节点，取得pages窗体的属性
            foreach (XmlNode var in nodeList)
            {
                int x = 0;
                int y = 0;
                XmlElement xe = (XmlElement)var;
                if (!Int32.TryParse(xe.GetAttribute("X"), out x))
                    x = 0;
                if (!Int32.TryParse(xe.GetAttribute("Y"), out y))
                    y = 0;
                pages.Add(new Page(this, var.InnerText, x, y));
            }
            //如果Page窗体列表中的窗体未被注销，则显示他
            foreach (Page p in pages)
            {
                if (!p.IsDisposed)
                {
                    p.Visible = true;
                    p.unSelectTexts();
                }
            }
        }
        //隐藏主窗体
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Hide();
            this.notifyIcon1.Visible = true;
        }
        //刷新所有便条的关闭状态
        public void freshPages()
        {
            for (int i = 0; i < pages.Count;i++ )
            {
                if (pages[i].PageClosed == true)
                    pages.RemoveAt(i);
            }
        }
        //新建便条
        private void MI_newPage_Click(object sender, EventArgs e)
        {
            freshPages();
            int x = 10;
            int y = 10;
            if (pages.Count > 0)
            {
                x = pages[pages.Count - 1].Location.X + 10;
                y = pages[pages.Count - 1].Location.Y + 10;
            }
            Page p = new Page(this, null, x, y);
            p.Visible = true;
            pages.Add(p);
        }
        //显示所有便条
        private void MI_showAll_Click(object sender, EventArgs e)
        {
            foreach (Page p in pages)
            {
                if (!p.PageClosed)
                    p.Visible = true;
            }
        }
        //隐藏所有便条
        private void MI_hideAll_Click(object sender, EventArgs e)
        {
            foreach (Page p in pages)
            {
                if (!p.PageClosed)
                    p.Visible = false;
            }
        }
        //删除所有便条
        private void MI_closeAllPage_Click(object sender, EventArgs e)
        {
            foreach (Page p in pages)
                p.Dispose();
            pages.Clear();
        }
        //退出时保存所有便条
        private void MI_exit_Click(object sender, EventArgs e)
        {
            freshPages();
            XmlNode root = xmlDoc.SelectSingleNode("Papers");
            root.RemoveAll();
            //为每个开启的Page窗口保存设置
            foreach (Page p in pages)
            {
                XmlElement xel = xmlDoc.CreateElement("Page");//创建一个Page节点
                //设置属性
                xel.SetAttribute("X", p.Location.X.ToString());
                xel.SetAttribute("Y", p.Location.Y.ToString());
                //Page的InnerText节点Text
                XmlElement xel_text = xmlDoc.CreateElement("Text");
                xel_text.InnerText = p.getText();
                xel.AppendChild(xel_text);
                root.AppendChild(xel);
            }

            xmlDoc.Save("Configs.xml");
            this.Dispose();
        }
    }
}
