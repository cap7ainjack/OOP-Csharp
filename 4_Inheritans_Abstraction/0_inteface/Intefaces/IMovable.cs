using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_inteface.Intefaces
{
   public interface IMovable
    {
        double x { get; set; }
        double y { get; set; }

       void Move(double detltaX, double deltaY);
        
           
       
    }
}
