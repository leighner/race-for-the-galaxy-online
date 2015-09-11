using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    class MilitaryBonus : ICardBehavior
    {
        private int mMilitaryBonusAmount;
        private Phase mPhase;

        internal MilitaryBonus(int militaryBonusAmount, Phase phase)
        {
            mMilitaryBonusAmount = militaryBonusAmount;
            mPhase = phase;
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
