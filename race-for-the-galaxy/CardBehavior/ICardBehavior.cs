using race_for_the_galaxy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace race_for_the_galaxy.CardBehavior
{
    interface ICardBehavior
    {
        Phase PhaseTrigger { get; }
    }
}
