using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace MySQL_Backup_and_Restore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThreadAttribute]
        static void Main(string[] args)
        {

            string lang = "";
            try
            {
                lang = args[0];
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);

            }

            CultureInfo cul = new CultureInfo(lang);

            Thread.CurrentThread.CurrentCulture = cul;
            Thread.CurrentThread.CurrentUICulture = cul;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BackupAr());
        }
    }
}
