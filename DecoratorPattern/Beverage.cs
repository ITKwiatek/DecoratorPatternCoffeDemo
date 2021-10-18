using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public abstract string Description();
        public abstract int Cost();
    }
}
