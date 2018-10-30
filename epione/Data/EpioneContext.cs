using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNet.Identity.EntityFramework;
using Data.MyConventions;

namespace Data
{
    public class EpioneContext : DbContext
    //: IdentityDbContext<User>
    {
        public EpioneContext() : base("Name=EpioneDB")
        {
            //   Database.SetInitializer(new ContexInit());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Disponibility> Disponibilities { get; set; }

        public DbSet<Report> Reports { get; set; }
        public DbSet<Treatement> Treatements { get; set; }
        public DbSet<Step> Steps { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Ajouter les convention
            modelBuilder.Conventions.Add(new DateTimeConvention());


            //pour enlever les conventions
            //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
        }

       



    }
}

