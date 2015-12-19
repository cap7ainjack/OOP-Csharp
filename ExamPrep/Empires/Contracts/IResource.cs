using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Enums;

namespace Empires.Contracts
{
   public interface IResource
    {
        ResourseType ResourseType { get; }
       int Quantity { get; }

    }
}
