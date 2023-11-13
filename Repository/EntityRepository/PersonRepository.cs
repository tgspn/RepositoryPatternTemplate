using Repository.Entity;

namespace Repository.EntityRepository
{
    public class PersonRepository : GenericRepository<PersonEntity>, IPersonRepository
    {
        public PersonRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
