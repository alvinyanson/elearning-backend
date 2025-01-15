using ELearning_API.DTOs.Subject;
using ELearning_API.Models;
using ELearning_API.Models.Base;
using System.Linq.Expressions;

namespace ELearning_API.Data.Repositories.Interfaces
{
    public interface ISubjectRepository : IRepository<Subject>
    {
        PaginatedResult<GetSubjectDTO> GetPaginated(int page, int pageSize, Expression<Func<Subject, bool>> condition);

        Task<Subject> GetByName(string name);
    }
}
