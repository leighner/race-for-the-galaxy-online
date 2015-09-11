using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace race_for_the_galaxy.CardBehavior.SixCostDevelopments
{
    public class PointsPerWorld
    {
        private bool mIncludeProduction;
        private bool mIncludeWindfall;
        private byte mNumberOfPointsPerWorld;

        public PointsPerWorld(byte numberOfPointsPerWorld, bool includeProduction, bool includeWindfall)
        {
            mNumberOfPointsPerWorld = numberOfPointsPerWorld;
            mIncludeProduction = includeProduction;
            mIncludeWindfall = includeWindfall;
        }

        public bool IncludeProduction
        {
            get
            {
                return mIncludeProduction;
            }
        }

        public bool IncludeWindfall
        {
            get
            {
                return mIncludeWindfall;
            }
        }

        public byte NumberOfPointsPerWorld
        {
            get
            {
                return mNumberOfPointsPerWorld;
            }
        }
    }
}
