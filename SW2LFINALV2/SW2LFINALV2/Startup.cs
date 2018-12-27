using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SW2LFINALV2.Startup))]
namespace SW2LFINALV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
