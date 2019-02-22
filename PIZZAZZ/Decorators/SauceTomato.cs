using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class SauceTomato : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public SauceTomato(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + tomato sauce";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 10;
        }
    }
}
