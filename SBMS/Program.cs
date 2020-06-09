using MSBMS.Reports.CrystalReports;
using MSBMS.Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace MSBMS
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

                    Application.Run(new Lending());

                }
                else {
                    bool result = importDefaultsService.addDefaultCountryOfOrigin();
                    if (result == false)
                    {
                        logger.Error("Hi, the system is reporting problem importing Counry of Origin\n");
                        Application.Exit();
                    }
                    else {
                        Application.Run(new Lending());
                    }
                }
            }
             catch (Exception ex) {
                 MessageBox.Show(ex.Message+"Hi, the system is reporting problem with SQL \n");
                 logger.Error(ex,"see application log error for the cause of this error \n");
 
            }

        }
    }
}
