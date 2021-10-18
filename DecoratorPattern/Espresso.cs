using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        //Espresso costs 3$
        public override int Cost()
        {
            return 3;
        }

        public override string Description()
        {
            return "A cup of Espresso with:";
        }
    }
}
