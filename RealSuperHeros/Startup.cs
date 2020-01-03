using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RealSuperHeros.Startup))]
namespace RealSuperHeros
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
