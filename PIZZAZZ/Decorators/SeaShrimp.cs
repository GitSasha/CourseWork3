using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class SeaShrimp : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public SeaShrimp(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + shrimp";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 25;
        }
    }
}
