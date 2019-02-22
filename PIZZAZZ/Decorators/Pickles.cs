using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class Pickles : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public Pickles(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + pickles";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 15;
        }
    }
}
