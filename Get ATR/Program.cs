using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cop_78NFC
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
            Console.WriteLine("Program start...");
            Application.Run(new Cop78NFC());
        }
    }
}
