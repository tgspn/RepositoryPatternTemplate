using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entity;

namespace Repository.TypeConfiguration
{
    public class PersonConfiguration : TypeConfigurationBase<PersonEntity>, IEntityTypeConfiguration<PersonEntity>
    {
        public override void Configure(EntityTypeBuilder<PersonEntity> builder)
        {
            ConfigureTableName(builder, "Person");
        }
    }
}
