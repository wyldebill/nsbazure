using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebRole3.Startup))]
namespace WebRole3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
