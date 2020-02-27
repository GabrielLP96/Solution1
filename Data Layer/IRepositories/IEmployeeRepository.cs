namespace Data_Layer.Repositories
{
   public interface IEmployeeRepository
    {
        AlumnusModel AlumnusModel { get; }

        void CreateEmployee(Employee employee);
        Employee GetEmployee(int userId);
        bool IsEmployee(User currentUser);
    }
}