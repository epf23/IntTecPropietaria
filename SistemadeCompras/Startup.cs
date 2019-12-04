using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using SistemadeCompras.Data;

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
