using ELearning_API.DTOs.Course;
using ELearning_API.DTOs.Module;
using ELearning_API.Models;
using ELearning_API.Models.Base;
using System.Linq.Expressions;

namespace ELearning_API.Data.Repositories.Interfaces
{
    public interface IModuleRepository : IRepository<Module>
    {
        PaginatedResult<GetModuleDTO> GetPaginated(int page, int pageSize, Expression<Func<Module, bool>> condition);

        Task<Module> GetByName(string name);
    }
}
