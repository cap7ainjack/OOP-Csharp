using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Contracts;
using Empires.Enums;

namespace Empires.Models
{
   public class Resource : IResource
    {
        
       public Resource(ResourseType resourseType, int quantity)
       {
          this.ResourseType = resourseType;
           this.Quantity = quantity;
       }

       public ResourseType ResourseType { get; }
       public int Quantity { get; }
    }
}
