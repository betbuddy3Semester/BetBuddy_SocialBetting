using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BetBuddyWeb.Startup))]
namespace BetBuddyWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
