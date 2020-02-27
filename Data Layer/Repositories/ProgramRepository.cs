using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.IRepositories;

namespace Data_Layer.Repositories
{
    class ProgramRepository : Repository<Program>, IProgramRepository
    {
        public ProgramRepository(AlumnusModel context) : base(context)
        {
        }

        public void CreateProgram(Program program)
        {
            using (var db = new AlumnusModel())
            {
                db.Program.Add(program);
                db.SaveChanges();
            }
        }

        public List<Program> GetProgram()
        {
            using (var db = new AlumnusModel())
            {
                return db.Program.ToList();
            }
        }

        public AlumnusModel AlumnusModel
        {
            get { return Context as AlumnusModel; }
        }
    }
}

