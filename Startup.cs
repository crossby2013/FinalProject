using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoterSite.Startup))]
namespace VoterSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
