using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/shoppingcart")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private Data.ApplicationDbContext _context;

        public ShoppingCartController(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{Id}")]
        public IActionResult GetObjectsFromCart(string Id)
        {
            var items = _context.ShoppingCarts.Where(i => i.UserId == Id);
            return StatusCode(200, items);
        }
        [HttpPost("{userId}/{productId}")]
        public IActionResult Post([FromBody] ShoppingCart value)
        {
            _context.ShoppingCarts.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}