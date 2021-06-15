using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        // <baseurl>/api/examples/user
        [HttpGet("product")]
        public IActionResult GetCurrentProduct()
        {
            var productId = Product.FindFirstValue("Id");
            var product = _context.Products.Find(productId);

            return Ok(product);
        }
    }
}