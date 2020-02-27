using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.IRepositories;

namespace Data_Layer.Repositories
{
   public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AlumnusModel context) : base(context)
        {
        }

        public List<User> GetUser()
        {
            using (var db = new AlumnusModel())
            {
                return db.User.ToList();
            }
        }

        public AlumnusModel AlumnusModel
        {
            get { return Context as AlumnusModel; }
        }
    }


}

