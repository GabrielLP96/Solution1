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
            User x = unitOfWork.User.GetUsers(Username, PassWord);

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
        public Alumnus GetAlumn(int PersID)
        {
            return unitOfWork.Alumnus.GetAlumnus(PersID);
        }

        public List<ActivityBL> GetActivities()
        {
            List<ActivityBL> activities = new List<ActivityBL>();
            foreach (Data_Layer.Aktivity aktivity in unitOfWork.Activities.GetActivities())
                activities.Add(ActivityBL.Convert(aktivity));

            return activities;
                           
        }
        public List<SektionBl> GetSektions()
        {
            List<SektionBl> sektions = new List<SektionBl>();
            foreach (Data_Layer.Section section in unitOfWork.Section.GetSections())
                sektions.Add(SektionBl.Convert(section));

            return sektions;
        }

        public List<AlumnusBL> GetAlumns()
        {
            List<AlumnusBL> alumns = new List<AlumnusBL>();
            foreach (Data_Layer.Alumnus alumnus in unitOfWork.Alumnus.GetAlumns())
                alumns.Add(AlumnusBL)                 
        }
        public List<ProgramBL> GetPrograms()
        {
            List<ProgramBL> programs = new List<ProgramBL>();
            foreach (Data_Layer.Program program in unitOfWork.Program.GetProgram())
                programs.Add(ProgramBL.Convert(program));

            return programs;
        }

        public void UpdateActivity (ActivityBL activity, int AktivityId)
        {
            unitOfWork.Activities.UpdateActivity(activity, AktivityId);
        }

        public void DeleteActivity (ActivityBL activity)
        {
            unitOfWork.Activities.DeleteActivities(activity);
        }
        
        
    }
}
