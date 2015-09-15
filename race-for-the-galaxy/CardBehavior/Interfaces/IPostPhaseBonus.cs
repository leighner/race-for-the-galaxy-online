using Core.race_for_the_galaxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace race_for_the_galaxy.CardBehavior.Interfaces
{
    public interface IPostPhaseBonus
    {
        int PostPhaseDrawBonus(IEnumerable<CardData> cardsBought, IEnumerable<CardData> cardsConsumed);
    }
}
