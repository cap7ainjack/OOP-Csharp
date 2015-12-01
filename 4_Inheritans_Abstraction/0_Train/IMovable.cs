using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Train
{
   public interface IMovable
    {
        // interface example

       void Move();
    }

    public class Person : IMovable
    {
        public void Move()
        {
            Console.WriteLine("walking with 2 legs..");
        }
    }

    public class Cow : IMovable
    {
        public void Move()
        {
            Console.WriteLine("walking with 4 legs...");
        }
    }

    public class Airplane : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Fly....");
        }
    }
}
