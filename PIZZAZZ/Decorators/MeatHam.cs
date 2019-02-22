using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class MeatHam : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public MeatHam(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + ham";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 25;
        }
    }
}
