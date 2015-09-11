

using System;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    class DevelopDiscount : ICardBehavior
    {
        private byte mDiscount;

        public DevelopDiscount(byte discount = 1)
        {
            mDiscount = discount;
        }

        public byte Discount
        {
            get
            {
                return mDiscount;
            }
        }

        public Phase PhaseTrigger
        {
            get
            {
                return Phase.Develop;
            }
        }
    }
}
