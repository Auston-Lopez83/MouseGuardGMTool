using System;
using System.Collections.Generic;
using MouseGuardGMTool.Models;
using MouseGuardGMTool.Controllers;
namespace MouseGuardGMTool.Models
{
    public interface IMissionRepository
    {
        IEnumerable<TheMission> TheMissions { get; }
    }
}

