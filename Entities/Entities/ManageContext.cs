using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities.Entities
{
    public class ManageContext : DbContext
    {
        public ManageContext(DbContextOptions<ManageContext> options) : base(options)
        {

        }
        public ManageContext()
        {

        }
        public virtual DbSet<User> Users { set; get; }
        public virtual DbSet<Employee> Employees { set; get; }
        public virtual DbSet<Reward> Rewards { set; get; }
        public virtual DbSet<Discipline> Disciplines { set; get; }
        public virtual DbSet<EmployeeSalary> EmployeeSalaries { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users").HasKey(u => u.ID);
            modelBuilder.Entity<Reward>().ToTable("Rewards").HasKey(u => u.ID);
            modelBuilder.Entity<Discipline>().ToTable("Disciplines").HasKey(u => u.ID);
            modelBuilder.Entity<Employee>().ToTable("Employees").HasKey(u => u.ID);
            modelBuilder.Entity<EmployeeSalary>().ToTable("EmployeeSalary").HasKey(u => u.ID);
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    ID = 1,
                    Username = "admin",
                    Password = "1",
                    Name = "Dương",
                    Address = "a",
                    Phone = "123",
                    Email = "abc",
                    CreatedDate = DateTime.Now,
                    BirthDay = DateTime.Now,
                    UserType = 1,
                    Sex = true,
                    Status = true,
                }
                );
            modelBuilder.Entity<Employee>()
                .HasOne<User>(e => e.User)
                .WithMany(u => u.Employees)
                .HasForeignKey(e => e.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EmployeeSalary>()
                .HasOne<Employee>(e => e.Employee)
                .WithMany(e => e.EmployeeSalaries)
                .HasForeignKey(e => e.IDEmployee)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EmployeeSalary>()
                .HasOne<User>(e => e.User)
                .WithMany(u => u.EmployeeSalaries)
                .HasForeignKey(e => e.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Reward>()
                .HasOne<Employee>(r => r.Employee)
                .WithMany(e => e.Rewards)
                .HasForeignKey(r => r.IDEmployee)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Reward>()
                .HasOne<User>(r => r.User)
                .WithMany(u => u.Rewards)
                .HasForeignKey(r => r.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Discipline>()
                .HasOne<User>(d => d.User)
                .WithMany(u => u.Disciplines)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Discipline>()
                .HasOne<Employee>(d => d.Employee)
                .WithMany(e => e.Disciplines)
                .HasForeignKey(d => d.IDEmployee)
                .OnDelete(DeleteBehavior.Restrict);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //refer: https://docs.microsoft.com/en-us/ef/core/querying/related-data#lazy-loading
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.EnableSensitiveDataLogging();
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
                var connectionString = configuration.GetConnectionString("ManageDb");
                //refer at https://docs.microsoft.com/en-us/ef/core/querying/related-data#include-on-derived-types
                //pacakge: Microsoft.EntityFrameworkCore.SqlServer
                optionsBuilder.UseSqlServer(connectionString).ConfigureWarnings(warning => warning.Throw());
            }
        }
    }
}
