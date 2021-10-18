using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Caramel : AddonDecorator
    {
        Beverage beverage;
        public Caramel(Beverage b)
        {
            beverage = b;
        }
        //Caramel costs 2$
        public override int Cost()
        {

            return beverage.Cost() + 2;
        }

        public override string Description()
        {
            return $"{beverage.Description()} Caramel";
        }
    }
}
