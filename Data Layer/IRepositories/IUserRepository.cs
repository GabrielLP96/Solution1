using System.Collections.Generic;


namespace Data_Layer.Repositories
{
   public interface IUserRepository
    {
        AlumnusModel AlumnusModel { get; }

        List<User> GetUsers(string username);
    }
}