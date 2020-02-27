namespace Data_Layer.IRepositories
{
   public interface IEmployeeRepository : IRepository<Employee>
    {
        AlumnusModel AlumnusModel { get; }

        void CreateEmployee(Employee employee);
        Employee GetEmployee(int userId);
        bool IsEmployee(User currentUser);
    }
}