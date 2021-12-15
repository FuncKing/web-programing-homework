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

        public int quntity { get; set; }

        [DataType(DataType.Currency)]
        public int price { get; set; }

        public ProductSeries productSeries { get; set; }
    }
}
