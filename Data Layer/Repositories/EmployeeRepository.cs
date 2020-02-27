using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.IRepositories;

namespace Data_Layer.Repositories
{
    class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AlumnusModel context) : base(context)
        {
        }

        public void CreateEmployee(Employee employee)
        {
            using (var db = new AlumnusModel())
            {
                db.User.Add(employee);
                db.SaveChanges();
            }
        }

        public Employee GetEmployee(int userId)
        {
            using (var db = new AlumnusModel())
            {
                return db.User.OfType<Employee>().Where(x => x.UserId == userId).FirstOrDefault();
            }
        }

        public bool IsEmployee(User currentUser)
        {
            using (var db = new AlumnusModel())
            {
                if (db.User.OfType<Employee>().Where(x => x.UserId == currentUser.UserId).FirstOrDefault() != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public AlumnusModel AlumnusModel
        {
            get { return Context as AlumnusModel; }
        }
    }
}
