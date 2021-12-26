using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Seller
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        [JsonIgnore]
        public List<ProductSeries> productSeries { get; set; }
    }
}
