using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    class GoodsProductionBonus : ICardBehavior
    {
        private IEnumerable<Bonus> mBonusPerProduced;
        private GoodType mGoodType;

        public GoodsProductionBonus(GoodType goodType, IEnumerable<Bonus> bonusPerProduced)
        {

            GoodType = goodType;
            BonusPerProduced = bonusPerProduced;
        }

        public Phase PhaseTrigger
        {
            get
            {
                return Phase.Trade;
            }
        }

        internal IEnumerable<Bonus> BonusPerProduced
        {
            get
            {
                return mBonusPerProduced;
            }

            set
            {
                mBonusPerProduced = value;
            }
        }

        internal GoodType GoodType
        {
            get
            {
                return mGoodType;
            }

            set
            {
                mGoodType = value;
            }
        }
    }
}
