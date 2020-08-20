using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAppWithAuthentication.Startup))]
namespace MvcAppWithAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
