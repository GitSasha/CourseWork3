using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class Pineapple : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public Pineapple(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + pineapple";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 20;
        }
    }
}
