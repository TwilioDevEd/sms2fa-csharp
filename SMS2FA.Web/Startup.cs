using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMS2FA.Web.Startup))]
namespace SMS2FA.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
