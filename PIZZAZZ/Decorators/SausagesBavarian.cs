using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class SausagesBavarian : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public SausagesBavarian(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + Bavarian sausages";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 20;
        }
    }
}
