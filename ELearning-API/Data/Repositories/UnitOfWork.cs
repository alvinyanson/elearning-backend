using ELearning_API.Data.Repositories.Interfaces;

namespace ELearning_API.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Instructor = new InstructorRepository(_context);
        }

        public IInstructorRepository Instructor { get; private set; }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
