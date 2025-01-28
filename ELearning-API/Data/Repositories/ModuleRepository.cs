using ELearning_API.Data.Repositories.Interfaces;
using ELearning_API.DTOs.Course;
using ELearning_API.DTOs.Module;
using ELearning_API.Models;
using ELearning_API.Models.Base;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace ELearning_API.Data.Repositories
{
    public class ModuleRepository : Repository<Module>, IModuleRepository
    {
        private readonly AppDbContext _context;

        public ModuleRepository(AppDbContext context): base(context)
        {
            _context = context;
        }

        public override async Task<bool> Add(Module request)
        {
            await _dbSet.AddAsync(request);
             
            return true;
        }

        public PaginatedResult<GetModuleDTO> GetPaginated(int page, int pageSize, Expression<Func<Module, bool>> condition)
        {
            int count = _context.Modules.Where(condition).Count();
            List<Module> records = _context.Modules.Where(condition)
                .Include(c => c.Course)
                .Include(c => c.Author)
                .Include(c => c.Course.Subject)
                .OrderBy(c => c.Title)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            List<GetModuleDTO> modulesDTO = records.Adapt<List<GetModuleDTO>>();


            return new PaginatedResult<GetModuleDTO>
            {
                Result = modulesDTO,
                Page = page,
                PageCount = (int)Math.Ceiling(count / (double)pageSize)
            };
        }
    }
}
