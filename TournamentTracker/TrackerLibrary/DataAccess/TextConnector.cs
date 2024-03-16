using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    class TextConnector : IDataConnection
    {
        private const string PrizeFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PersonModel CreatePerson(PersonModel model)
        {
            //Load Text File
            //Comvert text to List<PersonModel>
            List<PersonModel> people = TextConnectorProcessor.ConvertToPeopleModels(PeopleFile.FullFilePath().LoadFile());
            int newId = 1;

            //Find ID
            if (people.Count > 0)
                newId = people.OrderByDescending(x => x.PersonId).First().PersonId + 1;

            model.PersonId = newId;

            //Add New record with new ID (Max +1)
            people.Add(model);

            //Convert  people to List<string>
            //Save list<String> to TextFile
            TextConnectorProcessor.saveToPeopleFile(people, PeopleFile);

            return model;
        }


        //TODO: Make the create prize method actually saves  to the TextFIle.
        /// <summary>
        /// Saves a new Prize to the TextFIle.
        /// </summary>
        /// <param name="model">Input prize details to save to the TextFIle.</param>
        /// <returns>The prize information, including the unique Indetntifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load Text File
            //Comvert text to List<PrizeModel>
            List<PrizeModel> prizes = TextConnectorProcessor.ConvertToPrizeModels(PrizeFile.FullFilePath().LoadFile());
            int newId = 1;

            //Find ID
            if(prizes.Count>0)
                 newId = prizes.OrderByDescending(x => x.PrizeID).First().PrizeID +1;

            model.PrizeID = newId;

            //Add New record with new ID (Max +1)
            prizes.Add(model);

            //Convert  prizes to List<string>
            //Save list<String> to TextFile
            TextConnectorProcessor.saveToPrizeFile(prizes, PrizeFile);

            return model;
        }

        public List<PersonModel> getPerson_All()
        {
           return TextConnectorProcessor.ConvertToPeopleModels(PeopleFile.FullFilePath().LoadFile());
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            //Load Text File
            //Comvert text to List<TeamModel>
            List<TeamModel> teams = TextConnectorProcessor.ConvertToTeamModels(TeamFile.FullFilePath().LoadFile(),PeopleFile);
            int newId = 1;

            //Find ID
            if (teams.Count > 0)
                newId = teams.OrderByDescending(x => x.TeamId).First().TeamId + 1;

            model.TeamId = newId;

            //Add New record with new ID (Max +1)
            teams.Add(model);

            //Convert  Teams to List<string>
            //Save list<String> to TextFile
            TextConnectorProcessor.saveToTeamFile(teams, TeamFile);

            return model;
        }
    }
}
