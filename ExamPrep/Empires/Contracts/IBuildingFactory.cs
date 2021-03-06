﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Contracts
{
    public interface IBuildingFactory
    {
        IBuilding CreateBuilding(string buildingType,IResourseFactory resourseFactory,
           IUnitFactory unitFactory);
    }
}
