using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer;

namespace Presentationslager
{
   public static class Globals
    {
        public static UserBL CurrentUser { get; set; }
        public static SektionBl CurrentSection { get; set; }
    }
}
