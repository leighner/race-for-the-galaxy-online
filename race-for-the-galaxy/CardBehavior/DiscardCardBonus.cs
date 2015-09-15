using System;
using System.Collections.Generic;
using race_for_the_galaxy.Core;
using race_for_the_galaxy.CardBehavior.Interfaces;
using Core.race_for_the_galaxy;

namespace race_for_the_galaxy.CardBehavior
{
    public class DiscardCardBonus : ICardBehavior, IDiscount
    {
        private IEnumerable<Bonus> mBonuses;
        private byte mMaxDiscard;
        private bool mTwoTimesBonusApplies;

        public DiscardCardBonus(byte maxDiscards, IEnumerable<Bonus> bonuses, bool twoTimesBonusApplies = false)
        {
            mMaxDiscard = maxDiscards;
            mBonuses = bonuses;
            mTwoTimesBonusApplies = twoTimesBonusApplies;
        }

        public byte MaxDiscard
        {
            get
            {
                return mMaxDiscard;
            }
        }

        public bool TwoTimesBonusApplies
        {
            get
            {
                return mTwoTimesBonusApplies;
            }
        }

        internal IEnumerable<Bonus> Bonuses
        {
            get
            {
                return mBonuses;
            }
        }

        Phase ICardBehavior.PhaseTrigger
        {
            get
            {
                return Phase.Consume;
            }
        }

        public int DiscountAmount(CardData card)
        {
            throw new NotImplementedException();
        }
    }
}
