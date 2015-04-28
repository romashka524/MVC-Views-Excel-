using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Views.Startup))]
namespace MVC_Views
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
