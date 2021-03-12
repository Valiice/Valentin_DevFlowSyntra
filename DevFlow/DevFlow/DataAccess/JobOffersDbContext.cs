using DevFlow.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFlow.DataAccess
{
    public class JobOffersDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<JobOffer> JobOffers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
             => options.UseSqlite("Data Source=JobOfferSite.db");
    }
}
