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
    public class CuisinesController : Controller
    {
        private readonly DataDbContext _context;
        private readonly IRestDataService _restData;

        public CuisinesController(DataDbContext context, IRestDataService restData)
        {
            _context = context;
            _restData = restData;
        }

        // GET: Cuisines
        public async Task<IActionResult> Index()
        {
            return View(await _restData.GetCuisines());
        }

        // GET: Cuisines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuisine = await _context.Cuisines
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cuisine == null)
            {
                return NotFound();
            }

            return View(cuisine);
        }

        // GET: Cuisines/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cuisines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type")] Cuisine cuisine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cuisine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cuisine);
        }

        // GET: Cuisines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuisine = await _context.Cuisines.FindAsync(id);
            if (cuisine == null)
            {
                return NotFound();
            }
            return View(cuisine);
        }

        // POST: Cuisines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type")] Cuisine cuisine)
        {
            if (id != cuisine.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cuisine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CuisineExists(cuisine.Id))
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
            return View(cuisine);
        }

        // GET: Cuisines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuisine = await _context.Cuisines
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cuisine == null)
            {
                return NotFound();
            }

            return View(cuisine);
        }

        // POST: Cuisines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cuisine = await _context.Cuisines.FindAsync(id);
            _context.Cuisines.Remove(cuisine);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CuisineExists(int id)
        {
            return _context.Cuisines.Any(e => e.Id == id);
        }
    }
}
