namespace StomatologyProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class PatientEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PatientEntity()
        {
            Entry = new HashSet<EntryEntity>();
        }

        [Key]
        [Column("id_patient")]
        public long Patientld { get; set; }

        [Column("id_user")]
        public long Userld { get; set; }

        [Column("last_name")]
        public string Lastname { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("name")]
        public string Name { get; set; }

        [StringLength(2147483647)]
        [Column("middle_name")]
        public string Middlename { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("gender")]
        public string Gender { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("birthday")]
        public string Birthday { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("address")]
        public string Address { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("contact_info")]
        public string Contactinfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntryEntity> Entry { get; set; }

        public virtual UserEntity User { get; set; }
    }
}
