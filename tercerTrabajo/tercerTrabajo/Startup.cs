using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tercerTrabajo.Startup))]
namespace tercerTrabajo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
