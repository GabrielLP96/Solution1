using System.Collections.Generic;


namespace Data_Layer.IRepositories
{
    public interface IActivitiesRepository : IRepository<Aktivity>
    {
        AlumnusModel AlumnusModel { get; }

        void CreateActivity(Aktivity aktivity);
        void DeleteActivities(Aktivity localaktivity);
        List<Aktivity> GetActivities();
        List<Aktivity> GetActivitiesByAlumnus();
        void UpdateActivity(Aktivity Localaktivty, int aktivityId);
    }
}