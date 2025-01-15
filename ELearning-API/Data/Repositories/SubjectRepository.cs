using ELearning_API.Data.Repositories.Interfaces;
using ELearning_API.DTOs.Subject;
using ELearning_API.Models;
using ELearning_API.Models.Base;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ELearning_API.Data.Repositories
{
    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        private readonly AppDbContext _context;

        public SubjectRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<List<Subject>> All()
        {
            try
            {
                return await _dbSet
                    .AsNoTracking()
                    .AsSplitQuery()
                    .OrderBy(x => x.Name)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public override async Task<bool> Add(Subject request)
        {
            await _dbSet.AddAsync(request);

            return true;
        }

        public override async Task<bool> Update(Subject request)
        {
            try
            {
                Subject? subject = await _dbSet.FirstOrDefaultAsync(x => x.Id == request.Id);

                if (subject == null)
                    return false;

                subject.Name = request.Name;
                subject.IsPublished = request.IsPublished;

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public override async Task<bool> Delete(Guid id)
        {
            Subject? subject = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

            if (subject == null)
            {
                return false;
            }

            _dbSet.Remove(subject);

            return true;
        }

        public PaginatedResult<GetSubjectDTO> GetPaginated(int page, int pageSize, Expression<Func<Subject, bool>> condition)
        {
            int count = _context.Subjects.Where(condition).Count();
            List<Subject> records = _context.Subjects.Where(condition)
                .OrderBy(x => x.Name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();


            List<GetSubjectDTO> subjectsDTO = records.Adapt<List<GetSubjectDTO>>();

            return new PaginatedResult<GetSubjectDTO>
            {
                Result = subjectsDTO,
                Page = page,
                PageCount = (int)Math.Ceiling(count / (double)pageSize)
            };
        }

        public async Task<Subject> GetByName(string name)
        {
            var subject = await _context.Subjects.FirstOrDefaultAsync(x => x.Name == name);

            if(subject == null) {
                return null;
            }

            return subject;
        }
    }
}
