using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VinylShop.Startup))]
namespace VinylShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
