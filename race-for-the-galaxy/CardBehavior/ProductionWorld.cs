using race_for_the_galaxy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace race_for_the_galaxy.CardBehavior
{
    public class ProductionWorld: ICardBehavior
    {
        private GoodType mGoodProduced;

        public ProductionWorld(GoodType goodsProduced)
        {
            mGoodProduced = goodsProduced;
        }

        public GoodType GoodProduced
        {
            get
            {
                return mGoodProduced;
            }
        }

        public Phase PhaseTrigger
        {
            get
            {
                return Phase.Produce;
            }
        }
    }
}
