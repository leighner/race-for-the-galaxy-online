using System.Collections.Generic;
using race_for_the_galaxy.Core;
using race_for_the_galaxy.CardBehavior.Interfaces;
using Core.race_for_the_galaxy;
using System;
using System.Linq;

namespace race_for_the_galaxy.CardBehavior
{
    public class SettleDiscount : ICardBehavior, IDiscount
    {
        private List<GoodType> mApplicableGoods;
        private int mDiscountAmount;

        public SettleDiscount(int discountAmount, List<GoodType> applicableGoodTypes = null)
        {
            mDiscountAmount = discountAmount;
            if(applicableGoodTypes == null)
            {
                mApplicableGoods = new List<GoodType>() {GoodType.Any };
            }
            else
            {
                mApplicableGoods = applicableGoodTypes;
            }
        }

        public int Discount
        {
            get
            {
                return mDiscountAmount;
            }

            set
            {
                mDiscountAmount = value;
            }
        }

        public Phase PhaseTrigger
        {
            get
            {
                return Phase.Settle;
            }
        }

        public int DiscountAmount(CardData card)
        {
            bool shouldApplyDiscount = false;

            if(card.TypeOfCard == CardType.World)
            {
                var production = card.CardBehaviors.FirstOrDefault(behavior => behavior is ProductionWorld) as ProductionWorld;
                if(mApplicableGoods.Contains(GoodType.Any))
                {
                    shouldApplyDiscount = true;
                }
                else if(production != null && mApplicableGoods.Contains(production.GoodProduced))
                {
                    shouldApplyDiscount = true;
                }
            }
            return shouldApplyDiscount ? Discount : 0;
        }
    }
}
