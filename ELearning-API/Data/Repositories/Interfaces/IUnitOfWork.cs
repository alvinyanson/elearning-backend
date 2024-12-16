namespace ELearning_API.Data.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IInstructorRepository Instructor { get; }

        ISubjectRepository Subject { get; }

        Task<bool> CompleteAsync();
    }
}
