using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DockCafe.Startup))]
namespace DockCafe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
