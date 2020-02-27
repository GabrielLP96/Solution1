using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class ProgramBL : Data_Layer.Program
    { 
        public static ProgramBL Convert (Data_Layer.Program program)
        {
            return new ProgramBL()
            {
                Name = program.Name,
            };

        }
    }
}
