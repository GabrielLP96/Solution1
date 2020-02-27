using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.IRepositories
{
    public interface IAlumnusRepository : IRepository<Alumnus>
    {
        AlumnusModel AlumnusModel { get; }

        void CreateAlumn(Alumnus alumn);
        List<Alumnus> GetAlumns();
        Alumnus GetAlumnus(int userId);
        bool IsAlumnus(User currentUser);
    }
}