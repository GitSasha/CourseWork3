using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class Oregano : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public Oregano(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + oregano";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 5;
        }
    }
}
