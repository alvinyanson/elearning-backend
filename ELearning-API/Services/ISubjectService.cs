using ELearning_API.Models;

namespace ELearning_API.Services
{
    public interface ISubjectService
    {
        Task<IEnumerable<Subject>> All();
    }
}
