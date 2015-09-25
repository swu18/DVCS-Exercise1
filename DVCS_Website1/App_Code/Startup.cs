using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DVCS_Website1.Startup))]
namespace DVCS_Website1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
