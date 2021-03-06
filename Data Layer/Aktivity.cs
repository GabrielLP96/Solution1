namespace Data_Layer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aktivity")]
    public partial class Aktivity
    {
        public int AktivityId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool? Choose { get; set; }

        public int? AlumId { get; set; }

        public int? EmployeeId { get; set; }

        public virtual Alumnus Alumnus { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
