using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entity;

namespace Repository
{
    public abstract class TypeConfigurationBase<TEntity> where TEntity : class
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> builder);

        protected virtual void ConfigureConversions(EntityTypeBuilder<TEntity> builder)
        {
        }
        protected virtual void ConfigureFK(EntityTypeBuilder<TEntity> builder)
        {
        }

        protected virtual void ConfigureTableName(EntityTypeBuilder<TEntity> builder, string tableName)
        {
            builder.ToTable(tableName);
        }
        protected virtual void ConfigureDefaultValues(EntityTypeBuilder<TEntity> builder)
        {
        }

        protected virtual void ConfigureIndex(EntityTypeBuilder<ResourceCostsEntity> builder)
        {
        }
    }
}
