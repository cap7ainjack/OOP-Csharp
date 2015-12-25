using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs
{
    using Contracts;
    using Core;
    using Core.Factories;
    using IO;

    class BlobsApplication
    {
        static void Main(string[] args)
        {
            var  engine = new Engine(
                new BlobFactory(), 
                new AttackFactory(), 
                new BehaviorFactory(), 
                new ConsoleReader(), 
                new ConsoleWriter(), 
                new Data(new List<IBlob>())
                );

            engine.Run();
        }
    }
}
