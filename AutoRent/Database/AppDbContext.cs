﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent.Database
{
    class AppDbContext : DbContext
    {
        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<CarEntity> Cars { get; set; }
        public DbSet<CarRent> Rents { get; set; }
        public DbSet<Operator> Operators { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CarRent>()
                .HasRequired(x => x.Client)
                .WithMany(x => x.Rents)
                .WillCascadeOnDelete(false);
        }
    }
}
