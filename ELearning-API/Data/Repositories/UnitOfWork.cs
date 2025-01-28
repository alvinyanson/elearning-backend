using ELearning_API.Data.Repositories.Interfaces;

namespace ELearning_API.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AppDbContext _context;

        public IInstructorRepository Instructor { get; private set; }

        public ISubjectRepository Subject { get; private set; }

        public ICourseRepository Course { get; private set; }

        public IModuleRepository Module  { get; private set; }

        public UnitOfWork(AppDbContext context)
            {
                _context = context;
                Instructor = new InstructorRepository(_context);
                Subject = new SubjectRepository(_context);
                Course = new CourseRepository(_context);
                Module = new ModuleRepository(_context);
            }


            public async Task<bool> CompleteAsync()
            {
                var result = await _context.SaveChangesAsync();

                return result > 0;
            }

            public void Dispose()
            {
                _context.Dispose();
            }
    }
}
