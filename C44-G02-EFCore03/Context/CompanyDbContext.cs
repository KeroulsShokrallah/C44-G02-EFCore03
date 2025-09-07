using C44_G02_EFCore03.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EFCore03.Context
{
    internal class CompanyDbContext :DbContext
    {
       public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmetEmployeeView> departmetEmployeeView { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        //public DbSet<FullTimeEmploee> FullTimeEmploees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("server = .; Database = CompanyDB; " +
                "Trusted_Connection = true; TrustServerCertificate = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmetEmployeeView>().HasNoKey().ToView("departmetEmployeeView");
            //modelBuilder.Entity<FullTimeEmploee>()
            //    .HasBaseType<Employee>()
            //    .HasDiscriminator<string>("Type Of Employee")
            //    .HasValue<FullTimeEmploee>("FTE");


            //modelBuilder.Entity<PartTimeEmployee>()
            //    .HasBaseType<Employee>()
            //    .HasDiscriminator<string>("Type Of Employee")
            //    .HasValue<PartTimeEmployee>("PTE");
        }
    }
}
