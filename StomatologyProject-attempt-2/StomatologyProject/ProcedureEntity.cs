namespace StomatologyProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcedureEntity")]
    public partial class ProcedureEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcedureEntity()
        {
            Entry = new HashSet<EntryEntity>();
        }

        [Key]
        public long id_procedure { get; set; }

        public long id_doctor { get; set; }

        public long id_assistant { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string procedure_description { get; set; }

        public long price { get; set; }

        public virtual AssistantEntity Assistant { get; set; }

        public virtual DoctorEntity Doctor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntryEntity> Entry { get; set; }
    }
}
