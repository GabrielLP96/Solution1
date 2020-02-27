using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Repositories
{
    class AlumnusRepository : Repository<Alumnus>
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
    }
}
