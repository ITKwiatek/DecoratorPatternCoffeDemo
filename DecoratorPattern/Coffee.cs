using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Coffee : Beverage
    {
        //Coffee costs 4$
        public override int Cost()
        {
            return 4;
        }

        public override string Description()
        {
            return "A cup of Coffe with:";
        }
    }
}
