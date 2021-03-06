﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using race_for_the_galaxy.Core;
using race_for_the_galaxy.CardBehavior.Interfaces;
using Core.race_for_the_galaxy;

namespace race_for_the_galaxy.CardBehavior
{
    public class GoodsProductionBonus : ICardBehavior, IPostPhaseBonus
    {
        private IEnumerable<Bonus> mBonusPerProduced;
        private GoodType mGoodType;
        private bool mIncludeWindfall;

        public GoodsProductionBonus(GoodType goodType, IEnumerable<Bonus> bonusPerProduced, bool includeWindfall = false)
        {

            GoodType = goodType;
            BonusPerProduced = bonusPerProduced;
            mIncludeWindfall = includeWindfall;
        }

        public bool IncludeWindfall
        {
            get
            {
                return mIncludeWindfall;
            }
        }

        public Phase PhaseTrigger
        {
            get
            {
                return Phase.Trade;
            }
        }

        public IEnumerable<Bonus> BonusPerProduced
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

        public int PostPhaseDrawBonus(IEnumerable<CardData> cardsBought, IEnumerable<CardData> cardsConsumed)
        {
            throw new NotImplementedException();
        }
    }
}
