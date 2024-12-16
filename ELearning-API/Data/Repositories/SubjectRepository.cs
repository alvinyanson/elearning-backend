using ELearning_API.Data.Repositories.Interfaces;
using ELearning_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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
                    .OrderBy(x => x.CreatedAt)
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
    }
}
