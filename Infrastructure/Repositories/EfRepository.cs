using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class EfRepository<T> : IAsyncRepository<T> where T : class

    {
        protected readonly MovieShopDbContext _dbContext;



        public async Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetCountAsync(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> GetExistsAsync(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetCountAsync(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetExistsAsync(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
