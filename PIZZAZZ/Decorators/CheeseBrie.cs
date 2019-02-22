using System;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class CheeseBrie : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public CheeseBrie(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + Brie cheese";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 30;
        }
    }
}
