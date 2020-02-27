using System.Collections.Generic;


namespace Data_Layer.Repositories
{
    interface IUserRepository
    {
        AlumnusModel AlumnusModel { get; }

        List<User> GetUsers();
    }
}