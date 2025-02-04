using ELearning_API.Data.Repositories.Interfaces;
using ELearning_API.DTOs.Course;
using ELearning_API.DTOs.Module;
using ELearning_API.Models;
using ELearning_API.Models.Base;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
            EntityEntry<Module> result = await _context.Modules.AddAsync(request);

            foreach (var content in request.Content)
            {
                content.ModuleId = result.Entity.Id;
            }

            await _context.Contents.AddRangeAsync(request.Content.AsEnumerable());

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

        public override async Task<bool> Delete(Guid id)
        {
            Module? module = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

            if (module == null)
                return false;

            _dbSet.Remove(module);

            return true;
        }

        public override async Task<bool> Update(Module request)
        {
            Module? module = await _dbSet.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (module == null)
                return false;

            module.Title = request.Title;
            module.Duration = request.Duration;
            module.IsPublished = request.IsPublished;
            module.CourseId = request.CourseId;
            module.AuthorId = request.AuthorId;

            return true;
        }

        public async Task<Module?> GetByName(string name)
        {
            Module? module = await _context.Modules.FirstOrDefaultAsync(x => x.Title.ToUpper() == name.ToUpper());

            if (module == null)
                return null;

            return module;
        }

        public override async Task<Module?> GetById(Guid id)
        {
            Module? module = await _context.Modules
                .Include(c => c.Course)
                .Include(c => c.Author)
                .FirstOrDefaultAsync(x => x.Id == id);

            if(module == null) 
                return null;

            return module;
        }
    }
}
