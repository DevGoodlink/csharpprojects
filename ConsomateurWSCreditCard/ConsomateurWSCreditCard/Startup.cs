using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsomateurWSCreditCard.Startup))]
namespace ConsomateurWSCreditCard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
