using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECWesbsite.Startup))]
namespace ECWesbsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
