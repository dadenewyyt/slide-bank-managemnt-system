using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBMS.Services;



namespace SBMS
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
             Application.Run(new Login());

            //DatabaseServices db = new DatabaseServices();
            //Console.WriteLine(DatabaseServices.GetConnection().ConnectionString);
        }
    }
}
