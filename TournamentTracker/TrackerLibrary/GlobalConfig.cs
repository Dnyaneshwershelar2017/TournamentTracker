﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnection(bool database, bool textFile)
        {
            if (database)
            {
                //TODO: Create SQL  connection proper
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFile)
            {
                //TODO: Create TEXT Connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}