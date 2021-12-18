using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ErrorMVC
    {
        public string Type { get; set; }
        public string GeneralMessage { get; set; }
        public string InnerMessage { get; set; }

        public ErrorMVC(Exception ex)
        {
            Type = ex.GetType().Name;
            GeneralMessage = ex.Message;
            InnerMessage = ex.InnerException?.Message;
        }
    }
}
