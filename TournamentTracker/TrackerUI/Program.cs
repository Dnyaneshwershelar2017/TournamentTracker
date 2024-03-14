using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize the database connections

          

            var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);


            ConfigurationBuilder configuration = builder.

            string connectionString = configuration.GetConnectionString("MyDatabaseConnection");


            TrackerLibrary.GlobalConfig.InitializeConnection(true,true);

            Application.Run(new CreatePrizeForm());
           // Application.Run(new TournamentDashboardForm());
        }
    }
}
