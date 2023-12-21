namespace StomatologyProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpecializationEntity")]
    public partial class SpecializationEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpecializationEntity()
        {
            Assistant = new HashSet<AssistantEntity>();
            Doctor = new HashSet<DoctorEntity>();
        }

        [Key]
        public long id_specialization { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string name { get; set; }

        public long wages { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string work_schedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssistantEntity> Assistant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorEntity> Doctor { get; set; }
    }
}
