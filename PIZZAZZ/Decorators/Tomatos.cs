using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class Tomatos : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public Tomatos(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + tomatos";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 15;
        }
    }
}
