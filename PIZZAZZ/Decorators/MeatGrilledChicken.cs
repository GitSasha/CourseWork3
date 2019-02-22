using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class MeatGrilledChicken : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public MeatGrilledChicken(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + grilled chicken";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 25;
        }
    }
}
