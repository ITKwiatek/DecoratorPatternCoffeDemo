﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class AddonDecorator : Beverage
    {
        public abstract override int Cost();
    }
}
