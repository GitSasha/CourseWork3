using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class CheeseRicotta : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public CheeseRicotta(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + Ricotta cheese";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 30;
        }
    }
}
