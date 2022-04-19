using DataLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System;
using MyDataModels;
using RestDataService;

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
                var service = new RestData(dbContext);
                return await service.GetCuisines();
            };
        }
        public async Task <List<Convenience>> GetConveniences()
        {
            using (var dbContext = new DataDbContext(_optionsBuilder.Options))
            {
                var service2 = new RestData(dbContext);
                return await service2.GetConveniences();

            }
        }
        public async Task <List<Restaurant>> GetRestaurants()  
        {
            using (var dbContext = new DataDbContext(_optionsBuilder.Options))
            {
                var service3 = new RestData(dbContext);
                return await service3.GetRestaurants();
            }
        }

        public async Task<List<Restaurant>> GetMatches(int priceValue, Convenience convValue, Cuisine cuisValue)
        {
            using (var db = new DataDbContext(_optionsBuilder.Options))
            {
                
                return await db.Restaurants
                    .Select(x => new Restaurant
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Price = x.Price,
                        Convenience = x.Convenience,
                        Cuisine = x.Cuisine,
                        ConvenienceId = x.ConvenienceId,
                        CuisineId = x.CuisineId
                    }).Where(x => x.Price == priceValue && x.Convenience == convValue && x.Cuisine == cuisValue)
                    .OrderBy(x => x.Name).ToListAsync();
            }
        }
    }
}