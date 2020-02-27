using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.IRepositories;

namespace Data_Layer.Repositories
{
    class SectionRepository : Repository<Section>, ISectionRepository
    {
        public SectionRepository(AlumnusModel context) : base(context)
        {
        }

        public void CreateSection(Section section)
        {
            using (var db = new AlumnusModel())
            {
                db.Section.Add(section);
                db.SaveChanges();
            }
        }

        public Section GetSection(int sectionId)
        {
            using (var db = new AlumnusModel())
            {
                return db.Section.OfType<Section>().Where(x => x.SectionId == sectionId).FirstOrDefault();
            }
        }

        public List<Section> GetSections()
        {
            using (var db = new AlumnusModel())
            {
                return db.Section.ToList();
            }
        }

        public AlumnusModel AlumnusModel
        {
            get { return Context as AlumnusModel; }
        }
    }
}
