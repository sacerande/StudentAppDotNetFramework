namespace StudentApp.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbStudent : DbContext
    {
        public dbStudent()
            : base("name=dbStudent")
        {
        }

        public virtual DbSet<student> student { get; set; }
        public virtual DbSet<subjects> subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<student>()
                .HasMany(e => e.subjects)
                .WithOptional(e => e.student)
                .HasForeignKey(e => e.studid);
        }
    }
}
