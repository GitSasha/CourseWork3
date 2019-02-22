using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class SeaMussels : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public SeaMussels(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + mussels";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 30;
        }
    }
}
