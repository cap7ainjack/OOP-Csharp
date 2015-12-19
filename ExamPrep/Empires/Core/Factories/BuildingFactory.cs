using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;
using Empires.Models.Buildings;

namespace Empires.Core.Factories
{
   public class BuildingFactory : IBuildingFactory
    {
       public IBuilding CreateBuilding(string buildingType, IResourseFactory resourseFactory,
           IUnitFactory unitFactory)
       {
           switch (buildingType.ToLower())
           {
                case "barracks":
                    return new Barracks(unitFactory,resourseFactory);
                case "archery":
                    return new Archery(unitFactory,resourseFactory);
                default:
                   throw new ArgumentException("Invalid building type");
                    
           }
       }


    }
}
