using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Estados.Startup))]
namespace Estados
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
