using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class SojaMilk : AddonDecorator
    {
        Beverage beverage;
        public SojaMilk(Beverage b)
        {
            beverage = b;
        }
        //Soja costs 1$
        public override int Cost()
        {
            return beverage.Cost() + 1;
        }

        public override string Description()
        {
            return $"{beverage.Description()} Soya";
        }
    }
}
