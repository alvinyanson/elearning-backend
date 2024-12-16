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

        public override async Task<bool> Add(Subject subject)
        {
            await _dbSet.AddAsync(subject);

            return true;
        }

        public override async Task<bool> Update(Subject subject)
        {
            try
            {
                var result = await _dbSet.FirstOrDefaultAsync(x => x.Id == subject.Id);

                if (result == null)
                    return false;

                result.Name = subject.Name;

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
