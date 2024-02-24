using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    class SqlConnector : IDataConnection
    {
        //TODO: Make the create prize method actually saves  to the database.
        /// <summary>
        /// Saves a new Prize to the database.
        /// </summary>
        /// <param name="model">Input prize details to save to the database.</param>
        /// <returns>The prize information, including the unique Indetntifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.PrizeID = 1;

            return model;
        }
    }
}
