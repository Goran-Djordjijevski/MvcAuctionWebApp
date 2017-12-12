using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAuctionWebApp.Startup))]
namespace MvcAuctionWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
