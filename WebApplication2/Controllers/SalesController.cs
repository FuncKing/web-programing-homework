using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class SalesController : Controller
    {
        private readonly ShopContext _context;
        private readonly UserManager<User> _userManager;

        public SalesController(ShopContext context, UserManager<User> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: Sales
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index(
            [FromQuery(Name = "productSeriesId")] int? productSeriesId,
            [FromQuery(Name = "barcode")] string? barcode
        )
        {
            if (barcode != null)
            {
                return View(await _context.sales
                    .Where(s => s.productSeries.product.barcode == barcode)
                    .Include(x => x.productSeries)
                        .ThenInclude(x => x.product)
                    .Include(x => x.productSeries)
                        .ThenInclude(x => x.seller)
                    .OrderByDescending(x => x.dateTime)
                    .ToListAsync());
            }

            if (productSeriesId != null)
            {
                return View(await _context.sales
                .Where(s => s.productSeries.id == productSeriesId)
                .Include(x => x.productSeries)
                .ThenInclude(x => x.product)
                .Include(x => x.productSeries)
                    .ThenInclude(x => x.seller)
                .OrderByDescending(x => x.dateTime)
                .ToListAsync());
            }

            return View(await _context.sales
                .Include(x => x.productSeries)
                    .ThenInclude(x => x.product)
                .Include(x => x.productSeries)
                    .ThenInclude(x => x.seller)
                .OrderByDescending(x => x.dateTime)
                .ToListAsync());
        }

       
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> UserHistory()
        {
            User user = await _userManager.GetUserAsync(HttpContext.User);
                            
                
            var sale = await _context.sales.Where(s => s.user == user)
                .Include(x => x.productSeries)
                    .ThenInclude(x =>x.product)
                .Include(x => x.productSeries)
                    .ThenInclude(x => x.seller)
                .OrderByDescending(x=>x.dateTime)
                .ToListAsync();

            if (sale == null)
            {
                return NotFound();
            }

            return View(sale);
        }

        // GET: Sales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sale = await _context.sales
                .FirstOrDefaultAsync(m => m.id == id);
            if (sale == null)
            {
                return NotFound();
            }

            return View(sale);
        }

        // GET: Sales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,quantity")] Sale sale)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sale);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sale);
        }

        // GET: Sales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sale = await _context.sales.FindAsync(id);
            if (sale == null)
            {
                return NotFound();
            }
            return View(sale);
        }

        // POST: Sales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,quntity,price")] Sale sale)
        {
            if (id != sale.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sale);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaleExists(sale.id))
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
            return View(sale);
        }

        // GET: Sales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sale = await _context.sales
                .FirstOrDefaultAsync(m => m.id == id);
            if (sale == null)
            {
                return NotFound();
            }

            return View(sale);
        }

        // POST: Sales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sale = await _context.sales.FindAsync(id);
            _context.sales.Remove(sale);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaleExists(int id)
        {
            return _context.sales.Any(e => e.id == id);
        }
    }
}
