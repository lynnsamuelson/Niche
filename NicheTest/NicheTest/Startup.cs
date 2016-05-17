using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NicheTest.Startup))]
namespace NicheTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
