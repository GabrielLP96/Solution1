using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.IRepositories;

namespace Data_Layer.Repositories
{
    public class ActivitiesRepository : Repository<Aktivity>, IActivitiesRepository
    {
        public ActivitiesRepository(AlumnusModel context) : base(context)
        {
        }

        public void CreateActivity(Aktivity aktivity)
        {
            using (var db = new AlumnusModel())
            {
                db.Aktivity.Add(aktivity);
                db.SaveChanges();
            }
        }

        public List<Aktivity> GetActivities()
        {
            using (var db = new AlumnusModel())
            {
                return db.Aktivity.ToList();
            }
        }
        public List<Aktivity> GetActivitiesByAlumnus()
        {
            using (var db = new AlumnusModel())
            {
                return db.Aktivity.Where(x => x.Alumnus != null).ToList();
            }
        }

        public void DeleteActivities(Aktivity localaktivity)
        {

        }

        public void UpdateActivity(Aktivity Localaktivty, int aktivityId)
        {

        }

        public AlumnusModel AlumnusModel
        {
            get { return Context as AlumnusModel; }
        }


    }
}
