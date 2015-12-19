using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Core;
using Empires.Core.Factories;
using Empires.IO;
using Empires.Models.Buildings;

namespace Empires
{
    class EmpiresApplication
    {
       public static void Main(string[] args)
        {
               var buildingFactory = new BuildingFactory();
               var unitFactory = new UnitFactory();
            var resourseFactory = new ResourceFactory();
           var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
           var data = new EmpireData();

            var engine = new Engine(buildingFactory,resourseFactory,unitFactory,
                data,reader,writer);

            engine.Run();
        }
    }
}
