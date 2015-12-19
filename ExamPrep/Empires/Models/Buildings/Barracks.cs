using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;
using Empires.Enums;

namespace Empires.Models.Buildings
{
    using static Enums.ResourseType;
    public class Barracks :Building
    {
        //•	Barracks - produces 10 steel (every 3 turns) and a swordsman (every 4 turns)

        private const string BarracksUnitType = "Swordsman";
        private const int BarracksUnitCycle = 4;
       private const int BarracksResourceQuantity = 10;

        private const ResourseType BarrackResourseType = Steel;
        private const int BarracksResourseCycle = 3;

       public Barracks(IUnitFactory unitFactory, IResourseFactory resourseFactory)
           : base(BarracksUnitType,
                 BarracksUnitCycle,
               BarrackResourseType,
                BarracksResourseCycle,
               BarracksResourceQuantity,
               unitFactory,
               resourseFactory)
       {


       }
    }
}
