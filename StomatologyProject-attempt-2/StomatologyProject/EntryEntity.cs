namespace StomatologyProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EntryEntity")]
    public partial class EntryEntity
    {
        [Key]
        public long id_entry { get; set; }

        public long id_patient { get; set; }

        public long id_procedure { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string date_receipt { get; set; }

        public long status_receipt { get; set; }

        public virtual PatientEntity Patient { get; set; }

        public virtual ProcedureEntity Procedure { get; set; }
    }
}
