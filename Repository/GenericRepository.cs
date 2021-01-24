using DAL;
using Microsoft.EntityFrameworkCore;
using Repository.Common;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly VehicleDbContext dbContext;
        public GenericRepository(VehicleDbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException("DbContext");
            }
            this.dbContext = dbContext;
        }
        public IQueryable<T> FindAll() => dbContext.Set<T>().AsNoTracking();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) => dbContext.Set<T>().Where(expression).AsNoTracking();
        public void Update(T entity) => dbContext.Set<T>().Update(entity);
        public void Delete(T entity) => dbContext.Set<T>().Remove(entity);
        public async Task CreateAsync(T entity) => await dbContext.Set<T>().AddAsync(entity);
        public async Task SaveChangesAsync() => await dbContext.SaveChangesAsync();
    }
}
