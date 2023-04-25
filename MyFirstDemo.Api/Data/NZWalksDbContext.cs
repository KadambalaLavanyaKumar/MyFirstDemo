using Microsoft.EntityFrameworkCore;
using MyFirstDemo.Api.Models.Domain;

namespace MyFirstDemo.Api.Data
{
    public class NZWalksDbContext: DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions):base(dbContextOptions) 
        {
            
        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id=Guid.Parse("3e1d541b-a205-429e-bb56-f50cecb2c9df"),
                    Name="Easy"
                },
                 new Difficulty()
                {
                    Id=Guid.Parse("17b5b9e7-cf76-49a3-9f62-eba81363082b"),
                    Name="Medium"
                },
                   new Difficulty()
                {
                    Id=Guid.Parse("2ae1794c-360e-4365-bd1d-3509875e9c6e"),
                    Name="Hard"
                }
            };
            //seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            //Seed data for region
            var regions = new List<Region>()
            {
                new Region()
                {
                    Id=Guid.Parse("78f28f34-abd5-4686-8a7b-fba4ce2fc8e4"),
                    Name="Auckland",
                    Code="AKL",
                    RegionImageUrl="Auckland.jpg"
                },
                  new Region()
                {
                    Id=Guid.Parse("6457b92f-6269-48ed-88e6-8740ceccb5c2"),
                    Name="Bay of Plenty",
                    Code="BOP",
                    RegionImageUrl=null
                },
                    new Region()
                {
                    Id=Guid.Parse("fea2520a-c78a-4b40-8b28-c6b1f11a2331"),
                    Name="Wellington",
                    Code="WGN",
                    RegionImageUrl=null
                },
                         new Region()
                {
                    Id=Guid.Parse("2ea3adbf-201a-4019-8726-44e873309375"),
                    Name="SouthLand",
                    Code="STL",
                    RegionImageUrl="SouthLand.png"
                },
            };
            modelBuilder.Entity<Region>().HasData(regions);
        }

    }
}
