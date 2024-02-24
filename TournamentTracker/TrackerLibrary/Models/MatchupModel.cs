using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents List of teams matchups.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the winner from this matchups.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round no.
        /// </summary>
        public int  MatchupRound { get; set; }
    }
}