namespace StomatologyProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PatientEntity")]
    public partial class PatientEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PatientEntity()
        {
            Entry = new HashSet<EntryEntity>();
        }

        [Key]
        public long id_patient { get; set; }

        public long id_user { get; set; }

        public long last_name { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string name { get; set; }

        [StringLength(2147483647)]
        public string middle_name { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string gender { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string birthday { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string address { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string contact_info { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntryEntity> Entry { get; set; }

        public virtual UserEntity User { get; set; }
    }
}
