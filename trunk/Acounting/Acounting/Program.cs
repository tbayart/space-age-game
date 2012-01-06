using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.IO;

namespace Acounting
{
    static class Program
    {   
        static public CultureInfo cul;
        public static myLogger mylog = new myLogger();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string lang="";
            try
            {
                lang = Application.UserAppDataRegistry.GetValue("Language").ToString();
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                 
            }
            
            cul = new CultureInfo(lang);

            Thread.CurrentThread.CurrentCulture = cul;
            Thread.CurrentThread.CurrentUICulture = cul;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ExceptionLogger exl = new ExceptionLogger();
            exl.NotificationType = NotificationType.Silent;
           
            exl.AddLogger(mylog);

            Application.Run(new Main());
            

 
        }
        public class myLogger : LoggerImplementation
        {
            public override void LogError(string error)
            {
                StreamWriter file = new StreamWriter(Application.StartupPath + "\\log.log",true);
                file.Write(error); 
            }
        }
    }
}
