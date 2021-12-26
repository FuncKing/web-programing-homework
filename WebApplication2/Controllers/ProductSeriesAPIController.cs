using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSeriesAPIController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductSeriesAPIController(ShopContext context)
        {
            _context = context;
        }

        // GET: api/ProductSeriesAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductSeries>>> Index()
        {
            return
                await _context.productSeries
                .Include(x => x.product)
                .Include(x => x.seller)
                .ToListAsync();
              
        }

        // GET: api/ProductSeriesAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductSeries>> GetProductSeries(int id)
        {
            var productSeries = await _context.productSeries.FindAsync(id);

            if (productSeries == null)
            {
                return NotFound();
            }

            return productSeries;
        }

        // PUT: api/ProductSeriesAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductSeries(int id, ProductSeries productSeries)
        {
            if (id != productSeries.id)
            {
                return BadRequest();
            }

            _context.Entry(productSeries).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductSeriesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProductSeriesAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductSeries>> PostProductSeries(ProductSeries productSeries)
        {
            _context.productSeries.Add(productSeries);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductSeries", new { id = productSeries.id }, productSeries);
        }

        // DELETE: api/ProductSeriesAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductSeries(int id)
        {
            var productSeries = await _context.productSeries.FindAsync(id);
            if (productSeries == null)
            {
                return NotFound();
            }

            _context.productSeries.Remove(productSeries);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductSeriesExists(int id)
        {
            return _context.productSeries.Any(e => e.id == id);
        }
    }
}
