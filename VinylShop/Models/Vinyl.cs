using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinylShop.Models
{
    public class Vinyl
    {
        public int ID { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Label { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
        public string image { get; set; }
        public string audioclip { get; set; }
    }
}