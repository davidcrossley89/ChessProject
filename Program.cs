using System;
using System.Windows.Forms;

namespace TestChess
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 view = new Form1();
            Application.Run(view);






        }
    }
}
