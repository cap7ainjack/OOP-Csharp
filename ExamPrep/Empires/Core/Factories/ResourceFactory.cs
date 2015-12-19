using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;
using Empires.Enums;
using Empires.Models;

namespace Empires.Core.Factories
{
   public class ResourceFactory : IResourseFactory
    {
       public IResource ProduceResource(ResourseType resourseType, int quantity)
       {
            var resource = new Resource(resourseType, quantity);
           return resource;

       }
    }
}
