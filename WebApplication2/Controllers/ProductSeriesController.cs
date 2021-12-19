using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductSeriesController : Controller
    {
        private readonly ShopContext _context;

        public ProductSeriesController(ShopContext context)
        {
            _context = context;
        }

        // GET: ProductSeries
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.productSeries.Include(x => x.product).Include(x => x.seller).ToListAsync());
        }

        // GET: ProductSeries/Details/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productSeries = await _context.productSeries
                .FirstOrDefaultAsync(m => m.id == id);
            if (productSeries == null)
            {
                return NotFound();
            }

            return View(productSeries);
        }

        // GET: ProductSeries/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            List<SelectListItem> selectProductListItems = _context.products.Select(a => new SelectListItem
            {
                Text = a.name,
                Value = a.barcode
            }).ToList();
            ViewBag.barcode = selectProductListItems;

            List<SelectListItem> selectSellerListItems = _context.sellers.Select(a => new SelectListItem
            {
                Text = a.name,
                Value = a.id.ToString()
            }).ToList();
            ViewBag.ProductId = selectProductListItems;
            ViewBag.SellerId = selectSellerListItems;
            return View();
        }

        // POST: ProductSeries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(int SellerId,string ProductId,[Bind("id,name,quantity,price,buyTime,cost")] ProductSeries productSeries)
        {

            if (ModelState.IsValid)
            {
                productSeries.product = await _context.products.FirstOrDefaultAsync(m => m.barcode == ProductId);
                productSeries.seller = await _context.sellers.FirstOrDefaultAsync(m => m.id == SellerId);

                _context.Add(productSeries);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(productSeries);
        }

        // GET: ProductSeries/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productSeries = await _context.productSeries.FindAsync(id);
            if (productSeries == null)
            {
                return NotFound();
            }
            return View(productSeries);
        }

        // POST: ProductSeries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,quantity,price,buyTime,cost")] ProductSeries productSeries)
        {
            if (id != productSeries.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productSeries);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductSeriesExists(productSeries.id))
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
            return View(productSeries);
        }

        // GET: ProductSeries/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productSeries = await _context.productSeries
                .FirstOrDefaultAsync(m => m.id == id);
            if (productSeries == null)
            {
                return NotFound();
            }

            return View(productSeries);
        }

        // POST: ProductSeries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productSeries = await _context.productSeries.FindAsync(id);
            _context.productSeries.Remove(productSeries);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductSeriesExists(int id)
        {
            return _context.productSeries.Any(e => e.id == id);
        }
    }
}
