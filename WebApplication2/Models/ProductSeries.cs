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

        public string name { get; set; }

        public int quantity { get; set; }

        [DataType(DataType.Currency)]
        public float? price { get; set; }

        public Product product { get; set; }

        public DateTime buyTime { get; set; }

        public Seller seller { get; set; }

        public List<Sale> sales { get; set; }

        [DataType(DataType.Currency)]
        public float? cost { get; set; }

    }
}
