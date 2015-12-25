using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Core.Factories
{
    using Contracts;
    using Models;

    public class BlobFactory : IBlockFactory
    {
       public IBlob Create(string name, int health, int damage, IBehave behavior, IAttack attack)
       {
           return new Blob(name,health,damage,behavior,attack);
       }
    }
}
