using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class ActivityBL : Data_Layer.Aktivity 
    {
        public static ActivityBL Convert(Data_Layer.Aktivity aktivity)
        {
            return new ActivityBL()
            {
                AktivityId = aktivity.AktivityId,
                Name = aktivity.Name,
                Description = aktivity.Description,
                Choose = aktivity.Choose,
                AlumId = aktivity.AlumId,
                EmployeeId = aktivity.EmployeeId,
                Alumnus = aktivity.Alumnus,
                Employee = aktivity.Employee,
            };
        }



    }
}
