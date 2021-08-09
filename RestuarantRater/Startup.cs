using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestuarantRater.Startup))]
namespace RestuarantRater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
