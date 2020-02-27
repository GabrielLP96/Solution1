using System.Collections.Generic;

namespace Data_Layer.IRepositories
{
    public interface IProgramRepository : IRepository<Program>
    {
        AlumnusModel AlumnusModel { get; }

        void CreateProgram(Program program);
        List<Program> GetProgram();
    }
}