using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entity;

namespace Repository
{
    public class ContextConfiguration : TypeConfigurationBase<ContextEntity>, IEntityTypeConfiguration<ContextEntity>
    {
        public override void Configure(EntityTypeBuilder<ContextEntity> builder)
        {
            ConfigureTableName(builder, "<table name>");
        }
    }
}
