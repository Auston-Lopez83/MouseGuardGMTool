using System;
using System.Collections.Generic;
namespace MouseGuardGMTool.Models
{
    public class       FakePlayerRepository :IPlayerRepository
    {
        public IEnumerable<Recruitment> Recruitments => new List<Recruitment>
        {
            new Recruitment {Name="Thom", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5},
            new Recruitment {Name="David", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5},
            new Recruitment {Name="Bran", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5},
            new Recruitment {Name="Kyle", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5}

        };
    }
}



