using System;
using System.Collections.Generic;
using MouseGuardGMTool.Models;
namespace MouseGuardGMTool.Models
{
    public interface IPlayerRepository
    {
        IEnumerable<TheGuard> TheGuards { get; }
    }
}

