using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Common.Dtos
{
    public class CustomersAddDto
    {
   
        public string Name { get; set; }
        public string? ContactName { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
    }
}
