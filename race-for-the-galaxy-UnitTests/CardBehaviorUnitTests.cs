using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.race_for_the_galaxy;
using race_for_the_galaxy.CardBehavior;
using race_for_the_galaxy.Core;
using System.Collections.Generic;

namespace race_for_the_galaxy_UnitTests
{
    [TestClass]
    public class CardBehaviorUnitTests
    {
        private CardData mWorldCard;
        private CardData mDevelopCard;
        private readonly Guid mCardId = Guid.NewGuid();
        [TestInitialize]
        public void SetupTest()
        {
            mWorldCard = new CardData(CardType.World ,10, 10, mCardId, "TestWorldCard");
            mDevelopCard = new CardData(CardType.Development, 10, 10, mCardId, "TestDevelopCard");
        }

        [TestMethod]
        public void TestDevelopDiscount()
        {
            var discount = new DevelopDiscount(4);
            Assert.AreEqual(0,discount.DiscountAmount(mWorldCard));
            Assert.AreEqual(4, discount.DiscountAmount(mDevelopCard));
        }

        [TestMethod]
        public void TestSettleDiscount()
        {
            var discount = new SettleDiscount(1, new List<GoodType>() { GoodType.Any });
            Assert.AreEqual(1, discount.DiscountAmount(mWorldCard));
            Assert.AreEqual(0, discount.DiscountAmount(mDevelopCard));
            discount = new SettleDiscount(1, new List<GoodType>() { GoodType.Genes });
            var worldCard = new CardData(CardType.World, 10, 10, mCardId, "TestWorldCard");
        }

        [TestMethod]
        public void ShouldNotApplySpecificSettleDiscount()
        {

            var discount = new SettleDiscount(1, new List<GoodType>() { GoodType.Genes });
            var worldCard = new CardData(CardType.World, 10, 10, mCardId, "TestWorldCard");
            Assert.AreEqual(0, discount.DiscountAmount(mDevelopCard));
        }

        [TestMethod]
        public void ShouldApplySpecificSettleDiscount()
        {

            var discount = new SettleDiscount(1, new List<GoodType>() { GoodType.Any });
            var worldCard = new CardData(CardType.World, 10, 10, mCardId, "TestWorldCard");
            worldCard.CardBehaviors.Add(new ProductionWorld(GoodType.Alien));
            Assert.AreEqual(1, discount.DiscountAmount(worldCard));
        }

    }
}
