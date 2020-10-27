using Data.Configurations;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
   public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CardsConfiguration());
            builder.ApplyConfiguration(new FirstConfiguration());
            builder.ApplyConfiguration(new FitnessConfiguration());
            builder.ApplyConfiguration(new PricingConfiguration());
            builder.ApplyConfiguration(new ScheduleConfiguration());
            builder.ApplyConfiguration(new ServicesConfiguration());
            builder.ApplyConfiguration(new SliderConfiguration());
            builder.ApplyConfiguration(new TeamConfiguration());
        }
        public DbSet<Cards> Cardss { get; set; }
        public DbSet<First> Firsts { get; set; }
        public DbSet<Fitness> Fitnesss { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Services> Servicess { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
