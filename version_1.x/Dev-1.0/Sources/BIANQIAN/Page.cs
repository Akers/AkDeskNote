using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using System.Runtime.InteropServices;

namespace bianqian
{
    public partial class Page : Form
    {
        private Form1 f;
        private Point pt;
        private bool dragging = false;
        private bool closed = false;
        public delegate String GetInputedText();
        public delegate void DontSelectedTexts();
        public GetInputedText getText;
        public DontSelectedTexts unSelectTexts;

        public Page(Form1 f, String texts)
        {
            InitializeComponent();
            this.f = f;
            this.TransparencyKey = this.BackColor;//设置透明色
            this.textBox1.Text = texts;
       
            //委托，取得当前textBox中的文字
            getText = () => { return this.textBox1.Text; };
            //委托，使得textBox中的文本不处于选中状态
            unSelectTexts = () =>
                {
                    this.textBox1.Select(0, 0);
                    Refresh();
                };
            this.textBox1.BorderStyle = BorderStyle.None;
            this.textBox1.BackColor = Color.FromArgb(0, 204, 255);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        public Page(Form1 f, String texts, int x, int y)
            : this(f, texts)
        {
            this.Visible = false;
            this.Location = new Point(x, y);
            this.Refresh();
        }

        public bool PageClosed
        {
            get { return this.closed; }
        }

        private void Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.closed = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                dragging = true;
            pt = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && dragging)
            {
                int px = e.Location.X - pt.X;
                int py = e.Location.Y - pt.Y;
                this.Location = new Point(this.Location.X + px, this.Location.Y + py);
                //pt = e.Location;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.Image = Properties.Resources.hove;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.Image = Properties.Resources.link;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.closed = true;
            f.freshPages();
            this.Dispose();
        }

    }
}
