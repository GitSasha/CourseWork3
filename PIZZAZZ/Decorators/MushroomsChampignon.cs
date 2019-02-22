using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class MushroomsChampignon : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public MushroomsChampignon(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + champignons";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 15;
        }
    }
}
