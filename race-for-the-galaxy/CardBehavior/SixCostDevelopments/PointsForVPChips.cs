
namespace race_for_the_galaxy.CardBehavior.SixCostDevelopments
{
    public class PointsForVPChips
    {
        private byte mPointsPerSet;
        private byte mVpsRequiredPerPoint;

        public PointsForVPChips(byte pointsPerSet, byte vpsRequiredPerPoint)
        {
            mPointsPerSet = pointsPerSet;
            mVpsRequiredPerPoint = vpsRequiredPerPoint;
        }

        public byte PointsPerSet
        {
            get
            {
                return mPointsPerSet;
            }
        }

        public byte VpsRequiredPerPoint
        {
            get
            {
                return mVpsRequiredPerPoint;
            }
        }
    }
}
