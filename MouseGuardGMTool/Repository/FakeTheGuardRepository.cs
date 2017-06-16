using System;
using System.Collections.Generic;
namespace MouseGuardGMTool.Models
{
    public class FakeTheGuardRepository :ITheGuardRepository
    {
        public IEnumerable<TheGuard> TheGuards => new List<TheGuard>
        {
            new TheGuard {Name="Thom", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5},
            new TheGuard {Name="David", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5},
            new TheGuard {Name="Bran", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5},
            new TheGuard {Name="Kyle", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5},
            new TheGuard {Name="Gwen", Nature = 5, Will = 3, Health = 4, Resources = 2, Circles = 5}
        };
    }
}



