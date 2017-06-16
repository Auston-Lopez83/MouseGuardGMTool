using System.Collections.Generic;
namespace MouseGuardGMTool.Models
{
    public class EFProductRepository : ITheGuardRepository
    {
        private ApplicationDbContext context;
        public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<TheGuard> TheGuards => context.TheGuards;
    }
}
