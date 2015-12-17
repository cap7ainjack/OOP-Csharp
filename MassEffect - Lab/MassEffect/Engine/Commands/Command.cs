using MassEffect.Exceptions;

namespace MassEffect.Engine.Commands
{
    using System;

    using MassEffect.Interfaces;

    public abstract class Command
    {
        protected Command(IGameEngine gameEngine)
        {
            this.GameEngine = gameEngine;
        }

        public IGameEngine GameEngine { get; set; }

        public abstract void Execute(string[] commandArgs);

        public void ValidateAlive(IStarship ship)
        {
            if (ship.Health <= 0)
            {
                throw new ShipException(Messages.ShipAlreadyDestroyed);
            }
        }

        public void ValidateStarSystem(IStarship ship, IStarship otherShip)
        {
            if (ship.Location.Name != otherShip.Location.Name)
            {
                throw new LocationOutOfRangeException("Ships not from the same Star system!");
            }
        }

    }
}
