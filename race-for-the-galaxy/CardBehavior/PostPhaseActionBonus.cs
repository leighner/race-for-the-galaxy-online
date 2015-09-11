using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{

    /// <summary>
    /// If player does an develop or settle action, they draw x cards
    /// </summary>
    public class PostPhaseActionBonus : ICardBehavior
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
    }
}
