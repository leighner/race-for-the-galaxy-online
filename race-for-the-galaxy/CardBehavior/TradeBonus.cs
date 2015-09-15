using race_for_the_galaxy.Core;
using race_for_the_galaxy.CardBehavior.Interfaces;
using Core.race_for_the_galaxy;
using System;

namespace race_for_the_galaxy.CardBehavior
{
    public class TradeBonus : ICardBehavior, ITradeBonus
    {
        private byte mBonus;
        private GoodType mGood;

        public TradeBonus(byte bonus, GoodType good = GoodType.Any)
        {
            mBonus = bonus;
            mGood = good;
        }

        public byte Bonus
        {
            get
            {
                return mBonus;
            }
        }

        public GoodType Good
        {
            get
            {
                return mGood;
            }

            set
            {
                mGood = value;
            }
        }

        public Phase PhaseTrigger
        {
            get
            {
                return Phase.Trade;
            }
        }

        public int TradeBonusAmount(CardData card)
        {
            throw new NotImplementedException();
        }
    }
}
