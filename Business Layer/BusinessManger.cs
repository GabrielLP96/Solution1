using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;
using Data_Layer.Repositories;
using Data_Layer.IRepositories;
using Data_Layer.UnitOfWork;
using Business_Layer;




namespace Business_Layer
{
    public class BusinessManger
    {
        private AlumnusModel context;

        private UnitOfWork unitOfWork { get; set; }

        public BusinessManger()
        {
            unitOfWork = new UnitOfWork(context);
        }

        public void CreateAlumn(Alumnus alumnus)
        {
            unitOfWork.Alumnus.CreateAlumn(alumnus);
        }
        public void CreateEmployee(Employee employee)
        {
            unitOfWork.Employee.CreateEmployee(employee);
        }
        public void CreateActivity(Aktivity aktivity)
        {
            unitOfWork.Activities.CreateActivity(aktivity);
        }
        public void CreateSection(SektionBl sektion)
        {
            unitOfWork.Section.CreateSection(sektion);
        }
        public void CreateProgram(ProgramBL program)
        {
            unitOfWork.Program.CreateProgram(program);
        }
        public bool IsAlumnus(UserBL currentUser)
        {
            return unitOfWork.Alumnus.IsAlumnus(currentUser);
        }
        public bool IsEmployee(UserBL currentUser)
        {
            return unitOfWork.Employee.IsEmployee(currentUser);
        }
        public UserBL GetUser(string Username, string PassWord)
        {
            User x = unitOfWork.User.GetUser(Username, PassWord);

            if (x != null)
                return new UserBL(x);
            else return null;
        }
        public Employee GetEmployee(int PersId)
        {
            return unitOfWork.Employee.GetEmployee(PersId);
        }
        public Section GetSection(int sectionID)
        {
            return unitOfWork.Section.GetSection(sectionID);
        }
        
        
    }
}
