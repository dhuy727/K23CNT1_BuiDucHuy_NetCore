using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using bdhlession09_EF.Models;

namespace bdhlession09_EF.Controllers
{
    public class BdhCategoriesController : Controller
    {
        private readonly Bdhlession09Context _context;

        public BdhCategoriesController(Bdhlession09Context context)
        {
            _context = context;
        }

        // GET: BdhCategories
        public async Task<IActionResult> BdhIndex(string keyword)
        {
            var bdhCatagories = await _context.Categories.ToListAsync();
            if (string.IsNullOrWhiteSpace(keyword))     
            {
                bdhCatagories =  bdhCatagories.Where(x=>x.CategoryName.Contains(keyword)).ToList();
            }
            return View(bdhCatagories);
        }

        // GET: BdhCategories/Details/5
        public async Task<IActionResult> BdhDetails(int? bdhid)
        {
            if (bdhid == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == bdhid);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: BdhCategories/Create
        public IActionResult BdhCreate()
        {
            var bdhCatagories = new Category();
            return View(bdhCatagories);
        }

        // POST: BdhCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BdhCreate([Bind("CategoryId,CategoryName")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(BdhIndex));
            }
            return View(category);
        }

        // GET: BdhCategories/Edit/5
        public async Task<IActionResult> BdhEdit(int? bdhid)
        {
            if (bdhid == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(bdhid);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: BdhCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BdhEdit(int bdhid, [Bind("CategoryId,CategoryName")] Category category)
        {
            if (bdhid != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(BdhIndex));
            }
            return View(category);
        }

        // GET: BdhCategories/BdhDelete/5
        public async Task<IActionResult> BdhDelete(int? bdhid)
        {
            if (bdhid == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == bdhid);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: BdhCategories/BdhDelete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BdhDeleteConfirmed(int bdhid)
        {
            var category = await _context.Categories.FindAsync(bdhid);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(BdhIndex));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }
    }
}
