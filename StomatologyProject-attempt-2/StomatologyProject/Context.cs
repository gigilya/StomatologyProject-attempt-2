using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace StomatologyProject
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<AssistantEntity> Assistant { get; set; }
        public virtual DbSet<DoctorEntity> Doctor { get; set; }
        public virtual DbSet<EntryEntity> Entry { get; set; }
        public virtual DbSet<PatientEntity> Patient { get; set; }
        public virtual DbSet<ProcedureEntity> Procedure { get; set; }
        public virtual DbSet<RoleEntity> Role { get; set; }
        public virtual DbSet<SpecializationEntity> Specialization { get; set; }
        public virtual DbSet<UserEntity> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssistantEntity>()
                .HasMany(e => e.Procedure)
                .WithRequired(e => e.Assistant)
                .HasForeignKey(e => e.Assistantld)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DoctorEntity>()
                .HasMany(e => e.Procedure)
                .WithRequired(e => e.Doctor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PatientEntity>()
                .HasMany(e => e.Entry)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProcedureEntity>()
                .HasMany(e => e.Entry)
                .WithRequired(e => e.Procedure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoleEntity>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecializationEntity>()
                .HasMany(e => e.Assistant)
                .WithRequired(e => e.Specialization)
                .HasForeignKey(e => e.Specializationld)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecializationEntity>()
                .HasMany(e => e.Doctor)
                .WithRequired(e => e.Specialization)
                .HasForeignKey(e => e.Specializationld)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserEntity>()
                .HasMany(e => e.Doctor)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserEntity>()
                .HasMany(e => e.Patient)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
