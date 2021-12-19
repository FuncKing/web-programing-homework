using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Sale
    {
        [Key]
        public int id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int quantity { get; set; }

        public ProductSeries productSeries { get; set; }

        public User user { get; set; }
    }
}
