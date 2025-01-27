using ELearning_API.Data.Repositories.Interfaces;
using ELearning_API.DTOs.Course;
using ELearning_API.DTOs.Subject;
using ELearning_API.Models;
using ELearning_API.Models.Base;
using Mapster;
using Microsoft.EntityFrameworkCore;
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


        public override async Task<bool> Add(Course request)
        {
            await _dbSet.AddAsync(request);

            return true;
        }

        public override async Task<bool> Update(Course request)
        {
            Course? course = await _dbSet.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (course == null)
                return false;

            course.Title = request.Title;
            course.Icon = request.Icon;
            course.IsPublished = request.IsPublished;
            course.Duration = request.Duration;
            course.SubjectId = request.SubjectId;
            course.AuthorId = request.AuthorId;

            return true;
        }

        public override async Task<bool> Delete(Guid id)
        {
            Course? course = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

            if (course == null)
                return false;

            _dbSet.Remove(course);

            return true;
        }

        public async Task<Course?> GetByName(string name)
        {
            Course? course = await _context.Courses.FirstOrDefaultAsync(x => x.Title.ToUpper() == name.ToUpper());

            if (course == null)
                return null;

            return course;
        }

        public PaginatedResult<GetCourseDTO> GetPaginated(int page, int pageSize, Expression<Func<Course, bool>> condition)
        {
            int count = _context.Courses.Where(condition).Count();
            List<Course> records = _context.Courses.Where(condition)
                .Include(c => c.Subject)
                .Include(c => c.Author)
                .OrderBy(c => c.Title)
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

        public override async Task<Course?> GetById(Guid id)
        {
            Course? course = await _context.Courses
                .Include(c => c.Subject)
                .Include(c => c.Author)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (course == null)
                return null;

            return course;
        }
    }
}
