using AutoRia.Core.Entities.Site;
using AutoRia.Core.Entities.User;
using AutoRia.Core.Entities.CarsInfo;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoRia.Infrastructure.Initializers;

namespace AutoRia.Infrastructure.Context
{
    internal class AppDbContext:IdentityDbContext
    {
        public AppDbContext() : base()
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PostsImg>()
                .HasOne(ii => ii.Post)
                .WithMany(i => i.Imgs)
                .HasForeignKey(i => i.PostId);

            builder.Entity<Post>()
                .Property(p => p.UserId)
                .ValueGeneratedOnAdd();
            
            base.OnModelCreating(builder);
            builder.SeedCarInfo();
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostsImg> Images { get; set; }

        //////////Cars Info
        ///
        public DbSet<Accident> Accidents { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<GraduationYear> GraduationYears { get; set; }
        public DbSet<Mileage> Mileages { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<ProducingCountry> ProducingCountrys { get; set; }
        public DbSet<Sity> Sities { get; set; }
        public DbSet<TypeCar> Types { get; set; }
    }
}
