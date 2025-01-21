using ELearning_API.Data.Repositories.Interfaces;
using ELearning_API.DTOs.Course;
using ELearning_API.DTOs.Subject;
using ELearning_API.Models;
using ELearning_API.Models.Base;
using Mapster;
using System.Linq.Expressions;

namespace ELearning_API.Data.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly AppDbContext _context;

        public CourseRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public PaginatedResult<GetCourseDTO> GetPaginated(int page, int pageSize, Expression<Func<Course, bool>> condition)
        {
            int count = _context.Courses.Where(condition).Count();
            List<Course> records = _context.Courses.Where(condition)
                .OrderBy(x => x.Title)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            List<GetCourseDTO> coursesDTO = records.Adapt<List<GetCourseDTO>>();


            return new PaginatedResult<GetCourseDTO>
            {
                Result = coursesDTO,
                Page = page,
                PageCount = (int)Math.Ceiling(count / (double)pageSize)
            };
        }
    }
}
