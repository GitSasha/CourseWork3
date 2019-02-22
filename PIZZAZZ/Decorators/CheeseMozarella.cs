using System;
using PIZZAZZ.Dishes;

namespace PIZZAZZ.Decorators
{
    class CheeseMozarella : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public CheeseMozarella(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + Mozarella cheese";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 25;
        }
    }
}
