using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dashboard_mvc.Startup))]
namespace dashboard_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
