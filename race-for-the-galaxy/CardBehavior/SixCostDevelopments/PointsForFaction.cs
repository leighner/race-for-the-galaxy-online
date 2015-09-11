using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior.SixCostDevelopments
{
    public class PointsForFaction
    {
        private Faction mFaction;
        private byte mPointsPerFaction;

        public PointsForFaction(byte pointsPerFaction, Faction faction)
        {
            mPointsPerFaction = pointsPerFaction;
            mFaction = faction;
        }

        public Faction Faction
        {
            get
            {
                return mFaction;
            }
        }

        public byte PointsPerFaction
        {
            get
            {
                return mPointsPerFaction;
            }
        }
    }
}
