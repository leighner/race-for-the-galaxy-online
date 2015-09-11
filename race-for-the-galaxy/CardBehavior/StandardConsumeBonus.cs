using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    public class StandardConsumeBonus : ICardBehavior
    {
        private IEnumerable<Bonus> mBonuses;
        private IEnumerable<GoodType> mGoodTypes;
        private byte mNumberOfAllowedConsumes;
        private bool mTwoTimesBonusAllowed;

        /// <summary>
        /// consume one of each of the <paramref name="goodTypes"/> returning <paramref name="bonuses"/> for up to <paramref name="numberOfAllowedConsumes"/>
        /// </summary>
        /// <param name="goodTypes">number of goods required for the consume</param>
        /// <param name="bonuses">return on the consume</param>
        /// <param name="numberOfAllowedConsumes">number of times trade is allowed</param>
        /// <param name="twoTimesBonusAllowed">if the 2x consume bonus is allowed</param>
        public StandardConsumeBonus(IEnumerable<GoodType> goodTypes, IEnumerable<Bonus> bonuses, byte numberOfAllowedConsumes, bool twoTimesBonusAllowed)
        {
            mGoodTypes = goodTypes;
            mBonuses = bonuses;
            mNumberOfAllowedConsumes = numberOfAllowedConsumes;
            mTwoTimesBonusAllowed = twoTimesBonusAllowed;
        }

        public bool TwoTimesBonusAllowed
        {
            get
            {
                return mTwoTimesBonusAllowed;
            }
        }

        public byte NumberOfAllowedConsumes
        {
            get
            {
                return mNumberOfAllowedConsumes;
            }

        }

        public Phase PhaseTrigger
        {
            get
            {
                return Phase.Consume;
            }
        }

        internal IEnumerable<GoodType> GoodTypes
        {
            get
            {
                return mGoodTypes;
            }
        }
    }
}
