using System.Collections.Generic;

namespace Data_Layer.Repositories
{
    public interface IAlumnusRepository
    {
        AlumnusModel AlumnusModel { get; }

        void CreateAlumn(Alumnus alumn);
        List<Alumnus> GetAlumns();
        Alumnus GetAlumnus(int userId);
        bool IsAlumnus(User currentUser);
    }
}