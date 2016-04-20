using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PesqueriaArtesanal.Startup))]
namespace PesqueriaArtesanal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
