using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public interface IEntity
    {
        Guid Id { get; }
    }
    public abstract class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public abstract class BaseNoKeyEntity : BaseEntity
    {
        public new Guid Id
        {
            get => throw new Exception($"The property {nameof(Id)} can not be set for Type {nameof(BaseNoKeyEntity)}");
            set => throw new Exception($"The property {nameof(Id)} can not be set for Type {nameof(BaseNoKeyEntity)}");
        }
    }

}
