using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OM_App.Startup))]
namespace OM_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
