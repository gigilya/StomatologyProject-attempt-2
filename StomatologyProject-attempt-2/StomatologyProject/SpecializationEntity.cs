namespace StomatologyProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Specialization")]
    public partial class SpecializationEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpecializationEntity()
        {
            Assistant = new HashSet<AssistantEntity>();
            Doctor = new HashSet<DoctorEntity>();
        }

        [Key]
        [Column("id_specialization")]
        public long Specializationld { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("name")]
        public string Name { get; set; }

        [Column("wages")]
        public long Wages { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("work_schedule")]
        public string Workschedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssistantEntity> Assistant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorEntity> Doctor { get; set; }
    }
}
