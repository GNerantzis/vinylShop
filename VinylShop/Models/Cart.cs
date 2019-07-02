using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinylShop.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public ICollection<Vinyl> VinylsPurchased { get; set; }
    }
}