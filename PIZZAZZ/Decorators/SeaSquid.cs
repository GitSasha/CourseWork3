using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class SeaSquid : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public SeaSquid(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + squid";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 30;
        }
    }
}
