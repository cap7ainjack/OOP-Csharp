using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_EXR_Inheritans_Abastraction
{
    class GoldenBookEdition : book
    {
        public GoldenBookEdition(string title, string author, decimal price)
            : base(title, author, price)
        {
        }

        public override decimal Price
        {
            get
            {
                return base.Price * 1.3m;
            } 
            
        }
    }
}
