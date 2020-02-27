using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class UserBL : Data_Layer.User
    {
        public UserBL()
        {

        }

        public UserBL (Data_Layer.User user)
        {
            UserId = user.UserId;
            Username = user.Username;
            PassW = user.PassW;
            PersonCode = user.PersonCode;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
        }
    }
}
