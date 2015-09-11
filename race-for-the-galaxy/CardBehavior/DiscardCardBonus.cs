using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    class DiscardCardBonus : ICardBehavior
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
    }
}
