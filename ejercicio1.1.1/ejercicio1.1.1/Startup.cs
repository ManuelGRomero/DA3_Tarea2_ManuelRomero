using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ejercicio1._1._1.Startup))]
namespace ejercicio1._1._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
