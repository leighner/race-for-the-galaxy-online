using System;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    class WindfallProductionWorld : ICardBehavior
    {
        private GoodType mGoodProduced;

        public WindfallProductionWorld(GoodType goodsProduced)
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

        Phase ICardBehavior.PhaseTrigger
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
