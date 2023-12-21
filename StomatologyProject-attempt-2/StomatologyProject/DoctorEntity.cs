namespace StomatologyProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoctorEntity")]
    public partial class DoctorEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoctorEntity()
        {
            Procedure = new HashSet<ProcedureEntity>();
        }

        [Key]
        public long id_doctor { get; set; }

        public long id_user { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string last_name { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string name { get; set; }

        [StringLength(2147483647)]
        public string middle_name { get; set; }

        public long id_specialization { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string contact_info { get; set; }

        public virtual UserEntity User { get; set; }

        public virtual SpecializationEntity Specialization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcedureEntity> Procedure { get; set; }
    }
}