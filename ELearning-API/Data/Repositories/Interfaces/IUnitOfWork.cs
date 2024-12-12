namespace ELearning_API.Data.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IInstructorRepository Instructor { get; }

        void Save();
    }
}
