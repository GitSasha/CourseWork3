using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class MeatChicken : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public MeatChicken(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + chicken's meat";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 20;
        }
    }
}
