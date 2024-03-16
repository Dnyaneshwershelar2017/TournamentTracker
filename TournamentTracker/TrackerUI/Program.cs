using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using TrackerLibrary;
using TrackerLibrary.DataAccess;

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


            //Getting details from appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            GlobalConfig.configuration = (IConfigurationRoot)builder.Build();


            GlobalConfig.InitializeConnection(DatabaseType.TextFile);

            Application.Run(new CreateTeamForm());
           // Application.Run(new TournamentDashboardForm());
        }
    }
}
