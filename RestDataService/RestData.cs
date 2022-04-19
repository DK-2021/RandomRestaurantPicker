using DataLibrary;
using Microsoft.EntityFrameworkCore;
using MyDataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RestDataService
{
    public class RestData : IRestDataService
    {
        
        private readonly DataDbContext _context;
        public RestData(DataDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cuisine>> GetCuisines()
        {
            try
            {
                var cuisine = await _context.Cuisines.OrderBy(x => x.Type).AsNoTracking().ToListAsync();
                return cuisine;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<List<Convenience>> GetConveniences()
        {
            try
            {
                var Convenience = await _context.Conveniences.OrderBy(x => x.Type).AsNoTracking().ToListAsync();
                return Convenience;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<Restaurant>> GetRestaurants()
        {
            try
            {
                var Restaurant = await _context.Restaurants.OrderBy(x => x.Name).AsNoTracking().ToListAsync(); ;
                return Restaurant;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Restaurant> GetRestaurant(int id)
        {
            try
            {
                var restaurant = await _context.Restaurants
                    .Include(r => r.Convenience)
                    .Include(r => r.Cuisine)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(m => m.Id == id);
                return restaurant;
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
        public async Task Add(Restaurant r)
        {
           await _context.Restaurants.AddAsync(r);
            await _context.SaveChangesAsync();

        }
    }
}