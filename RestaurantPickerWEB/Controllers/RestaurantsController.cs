#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLibrary;
using MyDataModels;
using RestDataService;

namespace RestaurantPickerWEB.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly DataDbContext _context;
        private readonly IRestDataService _restData;

        public RestaurantsController(DataDbContext context, IRestDataService restData)
        {
            _context = context;
            _restData = restData;
        }

        // GET: Restaurants
        public async Task<IActionResult> Index() 
        {
            return View(await _restData.GetRestaurants());
        }

        // GET: Restaurants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var restaurant = await _restData.GetRestaurant((int)id);
            if (restaurant == null)
            {
                return NotFound();
            }
            return View(restaurant);
        }

        // GET: Restaurants/Create
        public IActionResult Create()
        {
            ViewData["ConvenienceId"] = new SelectList(_context.Conveniences, "Id", "Type");
            ViewData["CuisineId"] = new SelectList(_context.Cuisines, "Id", "Type");
            return View();
        }

        // POST: Restaurants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,CuisineId,ConvenienceId")] Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                //await _context.SaveChangesAsync();
                await _restData.Add(restaurant);
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConvenienceId"] = new SelectList(_context.Conveniences, "Id", "Type", restaurant.ConvenienceId);
            ViewData["CuisineId"] = new SelectList(_context.Cuisines, "Id", "Type", restaurant.CuisineId);
            return View(restaurant);
        }

        // GET: Restaurants/Edit/5      //RIGHT HERE
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant == null)
            {
                return NotFound();
            }
            ViewData["ConvenienceId"] = new SelectList(_context.Conveniences, "Id", "Type", restaurant.ConvenienceId);
            ViewData["CuisineId"] = new SelectList(_context.Cuisines, "Id", "Type", restaurant.CuisineId);
            return View(restaurant);
        }

        // POST: Restaurants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,CuisineId,ConvenienceId")] Restaurant restaurant)
        {
            if (id != restaurant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restaurant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestaurantExists(restaurant.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConvenienceId"] = new SelectList(_context.Conveniences, "Id", "Type", restaurant.ConvenienceId);
            ViewData["CuisineId"] = new SelectList(_context.Cuisines, "Id", "Type", restaurant.CuisineId);
            return View(restaurant);
        }

        // GET: Restaurants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurants
                .Include(r => r.Convenience)
                .Include(r => r.Cuisine)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (restaurant == null)
            {
                return NotFound();
            }

            return View(restaurant);
        }

        // POST: Restaurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restaurant = await _context.Restaurants.FindAsync(id);
            _context.Restaurants.Remove(restaurant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RestaurantExists(int id)
        {
            return _context.Restaurants.Any(e => e.Id == id);
        }
    }
}
