using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    public class DiscardAllGoodsGainVPMinusOne : ICardBehavior
    {

        public DiscardAllGoodsGainVPMinusOne()
        {

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
