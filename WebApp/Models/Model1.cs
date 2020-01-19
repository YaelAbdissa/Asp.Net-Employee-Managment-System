namespace WebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=HrEntities")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.emp_name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.emp_postition)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.emp_EducLeve)
                .IsUnicode(false);

          
        }
    }
}
