using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ESystem.Startup))]
namespace ESystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
