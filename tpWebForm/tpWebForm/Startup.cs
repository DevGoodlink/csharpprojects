using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tpWebForm.Startup))]
namespace tpWebForm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
