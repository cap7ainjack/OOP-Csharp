using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;
using Empires.Enums;

namespace Empires.Core
{
   public class EmpireData : IData
    {
       private readonly ICollection<IBuilding> buildings = new List<IBuilding>();
        //private readonly IDictionary<string,int> units = new Dictionary<string, int>();  
 
       public EmpireData()
       {
          this.Resources = new Dictionary<ResourseType, int>();
           this.Units = new Dictionary<string, int>();
           this.InItResorces();
       }

       private void InItResorces()
       {
           foreach (ResourseType resourceType in Enum.GetValues(typeof(ResourseType)))
           {
               this.Resources.Add(resourceType, 0);
           }
       }


       public IEnumerable<IBuilding> Buildings
       {
           get { return this.buildings; }
       }


       public void AddBuilding(IBuilding building)
       {
           if (building == null)
           {
               throw new ArgumentNullException(nameof(building) + "Can`t add null building");
           }

           buildings.Add(building);
       }

       public IDictionary<string, int> Units { get; } 

       public void AddUnit(IUnit unit)
       {
           if (unit == null)
           {
               throw new ArgumentNullException(nameof(unit) + "Cannot add null unit");
           }

           var unitType = unit.GetType().Name;

           if (!this.Units.ContainsKey(unitType))
           {
               this.Units.Add(unitType,0);
           }

            this.Units[unitType] += 1;
        }

       public IDictionary<ResourseType, int> Resources { get; }
    }
}
