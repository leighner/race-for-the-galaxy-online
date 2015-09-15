

using System;
using race_for_the_galaxy.Core;
using race_for_the_galaxy.CardBehavior.Interfaces;
using Core.race_for_the_galaxy;

namespace race_for_the_galaxy.CardBehavior
{
    public class DevelopDiscount : ICardBehavior, IDiscount
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

        public int DiscountAmount(CardData card)
        {
            return card.TypeOfCard == CardType.Development ? Discount : 0;
        }
    }
}
