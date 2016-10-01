using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LuxBrands.Startup))]
namespace LuxBrands
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
