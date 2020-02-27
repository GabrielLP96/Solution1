using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;
using Data_Layer.IRepositories;

namespace Data_Layer.Repositories
{
    class AlumnusRepository : Repository<Alumnus>, IAlumnusRepository
    {
        public AlumnusRepository(AlumnusModel context) : base(context)
        {
        }

        public void CreateAlumn(Alumnus alumn)
        {
            using (var db = new AlumnusModel())
            {
                db.User.Add(alumn);
                db.SaveChanges();
            }
        }

        public Alumnus GetAlumnus(int userId)
        {
            using (var db = new AlumnusModel())
            {
                return db.User.OfType<Alumnus>().Where(x => x.UserId == userId).FirstOrDefault();
            }
        }
        public List<Alumnus> GetAlumns()
        {
            using (var db = new AlumnusModel())
            {
                return db.User.OfType<Alumnus>().ToList();
            }
        }

        public bool IsAlumnus(User currentUser)
        {
            using (var db = new AlumnusModel())
            {
                if (db.User.OfType<Alumnus>().Where(x => x.UserId == currentUser.UserId).FirstOrDefault() != null)
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


