using System;
using System.Threading.Tasks;
using System.Transactions;
using DAL;
using Microsoft.EntityFrameworkCore;
using Repository.Common;

namespace Repository
{
    public abstract class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        protected DbContext dbContext { get; private set; }

        public UnitOfWork(DbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException("DbContext");
            }
            this.dbContext = dbContext;
        }

        public virtual Task<int> AddAsync<T>(T entity) where T : class
        {
            try
            {
                dbContext.Set<T>().Add(entity);
                return Task.FromResult(1);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public virtual Task<int> UpdateAsync<T>(T entity) where T : class
        {
            try
            {
                dbContext.Set<T>().Update(entity);
                return Task.FromResult(1);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public virtual Task<int> DeleteAsync<T>(T entity) where T : class
        {
            try
            {
                dbContext.Set<T>().Remove(entity);
                return Task.FromResult(1);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public virtual Task<int> DeleteAsync<T>(Guid id) where T : class
        {
            var entity = dbContext.Set<T>().Find(id);
            if (entity == null)
            {
                return Task.FromResult(0);
            }
            return DeleteAsync<T>(entity);
        }

        public async Task<int> CommitAsync()
        {
            int result = 0;
            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                result = await dbContext.SaveChangesAsync();
                scope.Complete();
            }
            return result;
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
