using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    class PrePhasePickup : ICardBehavior
    {
        private sbyte mDrawNumber;
        private Phase mPhase;

        internal PrePhasePickup(Phase phase, sbyte drawNumber = 1)
        {
            mPhase = phase;
            mDrawNumber = drawNumber;
        }

        public sbyte DrawNumber
        {
            get
            {
                return mDrawNumber;
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
