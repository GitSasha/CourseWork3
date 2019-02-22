using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class Basil : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public Basil(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + basil";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 5;
        }
    }
}
