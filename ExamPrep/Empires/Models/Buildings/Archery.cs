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

   public class Archery : Building
   {
       private const string ArcheryUnitType = "Archer";
       private const int ArcheryUnitCycle = 3;

       private const ResourseType ArcheryResourseType = Gold;
       private const int ArcheryResourseCycle = 2;
       private const int ArcheryResourceQuantity = 5;
     
       public Archery( IUnitFactory unitFactory, IResourseFactory resourseFactory) 
            : base(ArcheryUnitType,
                  ArcheryUnitCycle,
                  ArcheryResourseType,
                  ArcheryResourseCycle,
                  ArcheryResourceQuantity,
                  unitFactory,
                  resourseFactory)
       {


       }
    }
}
