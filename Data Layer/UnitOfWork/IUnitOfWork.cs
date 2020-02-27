using Data_Layer.IRepositories;

namespace Data_Layer.UnitOfWork
{
    public interface IUnitOfWork
    {
        IActivitiesRepository Activities { get; }
        IAlumnusRepository Alumnus { get; }
        IEmployeeRepository Employee { get; }
        IProgramRepository Program { get; }
        ISectionRepository Section { get; }
        IUserRepository User { get; }

        int Complete();
        void Dispose();
    }
}