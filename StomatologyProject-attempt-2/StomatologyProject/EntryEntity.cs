namespace StomatologyProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entry")]
    public partial class EntryEntity
    {
        [Key]
        [Column("id_entry")]
        public long Entryld { get; set; }

        [Column("id_patient")]
        public long Patientld { get; set; }

        [Column("id_procedure")]
        public long Procedureld { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("date_receipt")]
        public string Datereceipt { get; set; }

        [Column("status_receipt")]
        public long Statusreceipt { get; set; }

        public virtual ProcedureEntity Procedure { get; set; }

        public virtual PatientEntity Patient { get; set; }
    }
}
