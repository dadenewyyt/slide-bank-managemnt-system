using SBMS.Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace SBMS
{
    static class Program
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ImportDefaultsService importDefaultsService = new ImportDefaultsService();


            try
             {
                 logger.Info("importing defaults");
                int id = importDefaultsService.CheckIfDefaultExisits();
                if (id !=-1)
                {
                    logger.Info("Default is found proceeding.");
                    StartupValueServices.Exchange_id_default = id;

                    Application.Run(new MDIChild());

                }
                else {
                    bool result = importDefaultsService.addDefaultCountryOfOrigin();
                    if (result == false)
                    {
                        logger.Error("Hi, the system is reporting problem importing Counry of Origin\n");
                        Application.Exit();
                    }
                    else {
                        Application.Run(new Splash());
                    }
                }
            }
             catch (Exception ex) {
                 MessageBox.Show(ex.Message+"Hi, the system is reporting problem with SQL Server Database\n");
                 logger.Error(ex,"Hi, the system is reporting problem importing Counry of Origin\n");
                 Application.Exit();
                 
            }

        }
    }
}
