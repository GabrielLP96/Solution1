namespace Data_Layer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Section")]
    public partial class Section
    {
        public int SectionId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? EmployeeId { get; set; }

        public int? ProgramId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Program Program { get; set; }
    }
}
