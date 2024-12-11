using ELearning_API.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ELearning_API.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        internal DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }


        public virtual Task<IEnumerable<T>> All()
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
