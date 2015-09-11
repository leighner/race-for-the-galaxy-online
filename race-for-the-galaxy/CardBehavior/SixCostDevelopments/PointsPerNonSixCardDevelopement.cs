
namespace race_for_the_galaxy.CardBehavior.SixCostDevelopments
{
    class PointsPerNonSixCardDevelopement
    {
        private byte mPointsPerCard;

        public PointsPerNonSixCardDevelopement(byte pointsPerCard)
        {
            mPointsPerCard = pointsPerCard;
        }

        public byte MPointsPerCard
        {
            get
            {
                return mPointsPerCard;
            }
        }
    }

}
