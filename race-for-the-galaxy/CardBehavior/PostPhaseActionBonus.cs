using System;
using System.Collections.Generic;
using Core.race_for_the_galaxy;
using race_for_the_galaxy.CardBehavior.Interfaces;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{

    /// <summary>
    /// If player does an develop or settle action, they draw x cards
    /// </summary>
    public class PostPhaseActionBonus : ICardBehavior, IPostPhaseBonus
    {
        private Phase mPhase;

        public PostPhaseActionBonus(Phase applicablePhase)
        {
            mPhase = applicablePhase;
        }

        public Phase PhaseTrigger
        {
            get
            {
                return mPhase;
            }
        }

        public int PostPhaseDrawBonus(IEnumerable<CardData> cardsBought, IEnumerable<CardData> cardsConsumed)
        {
            throw new NotImplementedException();
        }
    }
}
