using Repository.EntityRepository;
using System.Transactions;

namespace Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {

        /*         
            public IContextRepository Context { get;  }
         */

        TransactionScope CreateTransactionScope();
        TransactionScope CreateTransactionScope(TransactionScopeAsyncFlowOption asyncFlowOption);
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
