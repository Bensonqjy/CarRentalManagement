﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalManagement1.Server.Configurations.Entities;
using CarRentalManagement1.Server.Models;
using CarRentalManagement1.Shared.Domain;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CarRentalManagement1.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Colour> Colours { get; set; }

        public DbSet<Make> Makes { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.ApplyConfiguration(new ColourSeedConfiguration());
            builder.ApplyConfiguration(new MakeSeedConfiguration());
            builder.ApplyConfiguration(new ModelSeedConfiguration());
        }
    }
}
