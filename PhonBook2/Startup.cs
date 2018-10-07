using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhonBook2.Startup))]
namespace PhonBook2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
