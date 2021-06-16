using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public string Comment { get; set; }

        public virtual Product Product { get; set; }
    }
}
