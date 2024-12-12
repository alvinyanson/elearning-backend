using ELearning_API.Migrations;
using System.Linq.Expressions;

namespace ELearning_API.Data.Repositories.Interfaces
{
    public interface IInstructorRepository
    {
        IEnumerable<ApplicationUser> All();

        ApplicationUser Get(Expression<Func<ApplicationUser, bool>> filter);
    }
}
