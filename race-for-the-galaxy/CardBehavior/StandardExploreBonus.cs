using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    class StandardExploreBonus : ICardBehavior
    {
        private byte mDiscard;
        private byte mDraw;

        public StandardExploreBonus(byte drawBonus, byte discardBonus)
        {
            mDraw = drawBonus;
            mDiscard = discardBonus;
        }

        public byte DiscardBonus
        {
            get
            {
                return mDiscard;
            }
        }

        public byte DrawBonus
        {
            get
            {
                return mDraw;
            }
        }

        public Phase PhaseTrigger
        {
            get
            {
                return Phase.Explore;
            }
        }
    }
}
