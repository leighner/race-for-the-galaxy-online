using System;

namespace race_for_the_galaxy
{
    interface ICardData
    {
        int BaseValue
        {
            get;
        }

        int BaseCost
        {
            get;
        }
        
        Guid CardId
        {
            get;
        }

        string CardName
        {
            get;
        }

    }
}
