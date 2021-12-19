using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        private readonly ShopContext _context;
        private readonly UserManager<User> _userManager;

        public HomeController(ShopContext context,UserManager<User> userManager)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(
                await _context.productSeries
                .Include(x => x.product)
                .Include(x => x.seller)
                .ToListAsync()
                );
        }

        [Authorize(Roles = "User,Admin")]
        public async Task<IActionResult> Buy(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productSeries = await _context.productSeries
                .Include(x => x.product)
                .Include(x => x.seller)
                .FirstOrDefaultAsync(i => i.id == id);
            if (productSeries == null)
            {
                return NotFound();
            }

            ViewBag.productSeries = productSeries;
            return View();
        }

        // POST: ProductSeries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "User,Admin")]
        public async Task<IActionResult> Buy(int ProductId, [Bind("quantity")] Sale sale)
        {
      
            if (ModelState.IsValid)
            {

                sale.productSeries = await _context.productSeries.FindAsync(ProductId);
                sale.user = await _userManager.GetUserAsync(HttpContext.User);
                
                _context.Add(sale);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(sale);
        }

        [Authorize(Roles = "User")]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Send()
        {
            ViewBag.msj = "viewBag";
            ViewData["msj2"] = "viewData";
            TempData["msj3"] = "tempData";

            return RedirectToAction("LookSend");
        }
        public IActionResult LookSend()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = context.Error; // Your exception
            var code = 500; // Internal Server Error by default


            Response.StatusCode = code; // You can use HttpStatusCode enum instead

            return View(new ErrorMVC(exception)); // Your error model
        }

        private bool ProductSeriesExists(int id)
        {
            return _context.productSeries.Any(e => e.id == id);
        }
    }
}
