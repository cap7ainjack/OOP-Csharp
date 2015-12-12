using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Exrcs_LOGGER
{
  public  class StringBasicFormat : IFormatter
    {
      public string Format(Client client)
      {
          return string.Format("\"Name\" {0} ------ \"Age\" {1}", client.Name, client.Age);
      }
    }
}
