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

        public string weight { get; set; }

        public string name {get; set;}

        public List<ProductSeries> productSeries { get; set; }


    }
}
