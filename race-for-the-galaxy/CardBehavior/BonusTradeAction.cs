using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{

    class BonusTradeAction : ICardBehavior
    {
        private bool mApplyTradeBonuses;

        public BonusTradeAction(bool applyTradeBonuses = false)
        {
            mApplyTradeBonuses = applyTradeBonuses;
        }

        public bool ApplyTradeBonuses
        {
            get
            {
                return mApplyTradeBonuses;
            }
        }

        public Phase PhaseTrigger
        {
            get
            {
                return Phase.Trade;
            }
        }
    }
}
