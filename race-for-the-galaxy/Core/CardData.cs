using race_for_the_galaxy;
using System;

namespace Core.race_for_the_galaxy
{
    public class CardData : ICardData
    {
        public int BaseCost
        {
            get
            {
                return 0;  
            }
        }

        public int BaseValue
        {
            get
            {
                return 0;
            }
        }

        public Guid CardId
        {
            get
            {
                return Guid.Empty;
            }
        }

        public string CardName
        {
            get
            {
                return string.Empty;
            }
        }
    }
}
