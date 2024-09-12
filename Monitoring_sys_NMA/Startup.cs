using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Monitoring_sys_NMA.Startup))]
namespace Monitoring_sys_NMA
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
