using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PollingApp.Startup))]
namespace PollingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
