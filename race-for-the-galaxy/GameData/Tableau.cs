using Core.race_for_the_galaxy;
using race_for_the_galaxy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace race_for_the_galaxy.GameData
{
    public class Tableau
    {
        private IEnumerable<ICardData> mCardData;

        public Tableau()
        {
            mCardData = new List<ICardData>();
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
