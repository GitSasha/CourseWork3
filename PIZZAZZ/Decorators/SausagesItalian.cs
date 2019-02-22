using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class SausagesItalian : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public SausagesItalian(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + Italian sausages";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 20;
        }
    }
}
