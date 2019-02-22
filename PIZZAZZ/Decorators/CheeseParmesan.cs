using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;


namespace PIZZAZZ.Decorators
{
    class CheeseParmesan : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public CheeseParmesan(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + Parmesan cheese";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 30;
        }
    }
}
