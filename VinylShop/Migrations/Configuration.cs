namespace VinylShop.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VinylShop.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VinylShopDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VinylShopDBContext context)
        {

            var vinyls = new List<Vinyl>
            {
                new Vinyl{Artist="Astral Projection",Title="Dancing Galaxy",ReleaseYear=1997,Label="IMK",Genre="Psytrance",Price=30,image="apdc.png",audioclip="1.ogg"},
                new Vinyl{Artist="Astrix",Title="Artcore",ReleaseYear=2004,Label="Hommega",Genre="Psytrance",Price=25,image="artcore.png",audioclip="1.ogg"},
                new Vinyl{Artist="Alkinoos Ioannidis",Title="Stin Agora Tou Kosmou",ReleaseYear=1996,Label="Cobalt Music",Genre="Folk",Price=25,image="agora.png",audioclip="1.ogg"},
                new Vinyl{Artist="Rammstein",Title="Mutter",ReleaseYear=2000,Label="Universal",Genre="Metal",Price=40,image="mutter.png",audioclip="1.ogg"}
            };

            vinyls.ForEach(s => context.Vinyls.Add(s));
            context.SaveChanges();
        }

        //  This method will be called after migrating to the latest version.

        //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        //  to avoid creating duplicate seed data.
    }
    
}
