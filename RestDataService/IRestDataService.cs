using MyDataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestDataService
{
    public interface IRestDataService
    {
        Task<List<Cuisine>> GetCuisines();
        Task<List<Convenience>> GetConveniences();
        Task<List<Restaurant>> GetRestaurants();
        Task<Restaurant> GetRestaurant(int id);
        Task Add(Restaurant r);

        //Task Edit() working on this edit from restaurant controller

    }
}
