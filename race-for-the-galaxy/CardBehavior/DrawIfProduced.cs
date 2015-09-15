using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using race_for_the_galaxy.Core;
using race_for_the_galaxy.CardBehavior.Interfaces;
using Core.race_for_the_galaxy;

namespace race_for_the_galaxy.CardBehavior
{
    public class DrawIfProduced : ICardBehavior, IPostPhaseBonus
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

        public int PostPhaseDrawBonus(IEnumerable<CardData> cardsBought, IEnumerable<CardData> cardsConsumed)
        {
            throw new NotImplementedException();
        }
    }
}
