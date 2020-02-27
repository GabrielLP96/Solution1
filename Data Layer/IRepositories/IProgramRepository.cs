using System.Collections.Generic;

namespace Data_Layer.Repositories
{
    interface IProgramRepository
    {
        AlumnusModel AlumnusModel { get; }

        void CreateProgram(Program program);
        List<Program> GetProgram();
    }
}