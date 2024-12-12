using ELearning_API.Data.Repositories.Interfaces;
using ELearning_API.Migrations;
using System.Linq.Expressions;

namespace ELearning_API.Data.Repositories
{
    public class InstructorRepository : Repository<InstructorRepository>, IInstructorRepository
    {
        private readonly AppDbContext _context;

        public InstructorRepository(AppDbContext context) : base (context)
        {
            _context = context;
        }

        public IEnumerable<ApplicationUser> All()
        {
            throw new NotImplementedException();
        }

        public ApplicationUser Get(Expression<Func<ApplicationUser, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
