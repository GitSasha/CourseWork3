using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class PepperBulgarian : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public PepperBulgarian(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + bulgarian pepper";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 15;
        }
    }
}
