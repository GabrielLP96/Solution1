using System.Collections.Generic;

namespace Data_Layer.Repositories
{
    interface ISectionRepository
    {
        AlumnusModel AlumnusModel { get; }

        void CreateSection(Section section);
        Section GetSection(int sectionId);
        List<Section> GetSections();
    }
}