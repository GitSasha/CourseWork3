﻿using System;
using System.Collections.Generic;
using PIZZAZZ.Dishes;
namespace PIZZAZZ.Decorators
{
    class Sausages : BaseIngredientDecorator
    {
        private BaseDish _dish;

        public Sausages(BaseDish dish)
        {
            _dish = dish;
            Description = _dish.GetDescription() + " + sausages";
        }

        public override double GetCost()
        {
            return _dish.GetCost() + 15;
        }
    }
}
