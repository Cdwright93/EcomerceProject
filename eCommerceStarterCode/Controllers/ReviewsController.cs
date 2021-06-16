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
    public class ReviewsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }
    
        [HttpPost]
        public IActionResult Post([FromBody] Reviews value)
        {
            _context.Reviews.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
        [HttpGet("{ProductId}")]
        public IActionResult GetAllReviews(int ProductId)
        {
            var reviews = _context.Reviews.Where(rev => rev.Product.Id == ProductId);

            return Ok(reviews);
        }
    }
}