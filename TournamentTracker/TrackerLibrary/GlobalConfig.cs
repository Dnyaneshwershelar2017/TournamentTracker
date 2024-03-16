using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IConfigurationRoot configuration { get; set; }
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnection(DatabaseType db)
        {
            if (db ==DatabaseType.Sql)
            {
                //TODO: Create SQL  connection proper
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                //TODO: Create TEXT Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
        /// <summary>
        /// Return Connection String from App.Config
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string CnnString(string name)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        /// <summary>
        /// Get Connection String from AppSetting.json
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string ConnStringSettings(string name)
        {

            return configuration.GetConnectionString(name);
        }
    }
}
