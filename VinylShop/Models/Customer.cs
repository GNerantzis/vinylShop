using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinylShop.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Vinyl> Vinyls { get; set; }
    }
}