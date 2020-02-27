using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class SektionBl : Data_Layer.Section
    {
        public static SektionBl Convert(Data_Layer.Section section)
        {
            return new SektionBl()
            {
                SectionId = section.SectionId,
                Name = section.Name,
                EmployeeId = section.EmployeeId,
                ProgramId = section.ProgramId,
                Employee = section.Employee,
                Program = section.Program,
            };
        }
    }
}
