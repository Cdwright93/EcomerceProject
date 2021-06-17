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
<<<<<<< HEAD
    [Route("api/reviews")]
=======
    [Route("api/products")]
>>>>>>> f9688a5877e8b4e77afc4e085ca654e75a440122
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
<<<<<<< HEAD
        [HttpGet("{Id}")]
        public IActionResult GetAllReviewsbyId(int Id)
        {
            var reviews = _context.Reviews.Where(r => r.Product.Id == Id);
=======
        [HttpGet("{ProductId}")]
        public IActionResult GetAllReviews(int ProductId)
        {
            var reviews = _context.Reviews.Where(rev => rev.Product.Id == ProductId);
>>>>>>> f9688a5877e8b4e77afc4e085ca654e75a440122

            return Ok(reviews);
        }
    }
}