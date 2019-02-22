using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class Salami : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public Salami(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + salami";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 15;
        }
    }
}
