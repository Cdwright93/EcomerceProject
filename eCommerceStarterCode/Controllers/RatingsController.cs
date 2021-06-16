<<<<<<< HEAD
﻿using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Http;
=======
﻿using Microsoft.AspNetCore.Http;
>>>>>>> 9ead288e2ddab59b68d6e108409357b8a5796afb
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System.Security.Claims;
=======
>>>>>>> 9ead288e2ddab59b68d6e108409357b8a5796afb
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
<<<<<<< HEAD
    [Route("api/shoppingcart/ratings")]
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
        [HttpGet("Rating")]
        public IActionResult GetAllRatings()
        {
            var ratings = _context.Ratings;

            return Ok(ratings);
        }
    }
}
=======
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
    }
}
>>>>>>> 9ead288e2ddab59b68d6e108409357b8a5796afb
