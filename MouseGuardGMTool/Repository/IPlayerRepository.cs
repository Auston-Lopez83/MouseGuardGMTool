using System;
using System.Collections.Generic;
using MouseGuardGMTool.Models;
namespace MouseGuardGMTool
{
    public interface IPlayerRepository
    {
        IEnumerable<Recruitment> Recruitments { get; }
    }
}

