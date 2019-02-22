using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class MeatBacon : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public MeatBacon(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + bacon";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 20;
        }
    }
}
