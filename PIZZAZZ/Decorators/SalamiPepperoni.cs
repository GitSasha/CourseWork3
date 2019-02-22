using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class SalamiPepperoni : BaseIngredientDecorator
    {
            private BaseDish _dish;

            public SalamiPepperoni(BaseDish dish)
            {
                _dish = dish;
                Description = _dish.GetDescription() + " + Pepperoni salami";
            }

            public override double GetCost()
            {
                return _dish.GetCost() + 30;
            }
    }
}
