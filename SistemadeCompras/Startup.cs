using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemadeCompras.Startup))]
namespace SistemadeCompras
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
