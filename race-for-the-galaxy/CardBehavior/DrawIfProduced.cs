using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    class DrawIfProduced : ICardBehavior
    {
        private GoodType mGood;

        public DrawIfProduced(byte draw, GoodType good = GoodType.Any)
        {
            mGood = good;
        }

        public Phase PhaseTrigger
        {
            get
            {
                return Phase.Settle;
            }
        }

        public GoodType Good
        {
            get
            {
                return mGood;
            }
        }
    }
}
