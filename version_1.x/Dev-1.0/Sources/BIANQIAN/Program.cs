using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bianqian
{

    static class Program
    {
        //static bool loginWindowShowed = false;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
