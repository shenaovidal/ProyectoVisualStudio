using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoTEST.Startup))]
namespace ProyectoTEST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
