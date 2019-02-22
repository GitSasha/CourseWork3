using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class Leek : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public Leek(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + leek";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 5;
        }
    }
}
