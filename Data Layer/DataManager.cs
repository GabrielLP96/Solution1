using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Data_Layer.Repositories;
using Data_Layer.IRepositories;
using System.Threading.Tasks;
using Data_Layer.UnitOfWork;

namespace Data_Layer
{
    public class DataManager
    {
        private IUnitOfWork unitOfWork = new UnitOfWork(context);
        private static readonly AlumnusModel context;

        public void CreateAlumn(Alumnus alumn)
        {
            using (var db = new AlumnusModel())
            {
                db.User.Add(alumn);
                db.SaveChanges();
            }
        }

        public void CreateEmployee(Employee employee)
        {
            unitOfWork.Employee.Add(employee);
            unitOfWork.Complete();
        }

        public void CreateAktivity(Aktivity aktivity)
        {
            using (var db = new AlumnusModel())
            {
                db.Aktivity.Add(aktivity);
                db.SaveChanges();
            }
        }

        public void CreateSection(Section section)
        {
            using (var db = new AlumnusModel())
            {
                db.Section.Add(section);
                db.SaveChanges();
            }
        }

        public bool IsAlumnus(User currentUser)
        {
            using (var db = new AlumnusModel())
            {
                if (db.User.OfType<Alumnus>().ToList().Where(x => x.UserId == currentUser.UserId).FirstOrDefault() != null)
                {

                    return true;
                }

                else
                {

                    return false;
                }
            }
        }

        public bool IsEmployee(User currentUser)
        {
            using (var db = new AlumnusModel())
            {
                if (db.User.OfType<Employee>().ToList().Where(x => x.UserId == currentUser.UserId).FirstOrDefault() != null)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }

        public User GetUser(string username, string password)
        {
            using (var db = new AlumnusModel())
            {
                return db.User.Where(x => x.Username == username && x.PassW == password).FirstOrDefault();
            }
        }

        public Employee GetEmployee(int userId)
        {
            using (var db = new AlumnusModel())
            {
                return db.User.OfType<Employee>().Where(x => x.UserId == userId).FirstOrDefault();
            }
        }

        public Section GetSection(int SectionId)
        {
            using (var db = new AlumnusModel())
            {
                return db.Section.Where(x => x.SectionId == SectionId).FirstOrDefault();
            }
        }

        public Alumnus GetAlumn(int userId)
        {
            using (var db = new AlumnusModel())
            {
                return db.User.OfType<Alumnus>().Where(x => x.UserId == userId ).FirstOrDefault();
            }
        }

        public void CreateProgram(Program program)
        {
            using (var db = new AlumnusModel())
            {
                db.Program.Add(program);
                db.SaveChanges();
            }
        }

        public List<User> GetUser()
        {
            using (var db = new AlumnusModel())
            {
                return db.User.ToList();
            }
        }

        public List<Aktivity> GetEvents()
        {
            using (var db = new AlumnusModel())
            {
                return db.Aktivity.ToList();
            }
        }

        public List<Section> GetSections()
        {
            using (var db = new AlumnusModel())
            {
                return db.Section.ToList();
            }
        }

        public List<Alumnus> GetAlumns()
        {
            using (var db = new AlumnusModel())
            {
                return db.User.OfType<Alumnus>().ToList();
            }
        }

        //public List<Employee>

        public List<Program> GetPrograms()
        {
            using (var db = new AlumnusModel())
            {
                return db.Program.ToList();
            }
        }

        public void UpdateEvent(Aktivity localEvent, int aktivitId)
        {
            using (var db = new AlumnusModel())
            {
                var item = db.Aktivity.Where(x => x.AktivityId == aktivitId).FirstOrDefault();

                item.Name = localEvent.Name;
                item.Description = localEvent.Description;

                db.SaveChanges();
            }
        }

        public void DeleteEvent(Aktivity localEvent)
        {
            using (var db = new AlumnusModel())
            {
                var item = db.Aktivity.Where(x => x.AktivityId == localEvent.AktivityId).FirstOrDefault();
                db.Aktivity.Remove(item);
                db.SaveChanges();
            }
        }
    }

}

