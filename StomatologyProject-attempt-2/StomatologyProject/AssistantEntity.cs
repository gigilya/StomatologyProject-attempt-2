namespace StomatologyProject
{
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

    [Table("Assistant")]
    public partial class AssistantEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssistantEntity()
        {
            Procedure = new HashSet<ProcedureEntity>();
        }

        [Key]
        [Column("id_assistant")]
        public long Assistantld { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("last_name")]
        public string Lastname { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("name")]
        public string Name { get; set; }

        [StringLength(2147483647)]
        [Column("middle_name")]
        public string Middlename { get; set; }

        [Column("id_specialization")]
        public long Specializationld { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("contact_info")]
        public string Contactinfo { get; set; }

        public virtual SpecializationEntity Specialization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcedureEntity> Procedure { get; set; }
    }
}
