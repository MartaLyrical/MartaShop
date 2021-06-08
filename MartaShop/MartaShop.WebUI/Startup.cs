using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MartaShop.WebUI.Startup))]
namespace MartaShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
