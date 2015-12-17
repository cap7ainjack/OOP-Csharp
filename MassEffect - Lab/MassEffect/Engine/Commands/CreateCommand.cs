using System;
using System.Data;
using System.Globalization;
using System.Linq;
using MassEffect.GameObjects.Enhancements;
using MassEffect.GameObjects.Ships;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class CreateCommand : Command
    {
        public CreateCommand(IGameEngine gameEngine) 
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string shipType = commandArgs[1];
            string shipName = commandArgs[2];
            string starSystem = commandArgs[3];

            bool shipExists = this.GameEngine.Starships.Any(c => c.Name == shipName);

            if (shipExists)
            {
                throw new DuplicateNameException("Ship with current name already exists!");
            }

            var location = this.GameEngine.Galaxy.GetStarSystemByName(starSystem);
            StarshipType type = (StarshipType) Enum.Parse(typeof (StarshipType), shipType);

            var newShip = this.GameEngine.ShipFactory.CreateShip(type, shipName, location);
            


            for (int i = 4; i < commandArgs.Length; i++)
            {
                EnhancementType enhancmentType = (EnhancementType)Enum
                    .Parse(typeof (EnhancementType), commandArgs[i]);
                var newEnhancment = this.GameEngine.EnhancementFactory.Create(enhancmentType);

                newShip.AddEnhancement(newEnhancment);
            }

            this.GameEngine.Starships.Add(newShip);
            Console.WriteLine(Messages.CreatedShip,shipType,shipName);
        }
    }
}
