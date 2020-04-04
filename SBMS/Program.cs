using System;
using System.Windows.Forms;



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
            Application.Run(new Selection());

            /* try
             {
                 SqlConnection conn = DatabaseServices.GetConnection();
                 Console.WriteLine("HELLO WORDL"+conn.State);

                 LookUpServices lookUpServices = new LookUpServices();
                 DataTable t = lookUpServices.fetchLookupTables("validations");
                 Console.WriteLine(t.Rows.Count);


             }
             catch (Exception e) {
                 MessageBox.Show("Hi, the system is reporting problem with SQL Server Database\n"+e.Message, "Initalising Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
        }
    }
}
