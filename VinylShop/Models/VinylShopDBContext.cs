using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace VinylShop.Models
{
    public class VinylShopDBContext : DbContext
    {
        public VinylShopDBContext(): base("name=VinylShop") { }

        public DbSet<Vinyl> Vinyls { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}