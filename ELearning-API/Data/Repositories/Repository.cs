
using ELearning_API.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ELearning_API.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        internal DbSet<T> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual async Task<bool> Add(T entity)
        {
            throw new NotImplementedException();
        }

        

        public virtual Task<List<T>> All()
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T?> GetById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
