namespace Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity, bool autosave = true);
        IQueryable<TEntity> GetAll();
        TEntity? GetById(Guid id);
        void Update(TEntity entity, bool autosave = true);
        void SaveChanges();
        void Delete(Guid id);
        void Delete(TEntity entity, bool autosave = true);
        void AddRange(IEnumerable<TEntity> entities, bool autosave = false);
    }
}
