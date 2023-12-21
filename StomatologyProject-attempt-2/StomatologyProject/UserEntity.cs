namespace StomatologyProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class UserEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserEntity()
        {
            Doctor = new HashSet<DoctorEntity>();
            Patient = new HashSet<PatientEntity>();
        }

        [Key]
        [Column("id_user")]
        public long Userld { get; set; }

        [Column("id_role")]
        public long Roleld { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("login")]
        public string Login { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("password")]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorEntity> Doctor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientEntity> Patient { get; set; }

        public virtual RoleEntity Role { get; set; }
    }
}
