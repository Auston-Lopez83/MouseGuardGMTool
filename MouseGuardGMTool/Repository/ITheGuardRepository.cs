using System;
using System.Collections.Generic;
using MouseGuardGMTool.Models;
namespace MouseGuardGMTool.Models
{
    public interface ITheGuardRepository
    {
        IEnumerable<TheGuard> TheGuards { get; }
    }
}

