using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Product
    {
        [Key]
        public string barcode { get; set; }

        [Required]
        public string weight { get; set; }

        public string description { get; set; }

        [Required]
        public string name {get; set;}

        [Required]
        public string imagePath { get; set; }

        public List<ProductSeries> productSeries { get; set; }


    }
}
