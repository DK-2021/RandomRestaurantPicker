using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyDataModels;

namespace DataLibrary
{
    public class DataDbContext : DbContext
    {
        private static IConfigurationRoot _configuration;

        //TODO: Add your data models here
        //Example: Categories:
        //public DbSet<Cusine> Categories { get; set; }
        //public DbSet<Cco> Items { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Cuisine> Cuisines { get; set; }
        public DbSet<Convenience> Conveniences { get; set; }

        public DataDbContext() : base()
        { 
            //intentionally blank
        }

        public DataDbContext(DbContextOptions options)
            : base(options)
        { 
            //intentionally empty
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO 1: If you want to change the database name, find the appsettings.json file
            //      then modify the connection string for MyDataManagerData to set a different
            //      Database name
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                _configuration = builder.Build();
                var cnstr = _configuration.GetConnectionString("MyDataManagerData");
                optionsBuilder.UseSqlServer(cnstr);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //use the fluent api here to define data structures and relationships
            //
            //... [optional] ...

            //example: seed some data:
            

            modelBuilder.Entity<Cuisine>(x =>
            {
                x.HasData(new Cuisine() { Id = 1, Type = "Italian" },
                            new Cuisine() { Id = 2, Type = "American" },
                            new Cuisine() { Id = 3, Type = "Mexican" },
                            new Cuisine() { Id = 4, Type = "Korean"},
                            new Cuisine() { Id = 5, Type = "Chinese"},
                            new Cuisine() { Id = 6, Type = "Unassigned"}
                );
            });

            modelBuilder.Entity<Convenience>(x =>
            {
                x.HasData(new Convenience() { Id = 1, Type = "Sit Down" },
                            new Convenience() { Id = 2, Type = "Take Out" },
                            new Convenience() { Id = 3, Type = "Fast Food" },
                            new Convenience() { Id = 4, Type = "Unassigned"}
                );
            });

            modelBuilder.Entity<Restaurant>(x =>
            {
                x.HasData(new Restaurant() { Id = 1, Name = "Olive Garden", Price=2, ConvenienceId=1, CuisineId=1 },
                            new Restaurant() { Id = 2, Name = "Taco Bell", Price = 1, ConvenienceId = 3, CuisineId = 3 },
                            new Restaurant() { Id = 3, Name = "Ruth's Chriss", Price = 3, ConvenienceId = 1, CuisineId = 2 },
                            new Restaurant() { Id = 4, Name = "Cookout", Price = 1, ConvenienceId = 2, CuisineId = 2 }
                );
            });

           

        }
    }
}