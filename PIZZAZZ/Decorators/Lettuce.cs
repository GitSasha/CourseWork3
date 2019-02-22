using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class Lettuce : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public Lettuce(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + lettuce";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 10;
        }
    }
}
