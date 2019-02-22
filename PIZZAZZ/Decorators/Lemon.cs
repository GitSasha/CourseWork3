using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class Lemon : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public Lemon(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + lemon";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 15;
        }
    }
}
