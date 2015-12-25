using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Core.Factories
{
    using System.Reflection;
    using Contracts;
   public class BehaviorFactory : IBehaviorFactory
   {
       private const string ExceptionMessage = "Unknown behavior type";

       public IBehave Create(string behaviorName)
       {
           var type = Assembly.GetExecutingAssembly().GetTypes()
               .FirstOrDefault(t => t.Name == behaviorName);

           if (type == null)
           {
               throw new ArgumentException(ExceptionMessage);
           }

           var behavior = Activator.CreateInstance(type);

            return behavior as IBehave;
           

       }
    }
}
