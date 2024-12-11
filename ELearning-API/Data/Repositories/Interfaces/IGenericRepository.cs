namespace ELearning_API.Data.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> All();

        Task<T> GetById(Guid id);
    }
}
