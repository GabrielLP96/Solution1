using System.Collections.Generic;


namespace Data_Layer.IRepositories
{
   public interface IUserRepository : IRepository<User>
    {
        AlumnusModel AlumnusModel { get; }

        List<User> GetUsers(string username);
    }
}