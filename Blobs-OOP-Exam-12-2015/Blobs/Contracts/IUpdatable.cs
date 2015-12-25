using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Contracts
{
   public interface IUpdatable
    {
        //aplying health/attack effects every turns

       void Update();
    }
}
