using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Football_League.Models
{
   public class Teams
   {
        private const int EarlyestDateofFound = 1850;
       private string name;
       private string nickname;
       private DateTime dateOfFounding;
       private List<Players> players;

       public Teams(string name, string nickname, DateTime dateOfFounding)
       {
           this.Name = name;
           this.Nickname = nickname;
           this.DateOfFounding = dateOfFounding;
           this.players = new List<Players>();
       }

       public string Name
       {
           get { return this.name; }
           set
           {
               if (value.Length < 5 || string.IsNullOrWhiteSpace(value))
               {
                   throw new ArgumentException("Team name must be at least 5 characters long");
               }
               this.name = value;
           }
       }

        public string Nickname
        {
            get { return this.nickname; }
            set
            {
                if (value.Length < 5 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Team nickname must be at least 5 characters long");
                }
                this.nickname = value;
            }
        }

       public DateTime DateOfFounding
        {
           get { return this.dateOfFounding; }
           set
           {
               if (value.Year < EarlyestDateofFound)
               {
                   throw new ArgumentException($"Date of founding cannot be before {EarlyestDateofFound}");
               }
               this.dateOfFounding = value;
           }
       }

       public IEnumerable<Players> Players
       {
           get { return this.players; }
       } 


        //add players
       public void AddPlayer(Players player)
       {
           if (CheckIfPlayerExists(player))
           {
               throw new ArgumentException("Player with that name already exists for the current team");
           }

           this.players.Add(player);
       }

       private bool CheckIfPlayerExists(Players player)
       {
           return this.players.Any(p => p.FirstName == player.FirstName &&
                                        p.LastName == player.LastName);
       }


       public override string ToString()
       {
           return $"{name} ({DateOfFounding.Year})";
       }
   }
}
