using ELearning_API.DTOs.Course;
using ELearning_API.DTOs.Subject;
using ELearning_API.Models;
using ELearning_API.Models.Base;
using System.Linq.Expressions;

namespace ELearning_API.Data.Repositories.Interfaces
{
    public interface ICourseRepository : IRepository<Course>
    {
        PaginatedResult<GetCourseDTO> GetPaginated(int page, int pageSize, Expression<Func<Course, bool>> condition);
    }
}
