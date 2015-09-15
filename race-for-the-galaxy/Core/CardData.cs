using race_for_the_galaxy.CardBehavior;
using race_for_the_galaxy.Core;
using System;
using System.Collections.Generic;

namespace Core.race_for_the_galaxy
{
    public class CardData : ICardData
    {
        private int mBaseValue;
        private int mBaseCost;
        private Guid mCardId;
        private string mCardName;
        private IList<ICardBehavior> mCardBehaviors;
        private CardType mCardType;
        private GoodType mGoodType;

        public CardData(CardType cardType,int baseValue, int baseCost, Guid cardId, string cardName)
        {
            mBaseValue = baseValue;
            mBaseCost = baseCost;
            mCardId = cardId;
            mCardName = cardName;
            mCardBehaviors = new List<ICardBehavior>();
            mCardType = cardType;
        }

        public int BaseValue
        {
            get { return mBaseValue; }
        }

        public int BaseCost
        {
            get { return mBaseCost; }
        }

        public Guid CardId
        {
            get { return mCardId; }
        }

        public string CardName
        {
            get { return mCardName; }
        }

        public IList<ICardBehavior> CardBehaviors
        {
             get { return mCardBehaviors; }
        }

        public CardType TypeOfCard
        {
            get { return mCardType; }
        }
    }
}
