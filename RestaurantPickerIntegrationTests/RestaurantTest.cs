using DataLibrary;
using Microsoft.EntityFrameworkCore;
using RestDataService;
using Xunit;
using System.Threading.Tasks;
using Shouldly;
using System.Collections.Generic;
using MyDataModels;
using System;

namespace RestaurantPickerIntegrationTests
{
    public class RestaurantTest
    {
        private IRestDataService _service;
        DbContextOptions<DataDbContext> _options;

        public RestaurantTest()
        {

        }
        private void SetUpOptions()
        {
            _options = new DbContextOptionsBuilder<DataDbContext>().UseInMemoryDatabase(databaseName: "RestaurantManagerWebDB").Options;
        }
        private void BuildDefaults()
        {
            using (var context = new DataDbContext(_options))
            {
                var existingRestaraunts = Task.Run(() => context.Restaurants.ToListAsync()).Result;
                if(existingRestaraunts == null || existingRestaraunts.Count < 10)
                {
                    var restaraunts = GetRestarauntsTestData();
                    context.Restaurants.AddRange(restaraunts);
                    context.SaveChanges();
                }
            }
        }
        private List<Restaurant> GetRestarauntsTestData()
        {
            return new List<Restaurant>()
            {
                 new Restaurant() { Id = 1, Name = "Taco Bell", Price = 1, CuisineId = 1, ConvenienceId = 3},
                 new Restaurant() { Id = 2, Name = "Olive Garden", Price = 2, CuisineId = 1, ConvenienceId = 1},
                 new Restaurant() { Id = 3, Name = "Cookout", Price = 1, CuisineId = 2, ConvenienceId = 2}
            };
        }
        public async Task TestGetAllRestaraunts(string name, int Id, int Price, int CuisineId, int Convenience)
        {
            using (var context = new DataDbContext(_options))
            {
                _service = new RestData(context);
                var restaraunts = await _service.GetRestaurants();
                restaraunts[Id].Name.ShouldBe(name, StringCompareShould.IgnoreCase);
            }
        }
        [Theory]
        [InlineData("Taco Bell", 1)]
        [InlineData("Cookout", 3)]
        public async Task TestGetOneRest(string name, int Id)
        {
            using (var context = new DataDbContext(_options))
            {
                _service = new RestData(context);
                var restaraunt = await _service.GetRestaurant(Id);
                restaraunt.Name.ShouldBe(name, StringCompareShould.IgnoreCase);
            }
        }
    }
}