using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Citus.Education.WebApp.Sample.Web.Startup))]
namespace Citus.Education.WebApp.Sample.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
