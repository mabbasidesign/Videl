using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Videl.Startup))]
namespace Videl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
