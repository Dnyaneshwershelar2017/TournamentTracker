using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    class TextConnector : IDataConnection
    {
        //TODO: Make the create prize method actually saves  to the TextFIle.
        /// <summary>
        /// Saves a new Prize to the TextFIle.
        /// </summary>
        /// <param name="model">Input prize details to save to the TextFIle.</param>
        /// <returns>The prize information, including the unique Indetntifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.PrizeID = 1;

            return model;
        }
    }
}
