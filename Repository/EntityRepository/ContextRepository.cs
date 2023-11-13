using Repository.Entity;

namespace Repository.EntityRepository
{
    public class ContextRepository : GenericRepository<ContextEntity>, IContextRepository
    {
        public ContextRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
