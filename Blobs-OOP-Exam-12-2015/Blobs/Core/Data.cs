using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Core
{
    using Contracts;
   public class Data : IData
   {
       private readonly ICollection<IBlob> blobs;

       public Data(ICollection<IBlob> blobs)
       {
           this.blobs = blobs;
       }

       public IEnumerable<IBlob> Blobs
       {
           get { return this.blobs; }
       }


       public void AddBlob(IBlob blob)
       {
           this.blobs.Add(blob);
       }
    }
}
