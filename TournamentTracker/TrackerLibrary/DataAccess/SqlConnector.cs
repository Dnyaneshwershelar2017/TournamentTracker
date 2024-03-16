using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    class SqlConnector : IDataConnection
    {

        private const string db = "TournamentDb";
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnStringSettings(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName, DbType.String);
                p.Add("@LastName", model.LastName, DbType.String);
                p.Add("@EmailAddress", model.EmailAddress, DbType.String);
                p.Add("@PhoneNumber", model.PhoneNumber, DbType.String);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                //Execute SQL Command
                connection.Execute("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);

                model.PersonId = p.Get<int>("@id");

                return model;
            }
        }

        //TODO: Make the create prize method actually saves  to the database.
        /// <summary>
        /// Saves a new Prize to the database.
        /// </summary>
        /// <param name="model">Input prize details to save to the database.</param>
        /// <returns>The prize information, including the unique Indetntifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnStringSettings(db)))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber, DbType.Int32);
                p.Add("@PlaceName", model.PlaceName, DbType.String);
                p.Add("@PrizeAmount", model.PrizeAmount, DbType.Decimal);
                p.Add("@PrizePercentage", model.PrizePercentage, DbType.Decimal);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                //Execute SQL Command
                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.PrizeID = p.Get<int>("@id");

                return model;
            }

        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnStringSettings(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName, DbType.String);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                //Execute SQL Command
                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                model.TeamId = p.Get<int>("@id");


                //Insert All Team Members
                foreach (PersonModel person in model.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.TeamId, DbType.Int32);
                    p.Add("@PersonId", person.PersonId, DbType.Int32);
                    p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                    //Execute SQL Command
                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
                }

                return model;
            }
        }

        public List<PersonModel> getPerson_All()
        {
            List<PersonModel> people;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnStringSettings(db)))
            {
                //Execute SQL Command
                //  connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);
                people = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }
            return people;
        }
    }
}
