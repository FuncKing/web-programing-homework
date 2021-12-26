using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
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
        public async Task<ActionResult<string>> Index()
        {

            List<ProductSeries> res = await _context.productSeries
                .Include(x => x.product)
                .Include(x => x.seller)
                .ToListAsync();
            return JsonSerializer.Serialize(res);

              
        }

    }
}
