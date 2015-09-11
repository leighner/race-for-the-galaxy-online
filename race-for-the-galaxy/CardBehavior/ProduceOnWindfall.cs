using race_for_the_galaxy.Core;

namespace race_for_the_galaxy.CardBehavior
{
    public class ProduceOnWindfall : ICardBehavior
    {
        private GoodType mGoodType;

        public ProduceOnWindfall(GoodType goodType = GoodType.Any)
        {
            mGoodType = goodType;
        }

        public Phase PhaseTrigger
        {
            get
            {
                return Phase.Produce;
            }
        }
    }
}
