using System;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this perticular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the previous matchup 
        /// that this team came from as a winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore"></param>
        //public MatchupEntryModel(double initialScore)
        //{
        //}
    }
}