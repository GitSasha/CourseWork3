using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;


namespace PIZZAZZ.Decorators
{
    class SauceCream : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public SauceCream(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + cream sauce";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 10;
        }
    }
}
