
using ELearning_API.Models;

namespace ELearning_API.Services
{
    public interface IUsersService
    {
        IEnumerable<ApplicationUser> All();
    }
}
