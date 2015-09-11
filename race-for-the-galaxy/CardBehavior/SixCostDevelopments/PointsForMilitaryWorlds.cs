using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace race_for_the_galaxy.CardBehavior.SixCostDevelopments
{
    public class PointsForMilitaryWorlds
    {
        private byte mPointsPerMilitaryWorld;
        private bool mRebelOnly;

        public PointsForMilitaryWorlds(byte pointsPerMilitaryWorld, bool rebelOnly = false)
        {
            mPointsPerMilitaryWorld = pointsPerMilitaryWorld;
            mRebelOnly = rebelOnly;
        }

        public bool RebelOnly
        {
            get
            {
                return mRebelOnly;
            }
        }

        public byte PointsPerMilitaryWorld
        {
            get
            {
                return mPointsPerMilitaryWorld;
            }
        }
    }
}
