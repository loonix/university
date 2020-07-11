using Codr.Forms;
using System;
using System.Windows.Forms;

namespace Codr
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Automatically starts the main form
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
