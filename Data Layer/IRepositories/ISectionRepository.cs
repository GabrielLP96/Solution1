using System.Collections.Generic;

namespace Data_Layer.IRepositories
{
   public interface ISectionRepository : IRepository<Section>
    {
        AlumnusModel AlumnusModel { get; }

        void CreateSection(Section section);
        Section GetSection(int sectionId);
        List<Section> GetSections();
    }
}