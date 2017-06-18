using System;
using System.Collections.Generic;
using MouseGuardGMTool.Models;
namespace MouseGuardGMTool
{
    public interface ITheGuardRepository
    {
        IEnumerable<Recruitment> Recruitments { get; }
    }
}

