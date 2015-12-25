using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Contracts
{
   public interface IBlockFactory
   {
       IBlob Create(string name, int health, int damage, IBehave behavior, IAttack attack);
   }
}
