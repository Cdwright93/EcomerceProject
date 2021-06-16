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
        [Key]
        public int RatingId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public int Rating { get; set; }

        public virtual Product Product { get; set; }
    }
}
