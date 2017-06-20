using System;
using System.Collections.Generic;
namespace MouseGuardGMTool.Models
{
    public class FakeMissionRepository : IMissionRepository
    {
        public IEnumerable<TheMission> TheMissions => new List<TheMission>
        {
            new TheMission {Name = "Rain Gather", Location = "Oakdale", Details = "Stuff"},
            new TheMission {Name = "The Grain Peddeler", Location = "On Patrol", Details = "Stuff"},
            new TheMission {Name = "Deliver The Mail", Location = "To Elmoss", Details = "Stuff"}

        };
    }
}



