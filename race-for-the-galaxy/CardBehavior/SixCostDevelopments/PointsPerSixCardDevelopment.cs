using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace race_for_the_galaxy.CardBehavior.SixCostDevelopments
{
    public class PointsPerSixCardDevelopment
    {
        private byte mPointsPerCard;

        public PointsPerSixCardDevelopment(byte pointsPerCard)
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
