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

        public virtual DbSet<Assistant> Assistant { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Entry> Entry { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Procedure> Procedure { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Specialization> Specialization { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assistant>()
                .HasMany(e => e.Procedure)
                .WithRequired(e => e.Assistant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Procedure)
                .WithRequired(e => e.Doctor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Entry)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Procedure>()
                .HasMany(e => e.Entry)
                .WithRequired(e => e.Procedure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Specialization>()
                .HasMany(e => e.Assistant)
                .WithRequired(e => e.Specialization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Specialization>()
                .HasMany(e => e.Doctor)
                .WithRequired(e => e.Specialization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Doctor)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Patient)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
