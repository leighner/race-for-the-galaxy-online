using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    public class MilitaryPower : ICardBehavior
    {
        private bool mAgainstRebelOnly;
        private int mMilitaryBonusAmount;
        private Phase mPhase;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="militaryBonusAmount">can be positive or negative </param>
        /// <param name="phase"></param>
        /// <param name="againstRebelOnly"></param>
        internal MilitaryPower(sbyte militaryBonusAmount, Phase phase, bool againstRebelOnly = false)
        {
            mMilitaryBonusAmount = militaryBonusAmount;
            mPhase = phase;
            mAgainstRebelOnly = againstRebelOnly;
        }

        public bool AgainstRebelOnly
        {
            get
            {
                return mAgainstRebelOnly;
            }

            set
            {
                mAgainstRebelOnly = value;
            }
        }

        public Phase PhaseTrigger
        {
            get
            {
                return mPhase;
            }
        }
    }
}
