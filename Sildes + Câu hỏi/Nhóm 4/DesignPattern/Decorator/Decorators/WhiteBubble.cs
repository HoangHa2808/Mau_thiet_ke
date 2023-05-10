using Decorator.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class WhiteBubble : MilkTeaDecorator
    {
        public WhiteBubble(IMilkTea inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 1.5 + base.Cost();
        }
    }
}
