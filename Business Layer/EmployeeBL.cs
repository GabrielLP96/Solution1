using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class EmployeeBL : Data_Layer.Employee
    {
        public EmployeeBL(Data_Layer.Employee employee)
        {
            EmployeeId = employee.EmployeeId;
            PersonId = employee.PersonId;
            Username = employee.Username;
            PassW = employee.PassW;   
            Aktivity = employee.Aktivity;
            Section = employee.Section;
            PersonCode = employee.PersonCode;
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            Email = employee.Email;       
                       
        }
    }
}
