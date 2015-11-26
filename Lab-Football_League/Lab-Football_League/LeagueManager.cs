using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Football_League.Models;

namespace Lab_Football_League
{
    class LeagueManager
    {
        public static void HandleInput(string input)
        {
            var inputArgs = input.Split();
            switch (inputArgs[0])
            {
                case "AddTeam":
                    AddTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]));
                    break;
                case "AddMatch":
                    AddMatch(int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3], int.Parse(inputArgs[4]),
                        int.Parse(inputArgs[5]));
                    break;
                case "AddPlayerToTeam":
                    AddPlayerToTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]),
                        decimal.Parse(inputArgs[4]), inputArgs[5]);
                    break;
                case "ListTeams":
                    ListTeams();
                    break;
                case "ListMatches":
                    ListMatches();
                    break;


            }
        }

        private static void AddPlayerToTeam(string firstName, string lastName, DateTime birthDate,
            decimal salary, string teamAsString)
        {
            if (League.Teams.All(p => p.Name != teamAsString))
            {
                throw new ArgumentException("This team does not compete in the current League");
            }
            Teams newPLayerTeam = League.Teams.First(team => team.Name == teamAsString);
            Players newPlayer = new Players(firstName, lastName, birthDate, salary, newPLayerTeam);

            newPLayerTeam.AddPlayer(newPlayer);

            Console.WriteLine($"Player {newPlayer.FirstName} {newPlayer.LastName} added to team to" +
                              $" {newPLayerTeam.Name}");
        }


        private static void AddTeam(string team, string nickname, DateTime dateOfFoundation)
        {
            var newTeam = new Teams(team, nickname, dateOfFoundation);
            League.AddTeams(newTeam);

            Console.WriteLine($"Team {newTeam.Name} added to League");
        }

        private static void AddMatch(int id,string homeTeam, string awayTeam, int homeGoals,
            int awayteamGoals )
        {
            if (League.Matches.Any(p => p.ID == id))
            {
                throw new ArgumentException("Тоя мач сме го играли вече, дай друг.");
            }

            if (League.Teams.All(team => team.Name != homeTeam))
            {
                throw new InvalidOperationException("Home team not found");
            }

            if (League.Teams.All(teamGuest => teamGuest.Name != awayTeam))
            {
                throw new InvalidOperationException("Away team not found");
            }

            var currentHomeTeam = League.Teams.First(team => team.Name == homeTeam);
            var currentAwayTeam = League.Teams.First(team => team.Name == awayTeam);
            var currentScore = new Scores(homeGoals, awayteamGoals);
            var currentMatch = new Matches(id, currentHomeTeam, currentAwayTeam, currentScore );
            League.AddMatches(currentMatch);

            Console.WriteLine($"Match *{currentMatch.HomeTeam.Name} VS {currentMatch.AwayTeam.Name}* added");
        }

        private static void ListTeams()
        {
            foreach (var team in League.Teams)
            {
                Console.WriteLine(team);
            }
        }

        private static void ListMatches()
        {
            foreach (var match in League.Matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
