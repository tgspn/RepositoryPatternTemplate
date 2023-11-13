using Repository.EntityRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        private readonly ApplicationDbContext dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.InitializeRepository(dbContext);
        }

        /*         
            public IContextRepository Context { get;  }
         */


        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        public int SaveChanges() => dbContext.SaveChanges();
        public Task<int> SaveChangesAsync() => dbContext.SaveChangesAsync();
        public TransactionScope CreateTransactionScope() => new TransactionScope();
        public TransactionScope CreateTransactionScope(TransactionScopeAsyncFlowOption asyncFlowOption) => new TransactionScope(TransactionScopeOption.Required,TimeSpan.FromMinutes(60),asyncFlowOption) ;
    }
}
