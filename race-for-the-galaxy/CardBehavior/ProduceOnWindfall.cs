using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    class ProduceOnWindfall : ICardBehavior
    {
        private GoodType mGoodType;

        public ProduceOnWindfall(GoodType goodType = GoodType.Any)
        {
            mGoodType = goodType;
        }

        public Phase PhaseTrigger
        {
            get
            {
                return Phase.Produce;
            }
        }
    }
}
