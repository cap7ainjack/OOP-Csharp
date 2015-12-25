using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Contracts
{
   public interface IData
   {
       IEnumerable<IBlob> Blobs { get; } 

       void AddBlob(IBlob blob);
   }
}
