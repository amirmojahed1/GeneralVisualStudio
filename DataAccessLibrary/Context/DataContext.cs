using DataAccessLibrary.Context;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

//namespace DataAccessLibrary.Context
//{
//    public class DataContext:DbContext
//    {
//        public DataContext(DbContextOptions options) : base(options)
//        {
//        }

//        public DbSet<PageGroup> PageGroups { get; set; }
//        public DbSet<Page> Pages { get; set; }

//        public DbSet<PageComment> PageComments { get; set; }

//        public DbSet<InformationForm> InformationForms { get; set; }
//    }
//}



//namespace DataAccessLibrary.Context
//{
//    public class DataContext : DbContext
//    {
//        public DataContext(DbContextOptions<DataContext> options) : base(options)
//        {
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);

//            // Automatically register all models in the "Models" namespace
//            var entityTypes = Assembly.GetExecutingAssembly()
//                .GetTypes()
//                .Where(t => t.Namespace == "DataAccessLibrary.Models" && t.IsClass);

//            foreach (var type in entityTypes)
//            {
//                modelBuilder.Entity(type);
//            }
//        }
//    }
//}


namespace DataAccessLibrary.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    // Automatically register all models in the "Models" namespace
    var entityTypes = Assembly.GetExecutingAssembly()
        .GetTypes()
        .Where(t => t.Namespace == "DataAccessLibrary.Models" && t.IsClass);

    foreach (var type in entityTypes)
    {
        modelBuilder.Entity(type);
    }

    // Apply default delete behavior for all foreign keys globally
    foreach (var entityType in modelBuilder.Model.GetEntityTypes())
    {
        var entity = modelBuilder.Entity(entityType.ClrType);

        foreach (var foreignKey in entityType.GetForeignKeys())
        {
            foreignKey.DeleteBehavior = DeleteBehavior.Restrict; // Prevent cascade issues
        }
    }
}

    }

}







//namespace DataAccessLibrary.Context
//{
//    public class DataContext : DbContext
//    {
//        public DataContext(DbContextOptions<DataContext> options) : base(options)
//        {
//        }
//        public DbSet<Academic> Academics { get; set; }
//        public DbSet<College> Colleges { get; set; }

//        public DbSet<Course> Courses { get; set; }

//        public DbSet<Coursedate> Coursedates { get; set; }
//        public DbSet<Employ> Employs { get; set; }

//        public DbSet<Ostad> Ostads { get; set; }

//        public DbSet<Roles> Roless { get; set; }
//        public DbSet<AdminLogin> AdminLogins { get; set; }

//        public DbSet<OstadCourse> OstadCourses { get; set; }

//    }
//}

