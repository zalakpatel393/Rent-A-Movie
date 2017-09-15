using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RAM.Startup))]
namespace RAM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
