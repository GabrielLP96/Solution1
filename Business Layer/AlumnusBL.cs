using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
   public class AlumnusBL : Data_Layer.Alumnus
    {
        public AlumnusBL Convert(Data_Layer.Alumnus alumnus)
        {
            return new AlumnusBL()
            {
                Username = alumnus.Username,
                AlumnId = alumnus.AlumnId,
                PersonId = alumnus.PersonId,
                Aktivity = alumnus.Aktivity,
                Program = alumnus.Program,
                User = alumnus.User,
                PassW = alumnus.PassW,
                FirstName = alumnus.FirstName,
                LastName = alumnus.LastName,
                Email = alumnus.Email,
                PersonCode = alumnus.PersonCode,                
            };
        }
    }
}
