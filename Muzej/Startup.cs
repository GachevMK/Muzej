using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Muzej.Startup))]
namespace Muzej
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
