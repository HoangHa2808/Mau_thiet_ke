﻿using Decorator.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class BlackSugar : MilkTeaDecorator
    {
        public BlackSugar(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 2d + base.Cost();
        }
    }
}
