using System.Collections.Generic;
using Data_Layer;

namespace Data_Layer.Repositories
{
    public interface IActivitiesRepository
    {
        AlumnusModel AlumnusModel { get; }

        void CreateActivity(Aktivity aktivity);
        void DeleteActivities(Aktivity localaktivity);
        List<Aktivity> GetActivities();
        List<Aktivity> GetActivitiesByAlumnus();
        void UpdateActivity(Aktivity Localaktivty, int aktivityId);
    }
}