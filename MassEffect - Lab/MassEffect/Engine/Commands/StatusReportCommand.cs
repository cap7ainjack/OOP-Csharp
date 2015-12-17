using System;
using System.Linq;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class StatusReportCommand : Command
    {
        public StatusReportCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string shipName = commandArgs[1];
            IStarship ship = null;

            ship = GameEngine.Starships.FirstOrDefault(c => c.Name == shipName);

            if (ship == null)
            {
                Console.WriteLine(Messages.NoSuchShipInStarSystem);
             }

            Console.WriteLine(ship.ToString());
        }
    }
}
