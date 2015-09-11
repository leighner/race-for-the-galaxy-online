using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    class SettleDiscount : ICardBehavior
    {

        internal SettleDiscount(int discountAmount, IEnumerable<GoodType> applicableGoodTypes)
        {

        }

        public Phase PhaseTrigger
        {
            get
            {
                return Phase.Settle;
            }
        }
    }
}
