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
    public class RatingsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public RatingsController(ApplicationDbContext context)
        {
            _context = context;
        }
 
        [HttpPost]
        public IActionResult Post([FromBody] Ratings value)
        {
            _context.Ratings.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        [HttpGet("{ProductId}")]
        public IActionResult GetAllRatings(int ProductId)
        {
            var reviews = _context.Reviews.Where(rat => rat.Product.Id == ProductId);

            return Ok(reviews);
        }

    }
}