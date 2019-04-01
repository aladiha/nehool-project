﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;


namespace WebApplication2.DAL
{
    public class ProjectsDal : DbContext
        {
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
               {
                     base.OnModelCreating(modelBuilder);
                     modelBuilder.Entity<Project>().ToTable("Projects");
               }

            public DbSet<Project> projects { get; set; }

        }
}