using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UdemyShop.WebUI.Startup))]
namespace UdemyShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
