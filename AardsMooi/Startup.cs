using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AardsMooi.Startup))]
namespace AardsMooi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
