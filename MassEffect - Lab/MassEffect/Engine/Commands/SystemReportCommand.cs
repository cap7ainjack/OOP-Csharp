using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.Interfaces;

namespace MassEffect.Engine.Commands
{
   public class SystemReportCommand : Command
    {
       public SystemReportCommand(IGameEngine gameEngine) : base(gameEngine)
       {
       }

       public override void Execute(string[] commandArgs)
       {
           string systemName = commandArgs[1];

           IEnumerable<IStarship> intactShips = null;
           intactShips = this.GameEngine.Starships
               .Where(s => s.Location.Name == systemName)
               .Where(s => s.Health > 0)
               .OrderByDescending(s => s.Name)
               .ThenBy(s => s.Shields)
               .ToList();


           IEnumerable<IStarship> destroyedShips =
               this.GameEngine.Starships
                   .Where(s => s.Location.Name == systemName)
                   .Where(s => s.Health <= 0)
                   .OrderByDescending(s => s.Name)
                   .ThenBy(s => s.Shields)
                   .ToList();

            StringBuilder builder = new StringBuilder();

           builder.AppendLine("Intact ships:");
            builder.AppendLine(intactShips.Any() ? 
                string.Join("\n", intactShips) :"N/A");


           builder.AppendLine("Destroyed ships:");
           builder.AppendLine(intactShips.Any()
               ? string.Join("\n", intactShips)
               : "N/A");

           Console.WriteLine(builder.ToString().TrimEnd('\n'));
       }
    }
}
