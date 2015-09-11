
namespace race_for_the_galaxy.CardBehavior.SixCostDevelopments
{
    public class PointsPerSpecificCard
    {
        private readonly sbyte mNumberOfPointsPerSpecificCard;

        public PointsPerSpecificCard(sbyte numberOfPointsPerSpecificCard, string cardName)
        {
            mNumberOfPointsPerSpecificCard = numberOfPointsPerSpecificCard;
        }

        public sbyte MNumberOfPointsPerSpecificCard
        {
            get
            {
                return mNumberOfPointsPerSpecificCard;
            }
        }
    }
}
