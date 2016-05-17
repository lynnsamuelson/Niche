using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NicheTest.Models
{
    public class PatientContext : DbContext
    {
        //This code should connect the Model(s) to the Database
        //DbSet is part of Entity Framework
        public DbSet<Patient> Patient { get; set; }

        //Connects the Object Patient to the Database table
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Patient>()
                .ToTable("Patient")
                .HasKey(c => c.PatientId);
        }
    }
}