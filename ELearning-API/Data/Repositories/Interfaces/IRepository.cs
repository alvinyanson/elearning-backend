using ELearning_API.Models.Base;
using ELearning_API.Models;
using System.Linq.Expressions;

namespace ELearning_API.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> All();

        Task<T?> GetById(Guid id);

        Task<bool> Add(T entity);

        Task<bool> Update(T entity);
        
        Task<bool> Delete(Guid id);
    }
}
