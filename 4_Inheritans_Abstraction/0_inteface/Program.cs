using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_inteface.Intefaces;

namespace _0_inteface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shades

            IMovable turtel = new Turtle();
            MoveObjects(turtel, 2,3);
            IMovable shade = new shade();
        }

        static void MoveObjects(IMovable movable, double deltaX, double deltaY)
        {
            movable.Move(deltaX,deltaY);
        }
    }
}
