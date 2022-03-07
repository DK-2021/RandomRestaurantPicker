using DataLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System;
using MyDataModels;

namespace MyDataManagerDataOperations
{
    public class DataOperations
    {
        private static IConfigurationRoot _configuration;
        public static DbContextOptionsBuilder<DataDbContext> _optionsBuilder;
        public DataOperations()
        {
            BuildOptions();
        }
        static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<DataDbContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MyDataManagerData"));
        }
        public async Task <List<Cuisine>> GetCuisines()
        {
            using (var dbContext = new DataDbContext(_optionsBuilder.Options))
            {
                try
                {
                    var cuisine = await dbContext.Cuisines.OrderBy(x => x.Type).ToListAsync();
                    return cuisine;
                }
                catch (Exception ex)
                {

                    throw;
                }
            };
        }
        public async Task <List<Convenience>> GetConveniences()
        {
            using (var dbContext = new DataDbContext(_optionsBuilder.Options))
            {
                return await dbContext.Conveniences.OrderBy(x => x.Type).ToListAsync();

            }
        }
        public List<Restaurant> GetRestaurants()  
        {
            using (var dbContext = new DataDbContext(_optionsBuilder.Options))
            {
                return dbContext.Restaurants.OrderBy(x => x.Name).ToList();
            }
        }
    }
}