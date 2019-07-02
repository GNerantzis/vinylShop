using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinylShop.Models
{
    public class CustomerVinylViewModel
    {
        public IEnumerable<Vinyl> Vinyls { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}