using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        // Initializing using new Approach after c# 6

        /// <summary>
        /// Represents the list of players in a team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

     /// <summary>
     /// Represents the name of a team.
     /// </summary>
        public string TeamName { get; set; }

       /*
        * Before c# 6.0
        public TeamModel()
        {
            TeamMembers = new List<Person>(); 
        }
       */
    }
}
