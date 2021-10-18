using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Chocolate : AddonDecorator
    {
        Beverage beverage;
        public Chocolate(Beverage b)
        {
            beverage = b;
        }
        //Chocolate costs 5$
        public override int Cost()
        {
            return beverage.Cost() + 5;
        }

        public override string Description()
        {
            return $"{beverage.Description()} Chocolate";
        }
    }
}
