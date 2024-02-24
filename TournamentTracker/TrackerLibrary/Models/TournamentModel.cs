using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {

        /// <summary>
        /// Represents the name of tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represets the fees for entry
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents the list of participating teams.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represesnts the list of prizes.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();


        /// <summary>
        /// Represenst the list of rounds and their Matchups
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
