using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sivel_proyecto_bad115.Startup))]
namespace sivel_proyecto_bad115
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
