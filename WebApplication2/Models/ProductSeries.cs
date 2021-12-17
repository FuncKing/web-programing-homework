using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ProductSeries
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public int quantity { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public float? price { get; set; }

        [Required]
        public Product product { get; set; }

        [Required]
        public DateTime buyTime { get; set; }

        [Required]
        public Seller seller { get; set; }

        [Required]
        public List<Sale> sales { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public float? cost { get; set; }

    }
}
