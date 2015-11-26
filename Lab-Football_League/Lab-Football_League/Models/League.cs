using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Football_League.Models
{
    public static class League
    {
        private static List<Teams> teams = new List<Teams>();
        private static List<Matches> matches = new List<Matches>();

        public static IEnumerable<Teams> Teams
        {
            get { return teams; }
        }

        public static IEnumerable<Matches> Matches
        {
            get { return matches; }
        }

        public static void AddTeams(Teams team)
        {
            if (CheckIfTeamExists(team))
            {
                throw new ArgumentException("League already have a team with this name");
            }
            teams.Add(team);
        }

        public static void AddMatches(Matches match)
        {
            if (CheckIfMatchExists(match))
            {
                throw new ArgumentException("Match with the same match ID already exists");
            }

            matches.Add(match);
        }

        private static bool CheckIfTeamExists(Teams team)
        {
            return teams.Any(p => p.Name == team.Name);
        }

        private static bool CheckIfMatchExists(Matches match)
        {
            return matches.Any(p => p.ID == match.ID);
        }
    }
}
