using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {

        public static string FullFilePath(this string fileName)
        {
            return GlobalConfig.configuration.GetSection("MySettings")["FilePath"] + $"\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PersonModel> ConvertToPeopleModels(List<string> lines)
        {
            List<PersonModel> result = new List<PersonModel>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(",");
                PersonModel m = new PersonModel(
                   PersonId:int.Parse(cols[0]),
                   FirstName: cols[1],
                   LastName: cols[2],
                   EmailAddress: cols[3],
                   PhoneNumber: cols[4]);
                result.Add(m);

            }
            return result;
        }

        public static List<PrizeModel> ConvertToPrizeModels(List<string> lines)
        {
            List<PrizeModel> result = new List<PrizeModel>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(",");
                PrizeModel m = new PrizeModel(
                    prizeId: cols[0],
                    placeNumber: cols[1],
                    placeName: cols[2],
                    prizeAmount: cols[3],
                    prizePercentage: cols[4]);

                result.Add(m);

            }
            return result;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string fileName)
        {
            List<TeamModel> result = new List<TeamModel>();

            List<PersonModel> people = TextConnectorProcessor.ConvertToPeopleModels(fileName.FullFilePath().LoadFile());

            foreach (var line in lines)
            {
                string[] cols = line.Split(",");
                List<int> personIds = cols[2].Split("||").ToList().Select(x=>int.Parse(x)).ToList();

                List<PersonModel> teamMembers = people.FindAll(x => personIds.Contains(x.PersonId)).ToList();        

                TeamModel m = new TeamModel(
                    teamId:int.Parse(cols[0]),
                    teamName: cols[1],
                    teamMembers: teamMembers
                    );

                result.Add(m);

            }
            return result;
        }

        public static void saveToPeopleFile(List<PersonModel> people, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in people)
                lines.Add($"{p.PersonId},{p.FirstName},{p.LastName},{p.EmailAddress},{p.PhoneNumber}");

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void saveToPrizeFile(List<PrizeModel> prizes, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in prizes)
                lines.Add($"{p.PrizeID},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void saveToTeamFile(List<TeamModel> teams, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in teams)
                lines.Add($"{t.TeamId},{t.TeamName}, { string.Join("||", t.TeamMembers.Select(x=> x.PersonId))} ");

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
