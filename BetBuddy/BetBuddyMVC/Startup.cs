using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BetBuddyMVC.Startup))]
namespace BetBuddyMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
