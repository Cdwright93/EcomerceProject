 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Ratings
    {
        [Key, ForeignKey("Product")]
        public int ProductId { get; set; }
        public double Rating { get; set; }

        public virtual Product Product { get; set; }
    }
}
