using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class MeatSmokedChicken : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public MeatSmokedChicken(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + smoked chicken";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 25;
        }
    }
}
