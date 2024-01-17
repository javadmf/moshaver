using Microsoft.AspNetCore.Connections;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using System.Data.Entity;

namespace moshaver.Models
{

    internal class MoshaverDBContext : DbContext
    {
        //Constructor with DbContextOptions and the context class itself
        //public MoshaverDbContext(DbContextOptions<DbContext> options) : base(options)
        //{
        //}
        //Create the DataSet for the Moshaveran

        public MoshaverDBContext() : base("moshaverDB")
        {
            Database.SetInitializer<MoshaverDBContext>(new CreateDatabaseIfNotExists<MoshaverDBContext>());
        }

    public DbSet<Users> Users { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().ToTable("users");
        }
    }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Data Source=ICTB01F07C5027;Initial Catalog=moshaverandb;Integrated Security = true");
        //}

   
    
     
}

