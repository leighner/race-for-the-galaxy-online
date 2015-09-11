using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace race_for_the_galaxy.CardData
{
    class Tableau
    {
        private IEnumerable<ICardData> mCardData;

        internal Tableau(IEnumerable<ICardData> cardData)
        {
            mCardData = cardData;
        }

        
        public IEnumerable<ICardData> CardData
        {
            get
            {
                return mCardData;
            }
        }
    }
}
