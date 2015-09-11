using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior.SixCostDevelopments
{
    public class PointsForPhasePowers
    {
        private CardType mCardType;
        private Phase mPhase;
        private sbyte mPointsPerCard;

        public PointsForPhasePowers(sbyte pointsPerCard, Phase phase, CardType cardType)
        {
            mPointsPerCard = pointsPerCard;
            mPhase = phase;
            mCardType = cardType;

        }

        public CardType CardType
        {
            get
            {
                return mCardType;
            }
        }

        public Phase Phase
        {
            get
            {
                return mPhase;
            }
        }

        public sbyte PointsPerCard
        {
            get
            {
                return mPointsPerCard;
            }
        }
    }
}
