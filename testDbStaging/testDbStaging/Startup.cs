using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testDbStaging.Startup))]
namespace testDbStaging
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
