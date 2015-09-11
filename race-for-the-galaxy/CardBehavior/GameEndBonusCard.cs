using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace race_for_the_galaxy.CardBehavior
{
    interface IGameEndBonusCard
    {
        byte GetTotalBonus(IEnumerable<ICardData> cardData, byte vpChips);
    }
}
