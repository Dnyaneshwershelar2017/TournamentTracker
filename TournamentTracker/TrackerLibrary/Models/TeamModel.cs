using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// 
        /// </summary>
        public int TeamId { get; set; }

        // Initializing using new Approach after c# 6

        /// <summary>
        /// Represents the list of players in a team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

     /// <summary>
     /// Represents the name of a team.
     /// </summary>
        public string TeamName { get; set; }

        public TeamModel(int teamId, string teamName, List<PersonModel> teamMembers)
        {
            this.TeamId = teamId;
            this.TeamName = teamName;
            this.TeamMembers = teamMembers;
        }
       /*
        * Before c# 6.0
        public TeamModel()
        {
            TeamMembers = new List<Person>(); 
        }
       */
    }
}
