using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZAZZ.Dishes
{
    class Pizza : BaseDish
    {
        public Pizza()
        {
            Description = "soft dough";
        }

        public override double GetCost()
        {
            return 15;
        }
    }
}
