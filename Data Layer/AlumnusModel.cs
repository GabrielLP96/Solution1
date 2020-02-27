namespace Data_Layer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AlumnusModel : DbContext
    {
        public AlumnusModel()
            : base("name=AlumnusModel")
        {
        }

        public virtual DbSet<Aktivity> Aktivity { get; set; }
        public virtual DbSet<Alumnus> Alumnus { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Program> Program { get; set; }
        public virtual DbSet<Section> Section { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aktivity>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Aktivity>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Alumnus>()
                .HasMany(e => e.Aktivity)
                .WithOptional(e => e.Alumnus)
                .HasForeignKey(e => e.AlumId);

            modelBuilder.Entity<Alumnus>()
                .HasMany(e => e.Program)
                .WithOptional(e => e.Alumnus)
                .HasForeignKey(e => e.AlumId);

            modelBuilder.Entity<Program>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Section>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PersonCode)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PassW)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Alumnus)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.PersonId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Employee)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.PersonId);
        }
    }
}
