using System;
using System.Windows.Forms;


namespace PxKeystrokesUi
{
    static class Program
    {
        /// <summary>
        /// プログラムのメイン
        /// STA(Single Threaded Apartment)は、Windows Form を使うときに必要なAttributeらしい
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PxApplicationContext());
        }
    }
}
