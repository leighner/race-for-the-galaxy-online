using System.Collections.Generic;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    public class SettleDiscount : ICardBehavior
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
