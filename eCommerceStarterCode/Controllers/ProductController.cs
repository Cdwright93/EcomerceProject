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
        [HttpPost]
        public IActionResult Post([FromBody] Product value)
        {
            _context.Products.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
        // <baseurl>/api/products/id
        [HttpGet("{id}")]
        public IActionResult GetCurrentProduct(int id)
        {
            var product = _context.Products.Where(p => p.Id == id).SingleOrDefault();

            return Ok(product);
        }
        [HttpGet("Product")]
        public IActionResult GetAllProduct()
        {
            var products = _context.Products;

            return Ok(products);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Ratings value)
        {
            _context.Ratings.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
        [HttpGet("{id}")]
        public IActionResult GetAllRatings(int id)
        {
            var ratings = _context.Ratings.Where(rate => rate.Product.Id == id);

            return Ok(ratings);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Reviews value)
        {
            _context.Reviews.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
        [HttpGet("{id}")]
        public IActionResult GetAllReviews(int id)
        {
            var reviews = _context.Reviews.Where(rev => rev.Product.Id == id);

            return Ok(reviews);
        }
    }
}