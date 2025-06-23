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
    public class BdhPublishersController : Controller
    {
        private readonly Bdhlession09Context _context;

        public BdhPublishersController(Bdhlession09Context context)
        {
            _context = context;
        }

        // GET: BdhPublishers
        public async Task<IActionResult> BdhIndex()
        {
            return View(await _context.Publishers.ToListAsync());
        }

        // GET: BdhPublishers/Details/5
        public async Task<IActionResult> BdhDetails(int? bdhid)
        {
            if (bdhid == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publishers
                .FirstOrDefaultAsync(m => m.PublisherId == bdhid);
            if (publisher == null)
            {
                return NotFound();
            }

            return View(publisher);
        }

        // GET: BdhPublishers/Create
        public IActionResult BdhCreate()
        {
            return View();
        }

        // POST: BdhPublishers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BdhCreate([Bind("PublisherId,PublisherName,Phone,Address")] Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(publisher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(publisher);
        }

        // GET: BdhPublishers/Edit/5
        public async Task<IActionResult> BdhEdit(int? bdhid)
        {
            if (bdhid == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publishers.FindAsync(bdhid);
            if (publisher == null)
            {
                return NotFound();
            }
            return View(publisher);
        }

        // POST: BdhPublishers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BdhEdit(int id, [Bind("PublisherId,PublisherName,Phone,Address")] Publisher publisher)
        {
            if (id != publisher.PublisherId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(publisher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PublisherExists(publisher.PublisherId))
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
            return View(publisher);
        }

        // GET: BdhPublishers/Delete/5
        public async Task<IActionResult> BdhDelete(int? bdhid)
        {
            if (bdhid == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publishers
                .FirstOrDefaultAsync(m => m.PublisherId == bdhid);
            if (publisher == null)
            {
                return NotFound();
            }

            return View(publisher);
        }

        // POST: BdhPublishers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BdhDeleteConfirmed(int id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            if (publisher != null)
            {
                _context.Publishers.Remove(publisher);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PublisherExists(int id)
        {
            return _context.Publishers.Any(e => e.PublisherId == id);
        }
    }
}
