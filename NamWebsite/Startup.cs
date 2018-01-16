using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NamWebsite.Startup))]
namespace NamWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
