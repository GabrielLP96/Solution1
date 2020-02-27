using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.UnitOfWork;
using Data_Layer.Repositories;
using Data_Layer.IRepositories;

namespace Data_Layer.UnitOfWork
{
    public class UnitOfWork
    {
        private readonly AlumnusModel _context;


        public UnitOfWork(AlumnusModel context)
        {
            _context = context;
            Alumnus = new AlumnusRepository(_context);
            Employee = new EmployeeRepository(_context);
            Activities = new ActivitiesRepository(_context);         
            User = new UserRepository(_context);
            Program = new ProgramRepository(_context);
            Section = new SectionRepository(_context);

        }

        public IAlumnusRepository Alumnus { get; private set; }
        public IEmployeeRepository Employee { get; private set; }
        public IActivitiesRepository Activities { get; private set; }
        public IUserRepository User { get; private set; }
        
        public IProgramRepository Program { get; private set; }
        public ISectionRepository Section { get; private set; }


    }
}
