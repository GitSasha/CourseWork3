using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class Olives : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public Olives(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + Olives";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 5;
        }
    }
}
