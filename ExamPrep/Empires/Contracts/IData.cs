using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Enums;

namespace Empires.Contracts
{
   public interface IData
    {
        IEnumerable<IBuilding>  Buildings { get; }

       void AddBuilding(IBuilding building);

         IDictionary<string, int> Units { get; }

        void AddUnit(IUnit unit);

        IDictionary<ResourseType, int> Resources { get;  } 
    }
}
