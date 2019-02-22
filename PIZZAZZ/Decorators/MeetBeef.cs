using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class MeetBeef : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public MeetBeef(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + beef";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 25;
        }
    }
}
