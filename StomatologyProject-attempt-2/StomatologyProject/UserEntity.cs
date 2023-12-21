namespace StomatologyProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserEntity")]
    public partial class UserEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserEntity()
        {
            Doctor = new HashSet<DoctorEntity>();
            Patient = new HashSet<PatientEntity>();
        }

        [Key]
        public long id_user { get; set; }

        public long id_role { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string login { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorEntity> Doctor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientEntity> Patient { get; set; }

        public virtual RoleEntity Role { get; set; }
    }
}
