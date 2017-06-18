using System;
using System.Collections.Generic;
namespace MouseGuardGMTool.Models
{
<<<<<<< HEAD:MouseGuardGMTool/Repository/FakeTheGuardRepository.cs
    public class FakeTheGuardRepository :ITheGuardRepository
=======
    public class       FakePlayerRepository :IPlayerRepository
>>>>>>> parent of 7858a07... More updates:MouseGuardGMTool/Repository/FakePlayerRepository.cs
    {
        public IEnumerable<Recruitment> Recruitments => new List<Recruitment>
        {
<<<<<<< HEAD:MouseGuardGMTool/Repository/FakeTheGuardRepository.cs
            new TheGuard {Name="Thom", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5},
            new TheGuard {Name="David", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5},
            new TheGuard {Name="Bran", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5},
            new TheGuard {Name="Kyle", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5},
            new TheGuard {Name="Gwen", Nature = 5, Will = 3, Health = 4, Resources = 2, Circles = 5}
=======
            new Recruitment {Name="Thom", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5},
            new Recruitment {Name="David", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5},
            new Recruitment {Name="Bran", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5},
            new Recruitment {Name="Kyle", Nature = 4, Will = 4, Health = 4, Resources = 4, Circles = 5}

>>>>>>> parent of 7858a07... More updates:MouseGuardGMTool/Repository/FakePlayerRepository.cs
        };
    }
}



