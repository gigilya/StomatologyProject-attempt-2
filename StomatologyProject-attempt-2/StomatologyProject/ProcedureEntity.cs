namespace StomatologyProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Procedure")]
    public partial class ProcedureEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcedureEntity()
        {
            Entry = new HashSet<EntryEntity>();
        }

        [Key]
        [Column("id_procedure")]
        public long Procedureld { get; set; }

        [Column("id_doctor")]
        public long Doctorld { get; set; }

        [Column("id_assistant")]
        public long Assistantld { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("procedure_description")]
        public string Proceduredescription { get; set; }

        [Column("price")]
        public long Price { get; set; }

        public virtual AssistantEntity Assistant { get; set; }

        public virtual DoctorEntity Doctor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntryEntity> Entry { get; set; }
    }

}
