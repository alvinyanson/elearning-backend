namespace ELearning_API.Data.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IInstructorRepository Instructor { get; }

        ISubjectRepository Subject { get; }

        ICourseRepository Course { get; }

        IModuleRepository Module { get; }

        Task<bool> CompleteAsync();
    }
}
