<<<<<<< HEAD
using eCommerceStarterCode.Data;
=======
﻿using eCommerceStarterCode.Data;
>>>>>>> f9688a5877e8b4e77afc4e085ca654e75a440122
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
    [Route("api/ratings")]
=======
    [Route("api/products")]
>>>>>>> f9688a5877e8b4e77afc4e085ca654e75a440122
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public RatingsController(ApplicationDbContext context)
        {
            _context = context;
        }
<<<<<<< HEAD

=======
 
>>>>>>> f9688a5877e8b4e77afc4e085ca654e75a440122
        [HttpPost]
        public IActionResult Post([FromBody] Ratings value)
        {
            _context.Ratings.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

<<<<<<< HEAD
        [HttpGet("{Id}")]
        public IActionResult GetAllRatings(int Id)
        {
            var ratings = _context.Ratings.Where(rat => rat.Product.Id == Id);
=======
        [HttpGet("{ProductId}")]
        public IActionResult GetAllRatings(int ProductId)
        {
            var reviews = _context.Reviews.Where(rat => rat.Product.Id == ProductId);
>>>>>>> f9688a5877e8b4e77afc4e085ca654e75a440122

            return Ok(reviews);
        }

    }
<<<<<<< HEAD
}
=======
}
>>>>>>> f9688a5877e8b4e77afc4e085ca654e75a440122
