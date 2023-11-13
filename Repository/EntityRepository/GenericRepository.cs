using Repository.Entity;

namespace Repository.EntityRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        protected readonly ApplicationDbContext _dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public TEntity Create(TEntity entity, bool autosave = true)
        {
            var response = _dbContext.Set<TEntity>().Add(entity);
            if (autosave)
                _dbContext.SaveChanges();
            return response.Entity;
        }
        public void AddRange(IEnumerable<TEntity> entities, bool autosave = false)
        {
            _dbContext.Set<TEntity>().AddRange(entities);
            if (autosave)
                _dbContext.SaveChanges();
        }
        public virtual void Delete(Guid id)
        {
            var entity = GetById(id);
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }
        public virtual void Delete(TEntity entity, bool autosave = true)
        {
            _dbContext.Set<TEntity>().RemoveRange(entity);
            if (autosave)
                _dbContext.SaveChanges();
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>();
        }
        public virtual TEntity? GetById(Guid id)
        {
            return _dbContext.Set<TEntity>()
                    .FirstOrDefault(e => e.Id == id);
        }

        public void Update(TEntity entity, bool autosave = true)
        {
            _dbContext.Set<TEntity>().Update(entity);
            if (autosave)
                _dbContext.SaveChanges();
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
