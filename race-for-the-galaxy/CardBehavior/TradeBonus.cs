using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    public class TradeBonus : ICardBehavior
    {
        private byte mBonus;

        public TradeBonus(byte bonus, GoodType good = GoodType.Any)
        {
            mBonus = bonus;
        }

        public byte Bonus
        {
            get
            {
                return mBonus;
            }
        }

        public Phase PhaseTrigger
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
